using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public int RandomNumber { get; private set; }

        //localhost:5000
        [HttpGet("")]
        public ViewResult Index()
        {
            string messages = "Here are some messages";

            return View("Index", messages);
        }

        [HttpGet("/numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1,2,3,10,43,5
            };
            return View("Numbers", numbers);
        }

        [HttpGet("/users")]
        public IActionResult Names()
        {
            // to a View that has defined a model as @model string[]
            List<string> names = new List<string>()
            {
                "Sally",
            "Billy",
            "Joey",
            "Moose"
            };
            
            return View("Names", names);
        }

        [HttpGet("/user")]
        // to a View that has defined a model as @model string[]
        public IActionResult oneUser()
        {
            List<string> names = new List<string>()
            {
                "Sally",
                "Billy",
                "Joey",
                "Moose"
            };

         
            User userViewModel = new User()
            {
                names = names,
                RandomNumber = new Random().Next()

            }; 


            
            return View("Oneuser", userViewModel);
        }
    }
}
