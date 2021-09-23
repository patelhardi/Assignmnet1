using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignmnet1.Controllers
{
    public class HostingCostController : ApiController
    {
        //declare variables
        public int days;
        public double priceperday;
        public double hst;
        public double total;

        /// <summary>
        /// Charging client for 14 days at $5.50 CAD plus 13% HST display 3 strings with Total cost
        /// </summary>
        /// <param name="id">input value passing days client used web hosting</param>
        /// <returns>3 strings with price per days charge to the client, hst on base of that price, and total cost by adding hst & price per day</returns>
        /// IEnumerable<string> returns multiple strings, used for string array
        /// Math.Round(variablename, 2).toString("0.00") used fo to display round amount after 2 digits 
        /// GET api/hostingcost/0 -> '1 fortnight at $5.50/FN = $5.50 CAD', 'HST 13% = $0.72 CAD', 'Total = $6.22 CAD'
        public IEnumerable<string> Get(int id)
        {
            days = (id / 14) + 1;       
            priceperday = days * 5.50;          
            hst = priceperday * 0.13;           
            total = priceperday + hst;          
            return new string[] { days + " fortnights at $5.50/FN = $" + Math.Round(priceperday,2).ToString("0.00") + " CAD", "HST 13% = $" + Math.Round(hst,2).ToString("0.00") +" CAD", "Total = $" + Math.Round(total,2).ToString("0.00") + " CAD"};
        }
    }
}
