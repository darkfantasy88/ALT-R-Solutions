using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Other_Non_Essential
{
    public interface IProbationer
    {
        int ProbationID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DOB { get; set; }
        string StaffID { get; set; }
        string ProbationStartDate { get; set; }
        string ProbationEndDate { get; set; }
        Boolean Suspended { get; set; }
        DateTime SupensionDate { get; set; }
        Boolean Revoked { get; set; }
        DateTime RevokedDate { get; set; }
        Boolean Violation { get; set; }
        string ViolationDetails { get; set; }
        string Notes { get; set; }
    }
}
