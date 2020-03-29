using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManagementLibrary.Api.Models.Authentication_Authorization;
using ManagementLibrary.Sql._Internal._SqHelper;

namespace ManagementLibrary.Sql._Internal._SqlDataAccess._Authentication_Authorization
{
    public class AuthDataAccess : IAuthDataAccess
    {
        ISqlHelper _helper = new SqlHelper();
        string _delete_procedure_name = "DeleteAuthUser";
        string _get_procedure_name = "GetAuthUser";
        string _getall_procedure_name = "GetAllAuthUsers";
        string _insert_procedure_name = "InsertAuthUser";
        string _update_procedure_name = "UpdateAuthUser";
        public string DELETE_PROCEDURE_NAME
        {
            get { return _delete_procedure_name; }
            set { _delete_procedure_name = value; }
        }

        public string  GET_PROCEDURE_NAME
        {
            get { return _get_procedure_name; }
            set { _get_procedure_name = value; }
        }

        public string GET_ALL_PROCEDURE_NAME
        {
            get { return _getall_procedure_name; }
            set { _getall_procedure_name= value; }
        }

        public string INSERT_PROCEDURE_NAME
        {
            get { return _insert_procedure_name; }
            set { _insert_procedure_name = value; }
        }

        public string UPDATE_PROCEDURE_NAME
        {
            get { return _update_procedure_name; }
            set { _update_procedure_name = value; }
        }

        public void DeleteAuthUser(int _id)
        {
            var p = new
            {
                id = _id
            };
            _helper.SaveData<dynamic>(DELETE_PROCEDURE_NAME, p);
        }

        public IAuthUser GetAuthUser(string _email, string _password)
        {
            var p = new
            {
                email = _email,
                password = _password
            };
            return _helper.GetData<IAuthUser, dynamic>(GET_PROCEDURE_NAME, p);
        }

        public IList<IAuthUser> GetAuthUsers()
        {
            return _helper.GetData<IAuthUser>(GET_ALL_PROCEDURE_NAME);

        }

        public void InsertAuthUser(IAuthUser _authuser)
        {
            var p = new
            {
                firstname = _authuser.FirstName,
                lastname = _authuser.LastName,
                gender = _authuser.Gender,
                role = _authuser.Role,
                email = _authuser.EmailAddress,
                password = _authuser.Password
            };

            _helper.SaveData<dynamic>(INSERT_PROCEDURE_NAME, p);
        }

        public void UpdateAuthUser(int _id, IAuthUser _authuser)
        {
            var p = new
            {
                id=_id,
                firstname = _authuser.FirstName,
                lastname = _authuser.LastName,
                gender = _authuser.Gender,
                role = _authuser.Role,
                email = _authuser.EmailAddress,
                password = _authuser.Password
            };
            _helper.SaveData<dynamic>(UPDATE_PROCEDURE_NAME, p);
        }
    }
}
