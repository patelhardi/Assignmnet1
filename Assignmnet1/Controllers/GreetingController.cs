using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmnet1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// return string 'Hello World!'
        /// </summary>
        /// <returns>string 'Hello World!'</returns>
        /// POST api/greeting -> 'Hello World!' 
        /// need command prompt for output curl -d "" http://localhost:50779/api/greeting -> 'Hello World!'
        public string POST()
        {
            return "Hello World!";
        }

        /// <summary>
        /// display string with integer input value
        /// </summary>
        /// <param name="id">input value for greeting that many people</param>
        /// <returns>string with input value</returns>
        /// GET api/greeting/3 -> 'Greeting to 3 people!'
        public string Get(int id)
        {
            return "Greeting to " + id + " People!";
        }
    }
}
