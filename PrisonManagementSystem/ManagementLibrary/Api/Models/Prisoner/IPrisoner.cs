using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Prisoner
{
    public interface IPrisoner
    {
        int PrisonerID { get; }
        string FirstName { get; set; }
        string Lastname { get; set; }
        string Gender { get; set; }
        DateTime DOB { get; set; }
        string PrisonID { get; set; }
        byte[] FingerPrint { get; set; }
        DateTime DateOfConviction { get; set; } 
        int ConvictionID { get; set; }
        float TimeServed { get; set; }
        byte[] Photo { get; set; }
        string PrisonerType { get; set; }
        string RehabPrograms { get; set; }
    }
}
