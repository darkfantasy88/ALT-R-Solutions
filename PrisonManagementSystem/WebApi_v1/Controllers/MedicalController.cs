using ManagementLibrary.Api.Models.Medical;
using ManagementLibrary.Sql._Internal._SqlDataAccess._Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebApi_v1.Controllers
{
    [EnableCors("*","*","*")]
    [RoutePrefix("api/medical")]
    public class MedicalController : ApiController
    {
        IMedicalDataAccess _medical;
        public MedicalController(IMedicalDataAccess medicial)
        {
            _medical = medicial;
        }
        //List<Person> people = new List<Person>()
        //{
        //    new Person(){FirstName="Rohan",LastName="Cooper",
        //        Age =20,Occupation="Student"},
        //    new Person(){FirstName="Avianna",LastName="Williams",
        //        Age =20,Occupation="Student"},
        //    new Person(){FirstName="Toni-Ann",LastName="Wright",
        //        Age =20,Occupation="Student"},
        //    new Person(){FirstName="Lilli-Ann",LastName="Longmore",
        //        Age =20,Occupation="Student"}
        //};
        // GET: api/Medical
        [Route("getall")]
        [HttpGet]
        public IEnumerable<IMedicial> Get()
        {
            return _medical.GetMedical();
        }

        // GET: api/Medical/5
        [Route("getperson/{firstname}/{lastname}")]
        [HttpGet]
        public IMedicial Get(string firstname,string lastname)
        {
            return null;
            //return people.Where(x=> x.FirstName==firstname && x.LastName==lastname).FirstOrDefault();
        }

        // POST: api/Medical
        [HttpPost]
        [Route("insertperson")]
        //This must change
        public void Post([FromBody]string value)
        {
            //people.Add(value);
        }

        // PUT: api/Medical/5
        //This mmust change
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Medical/5
        public void Delete(int id)
        {
        }
    }

    /*public class Person 
    {
      public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }

    }*/
}
