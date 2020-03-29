using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Api.Models.Authentication_Authorization
{
    //Represent data model for authenticated user
    public interface IAuthUser
    {
        int AuthID { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Role { get; set; }
        string EmailAddress { get; set; }
        string Gender { get; set; }
        string Password { get; set; }

    }
}
