using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Visitor
{
    public class OtherVisit:FamilyFriendsVisit,IVisitor
    {
        public string InstitutionName { get; set; }

    }
}
