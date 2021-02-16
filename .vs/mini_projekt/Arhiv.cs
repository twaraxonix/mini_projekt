using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace mini_projekt
{
    public class ItemA
    {
        public string A;
        public string B;
        public string C;
        public DateTime D;

        public ItemA()
        {
             
        }
        public ItemA(string a, string b, string c)
        {
            A = a;
            B = b;
            C = c;
        }
        public ItemA(string a, string b, string c, DateTime d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

    }
    public class Arhiv
    {
        public Arhiv()
        {
                
        }
        public ItemA A = new ItemA();
        public List<ItemA> IzpisArhivaDatum(string dtOd, string dtDo){
            //string[] row = new string[] { };
            List<ItemA> x = new List<ItemA>();
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                int a = 1;
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_arhiv_dolocen_datum('" + dtOd + "','" + dtDo + "'," + Public.id + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    DateTime x1 = reader.GetDateTime(0);
                    x.Add(new ItemA (Convert.ToString(a), x1.ToString("dd-MM-yyyy"), Convert.ToString(reader.GetDouble(1))));
                    a++;
                }
                con.Close();
            }
            return x;
        }

        public List<ItemA> IzpisArhiva()
        {
            List<ItemA> x = new List<ItemA>();
            int a = 1;
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_arhiv(" + Public.id + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    DateTime x1 = reader.GetDateTime(0);
                    x.Add(new ItemA(Convert.ToString(a), x1.ToString("dd-MM-yyyy"), Convert.ToString(reader.GetDouble(1))));
                    a++;
                }
                con.Close();
            }
            return x;
        }

        public ItemA Podrobno(string a, string b)
        {
            ItemA item = new ItemA();
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_podrobno_arhiv(" + Public.id + ",'" + a + "'," + b + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    item = new ItemA(Convert.ToString(reader.GetDouble(1)), reader.GetString(2), reader.GetString(3), reader.GetDateTime(0));
                }
                con.Close();
            }
            return item;
        }
    }



}
