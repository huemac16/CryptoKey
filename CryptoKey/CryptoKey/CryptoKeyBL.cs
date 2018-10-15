using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoKey
{
    public class CryptoKeyBL
    {

        private string conStrSQL = "Data Source=mssql.sailer.network;" +
                        "Initial Catalog=CryptoKey;" +
                        "User ID=rotmac16;" +
                        "Password=$ck_RotHue#";

        public ArrayList Accounts { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public void Login(string username, string password)
        {
            string col = "username";
            if (username.Contains("@")){
                col = "email";
            }
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "SELECT password " +
                                "FROM UserTable " +
                                "WHERE "+col+" = '"+username+"';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    
                    var reader = cmd.ExecuteReader();
                    if (reader.Read()){
                        if (reader["password"].Equals(password))
                        {
                            Console.WriteLine("Erfolgreich verbunden");
                        } else
                        {
                            throw new Exception("Passwort stimmt nicht mit dem Username/Email überein!");
                        }
                    } else
                    {
                        throw new Exception("Username/Email ist nicht vorhanden!");
                    }
                    reader.Close();
                    con.Close();
                }
            }
            catch (SqlException)
            {
                throw new Exception("Fehler beim Verbinden zur Datenbank!");
            }
        }

        public void Register(string username, string email, string password)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "INSERT INTO UserTable VALUES('"+username+ "','" + password + "','" + email + "',0,NULL,0,0);";
                Console.WriteLine("" + comStr);
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Fehler beim Verbinden zur Datenbank!" + ex.StackTrace);
                
            }
        }

    } 
}
