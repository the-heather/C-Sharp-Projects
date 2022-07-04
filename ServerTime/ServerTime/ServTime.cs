using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Data.SqlClient;
using System.Data;


namespace ServerTime
{
    public class ServTime
    {
        private readonly string connectionString = @"Data Source = DESKTOP - HN3S8JL; Initial Catalog = ServTime; Integrated Security = True";
         using (SqlConnection connection = new SqlConnection(connectionString))
        SqlServer.GETDATE();




    }
}
