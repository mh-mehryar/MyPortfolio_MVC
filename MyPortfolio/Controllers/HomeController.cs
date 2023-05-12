using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Diagnostics;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        //private readonly List<MyText> texts = new List<MyText>
        //{
        //    new MyText
        //    {
        //        Id = 1,Title ="Mohammad",Image="portfolio-1.jpg",Description ="First Text"
        //    },new MyText
        //    {
        //        Id = 2,Title ="Ali",Image="portfolio-2.jpg",Description ="Second Text"
        //    },new MyText
        //    {
        //        Id = 3,Title ="Mina",Image="portfolio-3.jpg",Description ="Third Text"
        //    },new MyText
        //    {
        //        Id = 4,Title ="Maryam",Image="portfolio-4.jpg",Description ="Fourth Text"
        //    }
        //};
        
        public IActionResult Index()
        {
            ViewData["HeadingTitle"] = "MY Portfolio";
            //return View(texts);
            return View();
        }
        public IActionResult Contact()
        {
            var contact = new Contact()
            {
                Email = "mh.mehryar@outlook.com",
                Phone = "+98915xxxxxxX",
                Github = "https://github.com/mh-mehryar"
            };
            return View(contact);
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