﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
//using MongoDB.Driver;
using MyCV.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyCV.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;
        //private readonly MongoClient Client;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            this.configuration = configuration;
            //Client = new MongoClient(configuration.GetConnectionString("MVConnectionString"));
        }

        public IActionResult Index()
        {
            // var database = Client.GetDatabase("bkhovme9upbvyna").GetCollection<About>("About");
            //var result = database.Find(x => x.OpenToWork == "Yes").FirstOrDefault();
            var about = new About
            {
                Title = "Kourosh Sajjadi",
                Birtday = "1999",
                Degree = "Master",
                City = "Pavia",
                Email = "kourosh_sajjadi@outlook.com",
                Phone = "+393792398297",
                OpenToWork = "Yes",
                Text1 = "I'm a software developer who loves learning more and sharing my knowledge.I'm keen on working as a team member on projects.Student Data science at Pavia university now.",
                Text3 = "I am a software developer who loves learning more and sharing my knowledge. I am studying Computer engineering at Pavia university for my master's degree. I am keen on working as a team member on projects.Over 7 years of experience in web, Desktop application development involved in all stages of the Software Development Life Cycle.Experienced in .Net and refactoring, SOLID principles, and Clean Architecture.Familiar with python development, Joined in different industries such as Terminal handling, shipping, medical, capital marketing, Bank Infrastructure, and ERP system.",
                subTitle = "Computer Engineer"
            };

            return View(about);
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
