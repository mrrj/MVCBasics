using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCBasics.Models;

namespace MVCBasics.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult FeverCheck(string temperature)
        {
            if (temperature != null)
            {
                double temp = double.Parse(temperature);
                if (Doctor.HasFever(temp)) ViewBag.Message = "You have a fever";
                else ViewBag.Message = "You do not have a fever";
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}
