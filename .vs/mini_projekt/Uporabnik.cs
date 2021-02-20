using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace mini_projekt
{
    public class Podatki
    {
        public string A, B, C, D;
        public DateTime E;
        public Podatki()
        {

        }

        public Podatki(string a, string b, string c, string d, DateTime e)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
        }
    }
    public class Uporabnik
    {
        public Uporabnik()
        {

        }

        public List<Podatki> podatki_Uporabnika()
        {
            List<Podatki> list = new List<Podatki>();
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_podatke_uporabnika(" + Public.id + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(2))
                    {
                        list.Add(new Podatki(reader.GetString(0), reader.GetString(1), " ", " ", reader.GetDateTime(3)));
                    }
                    else
                        list.Add(new Podatki(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(4), reader.GetDateTime(3)));
                }
                con.Close();
            }
            return list;
        }

        public void spremeni_Geslo(string a)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT update_geslo_uporabnika(" + Public.id + ",'" + Ena.CreateMD5(a) + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
        }

        public void spremeni_Email(string a)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT update_email_uporabnika(" + Public.id + ",'" + a + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
        }

        public void spremeni_Podatke_Uporabnika(string a, string b, string c, string d)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT FROM update_podatke_uporabnika(" + Public.id + ",'" + a + "','" + b + "','" + c + "','" + d + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
        }
    }
}
