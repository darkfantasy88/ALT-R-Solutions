using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Officers
{
    public interface IStaff
    {

        string StaffID { get; set; }
        string FirstName { get; set; }
        char MiddleInitial { get; set; }
        string LastName { get; set; }
        DateTime DOB { get; set; }
        string StaffType { get; set; }
        string StaffRole { get; set; }
        string PrisonID { get; set; }
        int ProbationOfficeID { get; set; }
        bool Active { get;}
    }
}
