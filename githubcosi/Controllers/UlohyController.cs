using githubcosi.Models;
using Microsoft.AspNetCore.Mvc;

namespace githubcosi.Controllers
{
    public class UlohyController : Controller
    {
        public IActionResult Uloha1()
        {
            return View();
        }


        public IActionResult Uloha2()
        {
            return View();
        }

        public IActionResult Uloha3()
        {
            return View();
        }


        public IActionResult Uloha4()
        {
            List<UserInfo> users = new List<UserInfo>
            {
            new UserInfo { Name = "Alojz", Surname = "Gec", Email = "jojka@tv.sk" },
            new UserInfo { Name = "Janko", Surname = "Kolenik", Email = "markiza@tv.sk" },
            new UserInfo { Name = "Ley", Surname = "Lofaj", Email = "mag@wrap.cz" }
            };

            return View(users);
        }


        public IActionResult Uloha5()
        {

            List<UserInfo> users = new List<UserInfo>
            {
            new UserInfo { Name = "Alojz", Surname = "Gec", Email = "jojka@tv.sk" },
            new UserInfo { Name = "Janko", Surname = "Kolenik", Email = "markiza@tv.sk" },
            new UserInfo { Name = "Ley", Surname = "Lofaj", Email = "mag@wrap.cz" },
            new UserInfo { Name = "Alojz", Surname = "Gec", Email = "jojka@tv.sk" },
            new UserInfo { Name = "Janko", Surname = "Kolenik", Email = "markiza@tv.sk" },
            new UserInfo { Name = "Ley", Surname = "Lofaj", Email = "mag@wrap.cz" }

            };
            return View(users);
        }

        public IActionResult Uloha6()
        {
            return View();
        }

        public IActionResult Uloha7()
        {
            return View();
        }


        public IActionResult Uloha8()
        {
            return View();
        }
    }   
        
}

