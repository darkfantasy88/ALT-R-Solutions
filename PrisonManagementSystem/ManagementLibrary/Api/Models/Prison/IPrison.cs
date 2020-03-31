using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Prison
{
    public interface IPrison
    {
        string PrisonID { get; set; }
        string Name { get; set; }
        string Location { get; set; }
        string History { get; set; }
        byte[] Image { get; set; }
        int MaxCapacity { get; set; }
        int CurrentCapacity { get; set; }
        string PrisonType { get; set; }
        int WarderToPrisonerRatio { get; }
    }
}
