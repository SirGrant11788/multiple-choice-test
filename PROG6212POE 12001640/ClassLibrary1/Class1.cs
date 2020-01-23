using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public String login()
        {
            SqlConnection sq = new SqlConnection("Data Source=VCSDSTDCR5PC-45;Initial Catalog=PROGPOE;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            sq.Open();
            SqlDataAdapter sel = new SqlDataAdapter("SELECT * FROM LOGIN WHERE USERN = '" + tbxUser.Text + "' AND PASS = '" + pbPassword.Password + "'", sq);
            DataTable dt = new DataTable();
            sel.Fill(dt);
            return "S";
        }
    }
}
