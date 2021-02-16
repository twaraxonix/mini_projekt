using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace mini_projekt
{
    public static class Arhiv
    {
        public static string [] IzpisArhiva(string dtOd, string dtDo){
            string[] row = new string[] { };
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                int a = 1;
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_arhiv_dolocen_datum('" + dtOd + "','" + dtDo + "'," + Public.id + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    DateTime x1 = reader.GetDateTime(0);
                    row = new string[] { Convert.ToString(a), x1.ToString("dd-MM-yyyy"), Convert.ToString(reader.GetDouble(1)) };
                    a++;
                }
                con.Close();
            }
            return row;
        }
    }
}
