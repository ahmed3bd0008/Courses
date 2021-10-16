
using System.Data;
using System.Data.SqlClient;

namespace Repository.Context
{
    public class DapperContext
    {
             private readonly string _ConnectioString;

             public DapperContext(string connectionString)
            {
                        _ConnectioString=connectionString;
            }
            public IDbConnection CreateConnection() => new SqlConnection(_ConnectioString);
    }
}