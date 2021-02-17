using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace mini_projekt
{

    public class denar
    {
        public string a, b, c, d;
        public denar()
        {

        }
        public denar(string A, string B, string C, string D)
        {
            a = A;
            b = B;
            c = C;
            d = D;
        }
    }
    public class Main
    {
        public Main()
        {
                
        }
        public List<denar> update(string A, string B)
        {
            string b;
            DateTime x;
            int a = 1;
            List<denar> list = new List<denar>();
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_vse_porabe_denarja(" + Public.id + ",'" + A + "','" + B + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.IsDBNull(1))
                    {
                        b = "NULL";
                    }
                    else
                    {
                        b = reader.GetString(1);
                    }
                    x = reader.GetDateTime(0);
                    list.Add(new denar(Convert.ToString(a), x.ToString("yyyy-MM-dd"), b, Convert.ToString(reader.GetDouble(2))));
                    a++;
                }
                con.Close();
            }
            return list;
        }

        public string sum(string a, string b)
        {
            string SUM ="";
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT * FROM return_sum(" + Public.id + ",'" + a + "','" + b + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                     SUM = Convert.ToString(reader.GetDouble(0));
                }
            }
            return SUM;
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

        public void deleteDenar()
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT delete_poraba_denarja(" + Public.idP + ")", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
            Public.Change2("", "", 0);
        }
    }
}
