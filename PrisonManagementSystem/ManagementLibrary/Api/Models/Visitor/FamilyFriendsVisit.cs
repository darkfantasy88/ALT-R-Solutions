using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Visitor
{
    public class FamilyFriendsVisit : IVisitor
    {
        public string VisitStatus { get; set; }
        public string PrisonName { get; set; }
        public string PurposeOfVisit { get; set; }
        public int VisitID { get; }
        public int TRN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNumber { get; set; }
        public string WorkNumber { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public DateTime DOB { get; set; }
        public string ResidentialAddress { get; set; }
        public string PostalAddress { get; set; }
        public string EmailAddress { get; set; }
        public string PrisonerID { get; set; }
        public string Relationship { get; set; }
        public DateTime ApprovedDateOfVisit { get; set; }
        public byte[] VisitorImage { get; set; }
        public string ValidIDType { get; set; }
        public string ValidIDDateOfExpiry { get; set; }
        public string ValidIDNumber { get; set; }
    }
}
