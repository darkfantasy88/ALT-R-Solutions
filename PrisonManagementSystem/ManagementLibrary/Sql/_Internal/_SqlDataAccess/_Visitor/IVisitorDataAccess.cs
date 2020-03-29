using ManagementLibrary.Api.Models.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Sql._Internal._SqlDataAccess._Visitor
{
    public interface IVisitDataAccess
    {
        string DELETE_PROCEDURE_NAME { get; set; }
        string GET_BY_TYPE_PROCEDURE_NAME { get; set; }
        string GET_BY_PERSON_NAME_PROCEDURE_NAME { get; set; }
        string GET_BY_INSTITUTION_NAME_PROCEDURE_NAME { get; set; }
        string GET_ALL_PROCEDURE_NAME { get; set; }
        string INSERT_PROCEDURE_NAME { get; set; }
        string APPROVE_PROCEDURE_NAME { get; set; }
        string VERIFY_PROCEDURE_NAME { get; set; }

        IList<IVisitor> GetVisits();
       // IVisitor GetVisitor(string _email);
        IList<IVisitor> GetVisitByInstitution(string _institutionName);
        IList<IVisitor> GetVisitByName(string _firstName, string _lastName);
        IList<IVisitor> GetVisitByType(string _visitType);


        void ApproveVisit(int _id,string _status);
        void VerifyDetails(int id,string _validIdType, string _validIdNumber, DateTime _validIdExpiry);
        void InsertVisitor(FamilyFriendsVisit _familyFriendsVisit);
        void InsertVisitor(OtherVisit _otherVisit);
        void InsertVisitor(SchoolVisit _schoolVisit);

        //void UpdateVisitor(int _id, string _firstName, string _lastName, string _role, string _email, string _password);
        void DeleteVisitor(int _id);
    }
}
