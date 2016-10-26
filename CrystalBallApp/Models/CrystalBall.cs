using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalBallApp.Models
{
    public class CrystalBall
    {
        //get random number
        //create array of strings for responses

        public string getResponse()
        {
            string[] responses = { "Geronimo!", "I like bananas. Bananas are good.", "Allonsy!", "Run!", "Planet of the pudding brains!" };

            Random randomNum = new Random();
            var num = randomNum.Next(0, responses.Length);
            return responses[num];
        }
    }
}