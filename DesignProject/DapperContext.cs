using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject
{
    public class DapperContext
    {
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection("Data Source=L70525;Database=Context;Integrated Security=True;Encrypt=False");
            }
        }


        public void GetValues()
        {
            Console.WriteLine(Connection.Query("select * from context")
);
        }
    }
}
