using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Visitor
{
    public interface IVisitor
    {
        string VisitStatus { get; set; }
        string PrisonName { get; set; }
        string PurposeOfVisit { get; set; }
        int VisitID { get; }
    }
}
