using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GreenFactory.Models;
using Microsoft.AspNetCore.Authorization;
using Service.DataLayer.ViewModels;
using Service.DataLayer.Repository;

namespace GreenFactory.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISendEmail sendEmail;

        public HomeController(ILogger<HomeController> logger, ISendEmail sendEmail)
        {
            _logger = logger;
            this.sendEmail = sendEmail;
        }

        public IActionResult Index()
        {
            ViewData["Header"] = "Home";
            return View();
        }

        public IActionResult AboutUs()
        {
            ViewData["Header"] = "About us";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Header"] = "Contact";
            return View();
        }
        [HttpPost]
        public IActionResult Contact(EmailInfo emailInfo)
        {
            if (ModelState.IsValid)
            {
                var IsEmailSent = sendEmail.SendEmailToCustomer(emailInfo);

                if (IsEmailSent)
                {
                    ViewBag.success = "تم ارسال البريد الالكتروني بنجاح، شكراً لتواصلكم معنا...";

                    ViewData["Header"] = "Contact";
                    return View();
                }
                else
                {
                    ViewBag.success = "حدث خطأ نرجو المحاولة مرة اخرى...";
                }
                
            }
            ViewData["Header"] = "Contact";
            return View(emailInfo);
        }

        public IActionResult Products()
        {
            ViewData["Header"] = "Contact";
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
