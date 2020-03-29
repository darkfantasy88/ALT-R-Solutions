using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Sql._Internal._SqHelper
{
    internal interface ISqlHelper
    {
        IList<T> GetData<T>(string _storedProcedureName);
        T GetData<T,U>(string _storedProcedureName, U _parameters);
        IList<T> GetDataGroup<T, U>(string _storedProcedureName, U _parameters);

        void SaveData<U>(string _stroredProcedureName, U _parameters);
    }
}
