using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WenhaoLu_Assign1.Controllers
{
    /// <summary>
    /// Question 1: Returns 10 more than the integer input {id}
    /// </summary>
    /// <returns> 
    ///     integer id + 10
    /// </returns>
    /// <example> 
    ///     GET /api/assign1/AddTen/21     ->  31
    /// </example>
    ///
    ///
    public class assign1Controller : ApiController
    {
        [HttpGet]
        public int AddTen(int id)
        {
            return 10 + id;
        }

    /// <summary>
    /// Question 2: Returns the square of the integer input {id}.
    /// </summary>
    /// <returns> 
    ///     integer id * id
    /// </returns>
    /// <example> 
    ///     GET /api/assign1/Square/10     ->  100
    /// </example>
    ///
    ///
        [HttpGet]
        public int Square(int id)
        {
            return id * id;
        }

    /// <summary>
    /// Question 3: Returns the string “Hello World!”
    /// </summary>
    /// <returns> 
    ///     string “Hello World!”
    /// </returns>
    /// <example> 
    ///     GET /api/assign1/Greeting     ->  Hello World!
    /// </example>
    ///
    ///
        [HttpPost]
        public string Greeting()
        {
            return "Hello World!";
        }

    /// <summary>
    /// Question 4: Returns the string “Greetings to {id} people!” where id is an integer value.
    /// </summary>
    /// <returns> 
    ///     string "Greetings to string(int id) people!"
    /// </returns>
    /// <example> 
    ///     GET /api/assign1/Greeting/6     ->  Greetings to 6 people!
    /// </example>
    ///
    ///

        [HttpGet]
        public string Greeting(int id)
        {
            return "Greetings to " + id + " people!";
        }
            
    /// <summary>
    /// Question 5: Create a method which has an input {id}, and applies four mathematical operations to it
    /// </summary>
    /// <returns> 
    ///     integer (id * 12 / 3 - 2 + 17) chosen four mathematical operations to {id}
    /// </returns>
    /// <example> 
    ///     GET /api/assign1/NumberMachine/15     ->  75
    /// </example>
    ///
    ///
        [HttpGet]
        public int NumberMachine(int id)
        {
            return id * 12 / 3 - 2 + 17;   
        }

        /// <summary>
        /// Question 6: Initiative Question
        /// </summary>
        /// <returns> 
        ///     14 days' fee ($5.5CAD) can be counted like a Set of One Round, client need to pay at least One Set.
        ///     When the client stays less than 14 days, will be charged for total $CAD = 1*5.5 plus 13% tax.
        ///     When the client stays more than 14 days, will be charged for beforeTax = (1+ round down{id/14})* 5.5 || (round up{id/14})* 5.5
        ///     then total $CAD = beforeTax * 1.13.
        ///     I can't get the codes run, because I am very confused with C# syntax. I need time to practise and get familiar with them. 
        /// </returns>
        /// <example> 
        ///     GET /api/assign1/NumberMachine/15     ->  75
        /// </example>
        /// 
        ///

        [Route("api/HostingCost/{id}")]
        [HttpGet]
        public IEnumerable<string> HostingCost(int id)
        {   
            if (id < 15) {
                IEnumerable<string> HostingCost = new string[] { "1 fortnights at $5.5/FN = $5.5 CAD", "HST 13% = $0.72 CAD", "Total = $6.22 CAD" };
            return HostingCost;
            }

            if (id >= 15)
            {
                var timeFN = Math.Round(id / 14m);
                IEnumerable<string> HostingCost = new string[] {timeFN + " fortnights at $5.5/FN = $" + timeFN * 5.5 + "CAD", "HST 13% = $" + timeFN * 5.5 * 0.13 + " CAD", "Total = $" + timeFN * 5.5*1.13 + "CAD" };
                return HostingCost;
            }
        }


    











    }
}
