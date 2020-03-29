using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementLibrary.Sql._Internal._SqHelper
{
    internal class SqlHelper : ISqlHelper
    {
        public IList<T> GetData<T>(string _storedProcedureName)
        {
            using (IDbConnection database=new SqlConnection(_GlobalVariables.ConnectionString) )
            {
                return database.Query<T>(_storedProcedureName, commandType:CommandType.StoredProcedure).ToList();
            }
        }

        public T GetData<T, U>(string _storedProcedureName, U _parameters)
        {
            using (IDbConnection database = new SqlConnection(_GlobalVariables.ConnectionString))
            {
               return database.Query<T>(_storedProcedureName, _parameters,commandType:CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IList<T> GetDataGroup<T, U>(string _storedProcedureName, U _parameters)
        {
            using (IDbConnection database = new SqlConnection(_GlobalVariables.ConnectionString))
            {
                return database.Query<T>(_storedProcedureName, _parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public void SaveData<U>(string _stroredProcedureName, U _parameters)
        {
            using (IDbConnection database = new SqlConnection(_GlobalVariables.ConnectionString))
            {
                database.Execute(_stroredProcedureName, _parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
