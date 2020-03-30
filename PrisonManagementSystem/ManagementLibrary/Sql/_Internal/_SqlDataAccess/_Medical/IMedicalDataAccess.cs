﻿using ManagementLibrary.Api.Models.Medical;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ManagementLibrary.Sql._Internal._SqlDataAccess._Medical
{
    public interface IMedicalDataAccess
    {
        string DELETE_PROCEDURE_NAME { get; set; }
        string GET_PROCEDURE_NAME { get; set; }
        string GET_ALL_PROCEDURE_NAME { get; set; }
        string INSERT_PROCEDURE_NAME { get; set; }
        string UPDATE_PROCEDURE_NAME { get; set; }
        IList<IMedicial> GetMedical();
        IMedicial GetMedical(string _email, string _password);
        void InsertMedical(IMedicial _Medical);
        void UpdateMedical(int _id,IMedicial _Medical);
        void DeleteMedical(int _id);
    }
}
