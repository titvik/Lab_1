using System;
using Microsoft.AspNetCore.Mvc;
using lab1.Models;
namespace SampleMVCApps.Controllers
{
    public class HomeController:Controller
    {
        [ViewData]
        public string Title {get; set;}

        [ViewData]
        public string Headline {get; set;}

        Random rnd = new Random();

        CalcModel calc = new CalcModel();
        public IActionResult Index()
        {   
            Title = "Home Page";
            Headline = "Calc Service Demonstration";

            return View();
        }

        public IActionResult ModelCalc()
        {
            Title = "PassUsingModel";
            Headline = "PassUsingModel";

           // CalcModel viewModel = new CalcModel();

            return View(calc);
        }

        public IActionResult ViewDataCalc()
        {
            Title = "PassUsingViewData";
            Headline = "PassUsingViewData";

            ViewData["Calc"] = calc;

            return View();
        }

        public IActionResult ViewBagCalc()
        {
            ViewBag.Title = "PassUsingViewBag";
            ViewBag.Headline = "PassUsingViewBag";

            ViewBag.Calc = calc;

            return View();
        }

        public IActionResult ServiceDirectlyCalc()
        {
            Title = "AccessServiceDirectly";
            Headline = "AccessServiceDirectly";

            return View();
        }
    }
}