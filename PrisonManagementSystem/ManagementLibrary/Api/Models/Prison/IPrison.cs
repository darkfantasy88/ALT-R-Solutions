using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Prison
{
    public interface IPrison
    {
        int PrisonID { get; set; }
        string Name { get; set; }
        string Location { get; set; }
        int MaxCapacity { get; set; }
        int CurrentCapacity { get; set; }
        string Type { get; set; }
        int WarderCount { get; set; }

    }
}
