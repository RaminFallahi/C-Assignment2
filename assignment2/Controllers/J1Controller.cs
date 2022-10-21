using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment2.Controllers
{

    public class J1Controller : ApiController
    {
        /// <summary>
        /// </summary>
        //<example>
        //api/J1/Menu/{burger}/... ===> api/J1/menu/1/0/0/0 ====> 461
        //<example>
        /// <returns>returns the totaCalory of the user input (0,1,2,3)</returns>
        /// <example>
        //api/J1/Menu/{burger}/... ===> api/J1/menu/1/1/1/1
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public int Menu(int burger, int drink, int side, int dessert)
        {
            
            int totalCalory = 0;

            if (burger == 1)
            {
                totalCalory += 461;
            }
            else if (burger == 2)
            {
                totalCalory += 431;
            }
            else if (burger == 3)
            {
                totalCalory += 420;
            }


            if (side == 1)
            {
                totalCalory += 100;
            }
            else if (side == 2)
            {
                totalCalory += 57;
            }
            else if (side == 3)
            {
                totalCalory += 70;
            }
            
            
            if (drink == 1)
            {
                totalCalory += 130;
            }
            else if (drink == 2)
            {
                totalCalory += 160;
            }
            else if (drink == 3)
            {
                totalCalory += 118;
            }
            
            
            if (dessert == 1)
            {
                totalCalory += 167;
            }
            else if (dessert == 2)
            {
                totalCalory += 266;
            }
            else if (dessert == 3)
            {
                totalCalory += 75;
            }

            return totalCalory;
        }
    }
}

