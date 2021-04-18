using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLink.Lib
{
    public class DatabaseLogger : ILogger
    {
        private IDbConnection connection = new SqlConnection(AppConnection.ConnectionString);
        public void Log(OperationModel operation)
        {
            LogToDatabase(operation);
        }

        private void LogToDatabase(OperationModel operation)
        {
            string sql = "INSERT INTO MedialinkLog (operation, a, b, result) Values (@operationName, @a, @b, @result);";
            
            var affectedRows = connection.Execute(sql, new { OperationName = operation.OperationName, A = operation.A, B = operation.B, Result = operation.Result });

            Console.WriteLine("Method: LogToDatabase: {0}", affectedRows);
        }
    }
}
