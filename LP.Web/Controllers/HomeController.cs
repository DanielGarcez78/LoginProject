using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LP.Web.Models;
using LP.Services;

namespace LP.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index([FromForm]LoginViewModel login)
        {
            try
            {
                if (LoginService.ValidaLogin(login.Nome, login.Senha))
                {
                    ViewBag.LoginOk = true;                    
                }
                else
                {
                    ViewBag.LoginOk = false;                    
                }
                return View();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " - " + e.StackTrace);
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
