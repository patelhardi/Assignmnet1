using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmnet1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// square of the input number
        /// </summary>
        /// <param name="id">Input number that we have to square</param>
        /// <returns>sqaure of the input number</returns>
        /// GET api/square/2 -> 4
        public int Get(int id)
        {
            var square = id * id;
            return square;
        }
    }
}
