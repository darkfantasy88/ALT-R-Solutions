using ManagementLibrary.Api.Models.Authentication_Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Sql._Internal._SqlDataAccess._Authentication_Authorization
{
    public interface IAuthDataAccess
    {
        string DELETE_PROCEDURE_NAME { get; set; }
        string GET_PROCEDURE_NAME { get; set; }
        string GET_ALL_PROCEDURE_NAME { get; set; }
        string INSERT_PROCEDURE_NAME { get; set; }
        string UPDATE_PROCEDURE_NAME { get; set; }
        IList<IAuthUser> GetAuthUsers();
        IAuthUser GetAuthUser(string _email, string _password);
        void InsertAuthUser(IAuthUser _authUser);
        void UpdateAuthUser(int _id,IAuthUser _authUser);
        void DeleteAuthUser(int _id);

    }
}
