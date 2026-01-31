using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğitimKampi501.ConnectionString
{
    public static class DatabaseConnectionString
    {
        public static SqlConnection GetConnectionString()
        {
            return new SqlConnection ("Data Source=MERTH;Initial Catalog=EgitimKampi501Db;Integrated Security=True");
        }
    }
}
