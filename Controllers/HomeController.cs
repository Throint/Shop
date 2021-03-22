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

namespace TestEFC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext appDbContext;
        private readonly EmailService emailService;
        private readonly HashService hashService;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDb, EmailService emailService, HashService hashService)
        {
            appDbContext = appDb;
            _logger = logger;
            this.emailService = emailService;
            this.hashService = hashService;
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
              var hashed=  HashService.GetHashStr(user.PassFirst, 10000);
                user1.Pass = hashed;
                user1.EmailWasConfirmed = false;
               user1.Role = "Admin";
                var token = await emailService.Token(user1);
               await EmailService.SendEmailAsync(user1.UserMail, "Confirm", token);
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
    }
}
