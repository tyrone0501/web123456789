using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // https://localhost:44341/HelloWorld
        //
        //GET: /HelloWorld/
        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        public IActionResult Index()
        {
            return View();
        }

        //
        //GET: /HelloWorld/Welcome/
        //public string Welcome(string name, int ID = 1)
        //{
        //    //return "This is the Welcome action method";
        //    //return HtmlEncoder.Default.Encode($"Hello {name}, NumTiems is: {numTimes}");
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["numTimes"] = numTimes;

            return View();
        }

        // /[Controller]/[ActionName]/[Parameters]
        // /HelloWordlController/Welcome?name=Tyrone&numtimes=4
    }
}
