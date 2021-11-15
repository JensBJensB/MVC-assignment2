using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class FeverModel
    {
        public int Temperature { get; set; }

        public static string PromptForTemperature() => " ";


        public string CheckFever(int temperature)
        {
            string message;

            if (temperature < 34)
                message = "Tell him to set fire to his flat and get warm";
            else if (temperature < 39)
                message = "He is fine *hangs up*";
            else 
                message = "Ask if he got any last wishes";

            return message;
        }
    }
}


