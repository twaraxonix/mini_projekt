using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace mini_projekt
{
    public static class Ena
    {
        public static bool Registracija(string a, string b, string c, string d){
            bool x = false;
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT add_uporabnik1('" + a + "','" + b + "','" + c + "','" + Ena.CreateMD5(d) + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Public.Change(reader.GetInt32(0));
                    x = true;
                    //comboBox1.Items.Add(ime);
                    //comboBox1.Items.Add(a);
                }
                con.Close();
            }
            return x;
        }

        public static bool Prijava(string a, string b)
        {
            bool x = false;
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT prijava1('" + a + "','" + CreateMD5(b) + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    Public.Change(reader.GetInt32(0));
                    if (Public.id != 0)
                    {
                        x = true;
                    }
                    //comboBox1.Items.Add(ime);
                    //comboBox1.Items.Add(a);
                }
                con.Close();
                return x;
            }
            
        }

        public static void PozabljenoGeslo(string a, string b)
        {
            using (NpgsqlConnection con = new NpgsqlConnection("Server=hattie.db.elephantsql.com; User Id=qrallryw;" + "Password=42JSx-SoQO5TfgzavjTAU5Bz2qJli0rN; Database=qrallryw;"))
            {
                con.Open();
                NpgsqlCommand com = new NpgsqlCommand("SELECT update_pozabljeno_geslo_uporabnika('" + a + "','" + CreateMD5(b) + "')", con);
                NpgsqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                }
                con.Close();
            }
        }
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }


}
