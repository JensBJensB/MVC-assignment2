using Assignment1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Controllers
{
    public class DoctorController : Controller
    {

        public IActionResult FeverCheck()
        {
            ViewBag.Message = FeverModel.PromptForTemperature();
            return View();
        }
        [HttpPost]
        public IActionResult FeverCheck(int temperature)
        {
            FeverModel fm = new FeverModel();
            fm.Temperature = temperature;

            ViewBag.Message = fm.CheckFever(temperature);
            return View();
        }
    }
}





