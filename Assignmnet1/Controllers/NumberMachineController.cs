using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmnet1.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// perform 4 mathematical expression
        /// add 10 to input number
        /// multiply that number with 2
        /// divide the result with 5
        /// subtract 1 from that result
        /// </summary>
        /// <param name="id">input number to do mathematical expressions</param>
        /// <returns>total number int value after all expression</returns>
        /// <example>GET api/numbermachine/-5 -> 1</example>

        public int Get(int id)
        {
            var addTen = id + 10;
            var multiTwo = addTen * 2;
            var divideFive = multiTwo / 5;
            var subOne = divideFive - 1;
            return subOne;
        }
    }
}
