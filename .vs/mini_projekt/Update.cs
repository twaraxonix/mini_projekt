using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace mini_projekt
{
    public class Update
    {
        public Update()
        {
                
        }

        public void update(double a, string b)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT update_porabe_denarja(" + Public.idP + "," + a + ",'" + b + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
        }
        public void update1(double a, string b, string c, string d)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT update_porabe_denarja(" + Public.idP + "," + a + ",'" + b + "','"+ c +"','"+ d +"')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
        }

        public void ID()
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT return_id_porabe_denarja(" + Public.id + "," + Public.znesek + ",'" + Public.datum + "','" + Public.lokacija + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Public.idP = reader.GetInt32(0);
                }
                con.Close();
            }
        }
        public void ID2()
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT return_id_porabe_denarja2(" + Public.id + "," + Public.znesek + ",'" + Public.datum + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Public.idP = reader.GetInt32(0);
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
                    list.Add(reader.GetString(0));
                }
                con.Close();
            }
            return list;
        }

        public List<string> kraji()
        {
            List<string> list = new List<string>();
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vsi_kraji()", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
                con.Close();
            }
            return list;
        }

        public List<string> posta(string a)
        {
            List<string> list = new List<string>();
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_posto_krajev('" + a + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
                con.Close();
            }
            return list;
        }

        public void dodaj_Lokacijo(string a, string b, string c, string d)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT add_lokacija('" + a + "','" + b + "','" + c + "','" + d + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
        }
    }
}
