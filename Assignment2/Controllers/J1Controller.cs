using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Calculates the total calories of a selected mean
        /// </summary>
        /// <param name="burger"></param>
        /// <param name="drink"></param>
        /// <param name="side"></param>
        /// <param name="dessert"></param>
        /// <example>./api/J1/Menu/4/4/4/4 ->Your total calorie count is 0  </example>
        /// <returns>The message "Your total calorie count is " with the calculated total at the end;</returns>
      [HttpGet]
      [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string GETMenu(int burger, int drink, int side, int dessert)
        {
            int calories1 = 0;
            int calories2 = 0;
            int calories3 = 0;
            int calories4 = 0;

            if (burger == 1)
            {
                calories1 = 461;
            }
            else if (burger == 2)
            {
                calories1 = 431;
            }
            else if (burger == 3)
            {
                calories1 = 420;
            }
            else if (burger == 4)
            {
                calories1 = 0;
            }

            if (drink == 1)
            {
                calories2 = 130;
            }
            else if (drink == 2)
            {
                calories2 = 160;
            }
            else if (drink == 3)
            {
                calories2 = 118;
            }
            else if (drink == 4)
            {
                calories2 = 0;
            }

            if (side == 1)
            {
                calories3 = 100;
            }
            else if (side == 2)
            {
                calories3 = 57;
            }
            else if (side == 3)
            {
                calories3 = 70;}

            else if (side == 4)
            {
                calories3 = 0;
            }

                if (dessert == 1)
                {
                    calories4 = 167;
                }
                else if (dessert == 2)
                {
                    calories4 = 266;
                }
                else if (dessert == 3)
                {
                    calories4 = 75;
                }
                else if (dessert == 4)
                {
                    calories4 = 0;
                }

            int totalcalories = calories1 + calories2 + calories3+ calories4;

            

                return "Your total calorie count is "+ totalcalories;
        }


    }
}
