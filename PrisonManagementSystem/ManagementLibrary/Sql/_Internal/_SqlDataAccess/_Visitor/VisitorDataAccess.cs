using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementLibrary.Api.Models.Visitor;
using ManagementLibrary.Sql._Internal._SqHelper;

namespace ManagementLibrary.Sql._Internal._SqlDataAccess._Visitor
{
    public class VisitDataAccess : IVisitDataAccess
    {
        ISqlHelper _helper = new SqlHelper();

        public string DELETE_PROCEDURE_NAME { get => "DeleteVisit"; set =>DELETE_PROCEDURE_NAME=value; }
        public string GET_BY_TYPE_PROCEDURE_NAME { get => "GetUniqueVisit"; set => GET_BY_TYPE_PROCEDURE_NAME = value; }
        public string GET_BY_PERSON_NAME_PROCEDURE_NAME { get => "GetUniqueVisit"; set => GET_BY_PERSON_NAME_PROCEDURE_NAME=value; }
        public string GET_BY_INSTITUTION_NAME_PROCEDURE_NAME { get => "GetUniqueVisit"; set => GET_BY_INSTITUTION_NAME_PROCEDURE_NAME=value; }
        public string GET_ALL_PROCEDURE_NAME { get => "GetAllVisits"; set => GET_ALL_PROCEDURE_NAME = value; }
        public string INSERT_PROCEDURE_NAME { get => "InsertVisit"; set => INSERT_PROCEDURE_NAME=value; }
        public string APPROVE_PROCEDURE_NAME { get => "ApproveVisit"; set => APPROVE_PROCEDURE_NAME=value; }
        public string VERIFY_PROCEDURE_NAME { get => "VerifyVisit"; set => VERIFY_PROCEDURE_NAME=value; }

        public void ApproveVisit(int _id,string _status)
        {
            var p = new
            {
                id = _id,
                status=_status
            };
            _helper.SaveData<dynamic>(APPROVE_PROCEDURE_NAME, p);
        }

        public void DeleteVisitor(int _id)
        {
            var p = new
            {
                id = _id,
            };
            _helper.SaveData<dynamic>(DELETE_PROCEDURE_NAME, p);
        }

        public IList<OtherVisit> GetVisitByInstitution(string _institutionName)
        {
            var p = new
            {
                institution = _institutionName,
            };
            return _helper.GetDataGroup<OtherVisit,dynamic>(GET_BY_INSTITUTION_NAME_PROCEDURE_NAME, p);
        }
        public IList<SchoolVisit> GetVisitBySchool(string _schoolName)
        {
            var p = new
            {
                institution = _schoolName,
            };
            return _helper.GetDataGroup<SchoolVisit, dynamic>(GET_BY_INSTITUTION_NAME_PROCEDURE_NAME, p);
        }

        public IList<OtherVisit> GetVisitByName(string _firstName, string _lastName)
        {
            var p = new
            {
                firstname = _firstName,
                lastname=_lastName
            };
            return _helper.GetDataGroup<OtherVisit, dynamic>(GET_BY_PERSON_NAME_PROCEDURE_NAME, p);

        }
        public IList<FamilyFriendsVisit> GetVisitByNameFamily(string _firstName, string _lastName)
        {
            var p = new
            {
                firstname = _firstName,
                lastname = _lastName
            };
            return _helper.GetDataGroup<FamilyFriendsVisit, dynamic>(GET_BY_PERSON_NAME_PROCEDURE_NAME, p);

        }

        public IList<IVisitor> GetVisitByType(string _visitType)
        {
            var p = new
            {
                type=_visitType
            };
            return _helper.GetDataGroup<IVisitor, dynamic>(GET_BY_TYPE_PROCEDURE_NAME, p);

        }

        public IList<IVisitor> GetVisits()
        {

            return _helper.GetData<IVisitor>(GET_ALL_PROCEDURE_NAME);
        }

        public void InsertVisitor(FamilyFriendsVisit _familyFriendsVisit)
        {
            var p = new
            {
                trn = _familyFriendsVisit.TRN,
                mobile = _familyFriendsVisit.MobileNumber,
                work = _familyFriendsVisit.WorkNumber,
                firstname = _familyFriendsVisit.FirstName,
                lastname = _familyFriendsVisit.LastName,
                gender = _familyFriendsVisit.Gender,
                dob = _familyFriendsVisit.DOB,
                occupation = _familyFriendsVisit.Occupation,
                residential = _familyFriendsVisit.ResidentialAddress,
                postal = _familyFriendsVisit.PostalAddress,
                email = _familyFriendsVisit.EmailAddress,
                prisonname = _familyFriendsVisit.PrisonName,
                purpose = _familyFriendsVisit.PurposeOfVisit,
                image = _familyFriendsVisit.VisitorImage,
                prisonnerid = _familyFriendsVisit.PrisonerID,
                relationship = _familyFriendsVisit.Relationship
            };
            _helper.SaveData<dynamic>(INSERT_PROCEDURE_NAME, p);
        }

        public void InsertVisitor(OtherVisit _otherVisit)
        {
            var p = new
            {

                trn = _otherVisit.TRN,
                institution=_otherVisit.InstitutionName,
                mobile = _otherVisit.MobileNumber,
                work = _otherVisit.WorkNumber,
                firstname = _otherVisit.FirstName,
                lastname = _otherVisit.LastName,
                gender = _otherVisit.Gender,
                dob = _otherVisit.DOB,
                occupation = _otherVisit.Occupation,
                residential = _otherVisit.ResidentialAddress,
                postal = _otherVisit.PostalAddress,
                email = _otherVisit.EmailAddress,
                prisonname = _otherVisit.PrisonName,
                purpose = _otherVisit.PurposeOfVisit,
                image = _otherVisit.VisitorImage,
                prisonnerid = _otherVisit.PrisonerID,
                relationship = _otherVisit.Relationship
            };
            _helper.SaveData<dynamic>(INSERT_PROCEDURE_NAME, p);
        }

        public void InsertVisitor(SchoolVisit _schoolVisit)
        {
            var p = new
            {
                institution = _schoolVisit.InstitutionName,
                coordinator = _schoolVisit.CoordinatorName,
                coordinatornum = _schoolVisit.CoordinatorNumber,
                prisonname = _schoolVisit.PrisonName,
                purpose = _schoolVisit.PurposeOfVisit,
            };
            _helper.SaveData<dynamic>(INSERT_PROCEDURE_NAME, p);
        }

        public void VerifyDetails(int _id,string _validIdType, string _validIdNumber, DateTime _validIdExpiry)
        {
            var p = new
            {
                id = _id,
                type = _validIdType,
                number = _validIdNumber,
                expiry = _validIdExpiry
            };
            _helper.SaveData<dynamic>(VERIFY_PROCEDURE_NAME, p);
        }

        public IList<FamilyFriendsVisit> FamilyFriendsVisit(string _firstName, string _lastName)
        {

            var p = new
            {
                firstname = _firstName,
                lastname = _lastName
            };
            return _helper.GetDataGroup<FamilyFriendsVisit, dynamic>(GET_BY_PERSON_NAME_PROCEDURE_NAME, p);

        }

        public IList<OtherVisit> OtherVisit(string _firstName, string _lastName)
        {
            var p = new
            {
                firstname = _firstName,
                lastname = _lastName
            };
            return _helper.GetDataGroup<OtherVisit, dynamic>(GET_BY_PERSON_NAME_PROCEDURE_NAME, p);

        }
    }
}
