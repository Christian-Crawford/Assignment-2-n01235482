using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
       
        /// <summary>
        /// Tracking a game of snakes and ladders
        /// is the J3 problem from the 2003 test
        /// </summary>
        /// <param name="dicetotal">The total amount of 2 d6 rolled</param>
        /// <PROBLEM>I dont really know how to make the sqaurecounter variable persist between reloads.</PROBLEM>
        /// <returns>Will track the counter through the related snakes and ladders and wait till a win state is reached</returns>
        
        [HttpGet]
        [Route("api/J3/Snakes/{dicetotal}")]
       
        public string Snakes(int dicetotal)
        {
            int squarecounter = 1;

            if (dicetotal == 0)
            {
                return "You Quit!";
            }

            if (dicetotal > 0 || dicetotal <= 12)
            {
                squarecounter = squarecounter + dicetotal;


                if (squarecounter == 54)
                {
                    squarecounter = 19;
                }

                if (squarecounter == 90)
                {
                    squarecounter = 48;
                }
                if (squarecounter == 99)
                {
                    squarecounter = 77;
                }

                if (squarecounter == 9)
                {
                    squarecounter = 34;
                }

                if (squarecounter == 40)
                {
                    squarecounter = 64;
                }

                if (squarecounter == 67)
                {
                    squarecounter = 86;
                }

                

                if (squarecounter > 100)
                {
                    squarecounter = squarecounter - dicetotal;
                }
            }

            if (squarecounter == 100)
            {
                return "You Win!";
            }
            else
            {
                return "Your current sqaure is " + squarecounter;
            }


            
        }
    }
}
