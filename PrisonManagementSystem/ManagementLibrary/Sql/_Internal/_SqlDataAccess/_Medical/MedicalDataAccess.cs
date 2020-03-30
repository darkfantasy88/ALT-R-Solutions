using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementLibrary.Api.Models.Medical;

namespace ManagementLibrary.Sql._Internal._SqlDataAccess._Medical
{
    public class MedicalDataAccess : IMedicalDataAccess
    {
        public string DELETE_PROCEDURE_NAME { get => "DeleteMedical"; set => throw new NotImplementedException(); }
        public string GET_BY_PRISONER_PROCEDURE_NAME { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string GET_BY_DOCTOR_PROCEDURE_NAME { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GET_ALL_PROCEDURE_NAME { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string INSERT_PROCEDURE_NAME { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string UPDATE_PROCEDURE_NAME { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DeleteMedical(int _id)
        {
            throw new NotImplementedException();
        }

        public IList<IMedicial> GetMedical()
        {
            throw new NotImplementedException();
        }

        public IList<IMedicial> GetMedical(int _prisonerID)
        {
            throw new NotImplementedException();
        }

        public IList<IMedicial> GetMedical(string _doctorName)
        {
            throw new NotImplementedException();
        }

        public void InsertMedical(IMedicial _Medical)
        {
            throw new NotImplementedException();
        }

        public void UpdateMedical(int _id, IMedicial _Medical)
        {
            throw new NotImplementedException();
        }
    }
}
