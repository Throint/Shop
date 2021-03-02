using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestEFC.ModelView;
using TestEFC.Models;
using Microsoft.AspNetCore.Authorization;

namespace TestEFC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext appDbContext;

        public HomeController(ILogger<HomeController> logger, AppDbContext appDb)
        {
            appDbContext = appDb;
            _logger = logger;
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
               user1.Role = "Admin";
              //  user1.Salary = user.SalaryUser;
                await appDbContext.ClientsInfo.AddAsync(user1);
                await appDbContext.SaveChangesAsync();
          //      RedirectToAction("Index", "Home");

                return Redirect("/");
            }
           return  RedirectToAction("CreateUser", "Home");



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
