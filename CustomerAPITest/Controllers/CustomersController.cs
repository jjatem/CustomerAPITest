using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomerAPITest.Controllers
{
    public class CustomersController : ApiController
    {
        private CustomerContextModel dbContext = new CustomerContextModel();

        // GET api/values
        public IEnumerable<customer> Get()
        {
            return dbContext.customers.AsEnumerable();            
        }

        // GET api/values/5
        public customer Get(int id)
        {
            return dbContext.customers.AsEnumerable().Where(x => x.id == id).FirstOrDefault();
        }

        // POST api/values
        public void Post([FromBody]customer value)
        {
            int NewId = 0;

            if (value != null &&
                value is customer)
            {
                //set max id
                IEnumerable<customer> customers = dbContext.customers.AsEnumerable();

                if (customers?.Count() > 0)
                {
                    NewId = customers.Max(item => item.id) + 1;                             
                }
                else
                {
                    NewId++;
                }

                value.id = NewId;

                dbContext.customers.Add(value);
                dbContext.SaveChanges();

            }
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
