using CpuSeller.DataAccessLayer.Abstract;
using CpuSeller.Entities.Concrete;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CpuSeller.DataAccessLayer.Concrete.ADONET
{
    public class DBMS
    {
        
            private static string connectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = CpuDB; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            public static string Connection
            {
                get { return connectionString; }
            }
            public static bool ExecuteNonQuery(SqlCommand cmd)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        conn.Close();
                        conn.Dispose();
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        
    }

}
