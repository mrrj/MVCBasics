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

        [HttpGet]
        public IActionResult GuessingGame()
        {
            HttpContext.Session.SetInt32("Number", rand.Next(1,101));
            return View();
        }

        [HttpPost]
        public IActionResult GuessingGame(int guess)
        {
            int num = (int)HttpContext.Session.GetInt32("Number");

            if (guess == 0)
            {
                ViewBag.Message = "No guess was made";
            }
            else if (guess == num)
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
