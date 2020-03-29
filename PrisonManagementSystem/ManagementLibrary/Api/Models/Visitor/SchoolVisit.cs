using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Visitor
{
    public class SchoolVisit : IVisitor
    {
        public string VisitStatus { get; set; }
        public string PrisonName { get; set; }
        public string PurposeOfVisit { get; set; }
        public int VisitID { get; }
        public string InstitutionName { get; set; }
        public string CoordinatorName { get; set; }
        public int CoordinatorNumber { get; set; }
    }
}
