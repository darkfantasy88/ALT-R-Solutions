using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Medical
{
    public interface IMedicial
    {
        int MedicalID { get; }
        string PrisonerID { get; }
        string PhysicalDefect { get; set; }
        string MentalHealthStatus { get; set; }
        string MentalHealthDetails { get; set; }
        string Height { get; set; }
        string Weight { get; set; }
        string Allergies { get; set; }
        string DrugTestStatus { get; set; }
        string DrugTestDetails { get; set; }
        string BloodType { get; set; }
        string BloodTestDetails { get; set; }
        DateTime LastVist { get; set; }
        string PurposeOfVisit { get; set; }
    }
}
