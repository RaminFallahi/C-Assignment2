using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Write a program which determines how many ways you can roll 2 dices(m&n) the value of 10.
        /// </summary>
        //<example>
        //api/J2/DiceGame/5/5 ... ===>   There is 1 way to get the sum 10.
        //<example>
        /// <returns>returns the possibility of the reaching 10 by rolling two dices M & N</returns>
        /// <example>
        //api/J2/DiceGame/5/5... ===> api/J2/DiceGame/5/5
        [HttpGet]
        [Route("api/J2/DiceGame/{n}/{m}")]
        public int DiceGame(int n, int m)
        {
            int tenCounter = 0;
            for (int i = 0; i <= n; i++) 
            {
                for (int j = 0; j <= m; j++) 
                {
                    if (i + j == 10) 
                    tenCounter++;
                }
            } return tenCounter;
        }
    }
}
