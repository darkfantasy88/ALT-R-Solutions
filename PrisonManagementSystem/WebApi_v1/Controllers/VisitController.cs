using ManagementLibrary.Api.Models.Visitor;
using ManagementLibrary.Sql._Internal._SqlDataAccess._Visitor;
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
    [RoutePrefix("api/visit")]
    public class VisitController : ApiController
    {
        IVisitDataAccess _visitDataAccess;
        public VisitController(IVisitDataAccess visitDataAccess)
        {
            _visitDataAccess = visitDataAccess;
        }
        // GET: api/Visit
        [HttpGet]
        [Route("getallvisits")]
        public IEnumerable<IVisitor> Get()
        {
            return _visitDataAccess.GetVisits();
        }

        // GET: api/Visit/5
        [HttpGet]
        [Route("getvisit/{schoolName}")]
        public IEnumerable<SchoolVisit> GetBySchool(string schoolName)
        {
            return _visitDataAccess.GetVisitBySchool(schoolName);
        }
        [HttpGet]
        [Route("getvisit/{institutionName}")]
        public IEnumerable<IVisitor> GetByInstitution(string institutionName)
        {
            return _visitDataAccess.GetVisitByInstitution(institutionName);
        }

        // POST: api/Visit
        [HttpPost]
        [Route("familyfriends")]
        public void InsertFamilyFriendsVisit([FromBody]FamilyFriendsVisit value)
        {
            
            _visitDataAccess.InsertVisitor(value);
        }

        // PUT: api/Visit/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Visit/5
        public void Delete(int id)
        {
        }
    }
}
