using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Conviction
{
    public interface IConviction
    {
        int ConvictionID { get; set; }
        string ConvictionType { get; set; }
        int ConvictionProbationPeriod { get; set; }
        string ConvictionName { get; set; }
        int ConvictionPeriod { get; set; }
    }
}
