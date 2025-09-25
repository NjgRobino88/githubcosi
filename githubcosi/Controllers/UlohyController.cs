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
            new UserInfo { Name = "Alojz", Surname = "Gec", Emaili = "jojka@tv.sk" },
            new UserInfo { Name = "Janko", Surname = "Kolenik", Emaili = "markiza@tv.sk" },
            new UserInfo { Name = "Ley", Surname = "Lofaj", Emaili = "mag@wrap.cz" }
            };

            return View(users);
        }


        public IActionResult Uloha5()
        {

            List<UserInfo> users = new List<UserInfo>
            {
            new UserInfo { Name = "Alojz", Surname = "Gec", Emaili = "jojka@tv.sk" },
            new UserInfo { Name = "Janko", Surname = "Kolenik", Emaili = "markiza@tv.sk" },
            new UserInfo { Name = "Ley", Surname = "Lofaj", Emaili = "mag@wrap.cz" },
            new UserInfo { Name = "Alojz", Surname = "Gec", Emaili = "jojka@tv.sk" },
            new UserInfo { Name = "Janko", Surname = "Kolenik", Emaili = "markiza@tv.sk" },
            new UserInfo { Name = "Ley", Surname = "Lofaj", Emaili = "mag@wrap.cz" }

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

        private static List<UserModel> _users = new List<UserModel>();


        [HttpGet]
        public IActionResult Formular()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Formular(UserModel user)
        {
            if (ModelState.IsValid)
            {
                _users.Add(user);
                return RedirectToAction("FormularShow", user);
            }
            return View(user);
        }


        [HttpGet]
        public IActionResult FormularShow(UserModel user)
        {
            return View(_users);
        }
    }   
        
}

