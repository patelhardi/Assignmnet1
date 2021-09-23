using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmnet1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// ///Hello Testing
        /// Add 10 into the input number
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>inpt number plus 10</returns>
        /// <example>GET api/addten/0 -> 10</example>
        public int Get(int id)
        {
            int addTen = id + 10;
            return addTen;
        }
    }
}
