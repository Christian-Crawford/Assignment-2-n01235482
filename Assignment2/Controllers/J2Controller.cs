using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.App_Start
{/// <summary>
/// To see the amount of combinations possible in two named dice to get to a sum of ten
/// </summary>
/// <parm name="dice 1">The amount of sides on the 1st dice</parm>
/// <parm name="dice 2">The amount of sides on the 2nd dice</parm>
/// <example>.api/J2/DiceGame/3/3 -> There are 0 ways to get to a sum of ten</example>
/// <retuns> "There are 0 ways total to get the sum of ten</retuns>
    public class J2Controller : ApiController
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{dice1}/{dice2}")]
        public string DiceGame(int dice1, int dice2)
        {
            
           
            int sumcounter = 0;

            for (int counter1 = 1; counter1 <= dice1; counter1++)
            {
                for(int counter2 = 1; counter2 <= dice2; counter2++)
                {
                    if (counter1 + counter2 == 10)
                    {
                        sumcounter++;
                    }
                }
            }

            return "There are "+ sumcounter + " total ways to get the sum of 10";
        }

    }
}
