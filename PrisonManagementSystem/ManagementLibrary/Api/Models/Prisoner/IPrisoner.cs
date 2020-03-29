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
        string PrisonAssigned { get; set; }
        byte[] FingerPrint { get; set; }
        DateTime DateOfConviction { get; set; } 
        int TimeServed { get; set; }
        byte[] Photo { get; set; }
    }
}
