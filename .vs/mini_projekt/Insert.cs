using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace mini_projekt
{
    public class Insert
    {
        public Insert()
        {
                
        }
        public void Dodaj(string a, double b, string c)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT FROM add_poraba_denarja(" + Public.id + ",'" + a + "','" + b + "','" + c + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
        }

        public List<string> lokacije(string a)
        {
            List<string> list = new List<string>();
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vse_lokacije('" + a + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string ime = reader.GetString(0);
                    list.Add(ime);
                    //string ime_l = reader.GetString(1);
                    //string skupaj = ime +", "+ ime_l;
                    
                }
                con.Close();
            }
            return list;
        }
    }
}
