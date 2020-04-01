using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_v1.Controllers
{
    public class MedicalController : ApiController
    {
        // GET: api/Medical
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Medical/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Medical
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Medical/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Medical/5
        public void Delete(int id)
        {
        }
    }
}
