using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KnockoutJS.Models;

namespace KnockoutJS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet, Route("person/edit")]
        public IActionResult PersonDetails()
        {
            PersonViewModel personViewModel = new PersonViewModel();

            return View(personViewModel);
        }

        [HttpPost, Route("person/edit")]
        public IActionResult PersonDetails(PersonViewModel personViewModel)
        {
            personViewModel.LastUpdated = DateTime.Now.ToString();
            return new JsonResult(personViewModel);
        }
    }
}
