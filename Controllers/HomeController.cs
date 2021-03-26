using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TestEFC.Services;
using System.Threading.Tasks;
using TestEFC.ModelView;
using TestEFC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace TestEFC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext appDbContext;
        private readonly EmailService emailService;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly HashService hashService;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDb, EmailService emailService, HashService hashService, IWebHostEnvironment environment)
        {
            appDbContext = appDb;
            _logger = logger;
            this.emailService = emailService;
            this.hashService = hashService;
            this.hostingEnvironment = environment; 
        }
        [ValidateAntiForgeryToken]
        //[Authorize(Roles ="Admin")]
        public async Task<IActionResult> Create(CreateUser user)
        {
          
           
            Models.ClientInfo user1 = new ClientInfo();
            if (user != null)
            {
                user1.FirstName = user.Name;
                user1.SecondName = user.SecondName;
                user1.UserMail = user.Email;
                string salt;
              var hashed=  HashService.GetHashStr(user.PassFirst,out salt, 10000);
                user1.Pass = hashed;
                user1.Salt = salt;
                user1.EmailWasConfirmed = false;
               user1.Role = "Admin";
                var token = await emailService.Token(user1);
                StringBuilder path = new StringBuilder(Request.Scheme);
                path.Append("://");
                path.Append(Request.Host.Value);
                path.Append("/Home/ConfirmEmail");
                path.Append("/?token=");
                StringBuilder stringBuilder = new StringBuilder(token);
                stringBuilder.Replace("+", "%2B");
                path.Append(stringBuilder.ToString());
                await EmailService.SendEmailAsync(user1.UserMail, "Confirm", path.ToString());
              //  user1.Salary = user.SalaryUser;
                await appDbContext.ClientsInfo.AddAsync(user1);
                await appDbContext.SaveChangesAsync();
          //      RedirectToAction("Index", "Home");

                return Redirect("/");
            }
           return  RedirectToAction("CreateUser", "Home");



        }

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail()
        {
            if (Request.Query.ContainsKey("token"))
            {
                string value = Request.Query["token"];
                //      string value_check = value.Replace(' ', '+');
                var ql = appDbContext.ConfirmTokens.ToList();
                for (int i = 0; i < ql.Count; i++)
                {
                    if (ql[i].Token == value)
                    {
                        TimeSpan timeSpan = new TimeSpan(0, ql[i].LifeTimeMin, 0);
                        var qw = ql[i].CreationDateTime + timeSpan;
                        if (DateTime.Compare(DateTime.Now, qw) <= 0)
                        {
                            var tmp = await appDbContext.ClientsInfo.FirstOrDefaultAsync(u => u.Id == ql[i].PersonId);
                            tmp.EmailWasConfirmed = true;
                            appDbContext.ClientsInfo.Update(tmp);
                            await appDbContext.SaveChangesAsync();
                        }
                        return RedirectToAction("Index", "Home");

                    }
                }

            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> ConfirmEmailCreate(ClientInfo _person)
        {
            string str = User.FindFirst(ClaimTypes.Email)?.Value;
            if (str != null)
            {
                var q = await appDbContext.ClientsInfo.FirstOrDefaultAsync(i => i.UserMail == str);


            }

            //more fast
            StringBuilder path = new StringBuilder(Request.Scheme);
            path.Append("://");
            path.Append(Request.Host.Value);
            path.Append("/User/ConfirmEmail");
            path.Append("/?token=");

            //  string s =Request.Scheme+"://"+ Request.Host.Value;
            ////  var allowedString = String.Concat(s.Select(i => i)) ;

            //  var tmp_res = s + "/User/ConfirmEmail";
            //  var ttt = tmp_res + "/?token=";
            var token = await emailService.Token(_person);
            StringBuilder stringBuilder = new StringBuilder(token);
            stringBuilder.Replace("+", "%2B");
            path.Append(stringBuilder.ToString());



            await appDbContext.ConfirmTokens.AddAsync(new ConfirmToken()
            {
                CreationDateTime = DateTime.Now,
                Email = _person.UserMail,

                LifeTimeMin = 10,
                Token = token,
                PersonId = _person.Id

            });
            await appDbContext.SaveChangesAsync();

            var log_tmp = await EmailService.SendEmailAsync(_person.UserMail, "Confirm", path.ToString());
            _logger.LogInformation(log_tmp);

            return RedirectToAction("Login");
        }
        public  IActionResult Show()
        {
            var rr = appDbContext.ClientsInfo.ToList();
            return View(rr);
        }
        public IActionResult CreateUser()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModelView loginUser, string returnUrl)
        {
            if (loginUser.Email != null && loginUser.Pass != null)
            {
                var p = appDbContext.ClientsInfo.Where(i => i.UserMail == loginUser.Email).FirstOrDefault();
                if (p != null)
                {
                    var temp_pass = loginUser.Pass;
                    var tmp_s = Convert.FromBase64String(p.Salt);
                    var tmp_res = HashService.GetHashStr(temp_pass, tmp_s, 10000);
                    if (tmp_res == p.Pass)
                    {
                        //if(p.WasVotedId!=null)
                        //{
                        await Authenticate(loginUser.Email); // аутентификация

                        TempData["Name"] = loginUser.Email;
                        if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        {

                            //    string st = "/";

                            var t = returnUrl.Split('/');


                            for (var i = 0; i < t.Length; i++)
                            {
                                t[i] = t[i].Replace('#', default(char));
                            }
                            var res = t.Reverse().Take(3);
                            return RedirectToAction(res.ElementAt(1), res.ElementAt(2), new { id = res.ElementAt(0) });
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }


                        //Dictionary<long, bool> tmp_v = new Dictionary<long, bool>();
                        //    tmp_v.Add(0, false);
                        //   var jsom_dictionary= System.Text.Json.JsonSerializer.Serialize(tmp_v);
                        //    await Authenticate(loginUser.Email, jsom_dictionary);
                        //    TempData["Name"] = loginUser.Email;
                        //    return RedirectToAction("Index", "Home");


                    }
                    else
                    {
                        ModelState.AddModelError("", "Некорректные логин и(или) пароль");
                    }
                }
            }
            return View(loginUser);
        }

        private async Task Authenticate(string userName)
        {


            List<Claim> claims;
            if (userName!= null)
            {
                claims = new List<Claim>
            {

                new Claim(ClaimTypes.Email, userName),

              

            };
            }
            else
            {
                claims = new List<Claim>
            {

                new Claim(ClaimTypes.Email, userName),



            };
            }
            // created object ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // set authentication cookies
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        [HttpGet]
        public IActionResult CreateItem()
        {
            return View();
        }
      //  [Authorize]
      [HttpPost]
        public async Task<IActionResult> CreateItem(CreateItem item)
        {
            Item item1 = new Item();
            item1.Name = item.Name;
            item1.Price = item.Price;
            item1.Desription = item.Desription;
            if (item.FormFile != null)
            {
                var uniqueFileName = GetUniqueFileName(item.FormFile.FileName);
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                var filePath = Path.Combine(uploads, uniqueFileName);
                item.FormFile.CopyTo(new FileStream(filePath, FileMode.Create));
                item1.Image = uniqueFileName;
               await appDbContext.Items.AddAsync(item1);
                await appDbContext.SaveChangesAsync();
                //to do : Save uniqueFileName  to your db table   
            }
            // to do  : Return something
           return RedirectToAction("Index", "Home");
         
           
            // item1.Img = item.FormFile;
          //  var img_tmp = item.FormFile;
            

            
        }
        [HttpGet]
        public async Task<IActionResult> AllItems()
        {
            var lst = appDbContext.Items.ToList();
            Dictionary<Item, FileStreamResult> keyValuePairs = new Dictionary<Item, FileStreamResult> ();
          
            for (int i=0; i<lst.Count;i++)
            {
                var uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads");
                var filePath = Path.Combine(uploads, lst[i].Image);
             var file = System.IO.File.OpenRead(filePath);
                var q_file= File(file, "imge/jpeg");
                keyValuePairs.Add(lst[i], q_file);
            }
            return View(keyValuePairs);
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "User");
        }
    }
}
