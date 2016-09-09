using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //[Authorize]
    public class DataServiceController : ApiController
    {
        // GET api/dataservice/customers
        [HttpGet]
        public IEnumerable<Customer> Customers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name="John Doe" },
                new Customer { Id = 2, Name = "Jane Doe" }
            };
        }

        // GET api/dataservice/customers/5
        [HttpGet]
        public Customer Customers(int id)
        {
            return new Customer { Id = 1, Name = "John Doe" };
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
