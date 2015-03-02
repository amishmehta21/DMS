using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DMSDAL
{
    public class CommonDAL
    {


        public SqlConnection Connection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=nazim;Initial Catalog=DMS;Integrated Security=True");
            return con;
        }

    }
}
