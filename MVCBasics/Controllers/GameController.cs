using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Controllers
{
    public class GameController : Controller
    {
        Random rand = new Random();
        int num;

        [HttpGet]
        public IActionResult GuessingGame()
        {

            HttpContext.Session.SetInt32("Number", rand.Next(101));
            num = (int)HttpContext.Session.GetInt32("Number");
            ViewBag.Message = "The number is " + num;
            return View();
        }

        [HttpPost]
        public IActionResult GuessingGame(int guess)
        {

            if (guess == num)
            {
                ViewBag.Message = "Congratulations! Your guess was correct.";
            }
            else if(guess > num)
            {
                ViewBag.Message = "Your guess was too high! Guess again.";
            }
            else
            {
                ViewBag.Message = "Your guess was too low! Guess again";
            }

            return View();
        }
    }
}
