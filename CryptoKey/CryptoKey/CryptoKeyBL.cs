using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoKey
{
    public class CryptoKeyBL
    {

        private string conStrSQL = "Data Source=mssql.sailer.network;" +
                        "Initial Catalog=CryptoKey;" +
                        "User ID=rotmac16;" +
                        "Password=$ck_RotHue#";

        private ArrayList accounts = new ArrayList();

        public ArrayList Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Color Color { get; set; }
        public bool Theme { get; set; }
        public bool German { get; set; }


        public void Login(string username, string password)
        {
            string col = "username";
            if (username.Contains("@")){
                col = "email";
            }
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "SELECT * " +
                                "FROM UserTable " +
                                "WHERE "+col+" = '"+username+"';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    
                    var reader = cmd.ExecuteReader();
                    if (reader.Read()){
                        if (reader["password"].Equals(password))
                        {
                            Username = reader["username"].ToString();
                            Password = reader["password"].ToString();
                            Email = reader["email"].ToString();
                            if (reader["color"].ToString().Equals(""))
                            {
                                Color = Color.FromArgb(0,51,204);
                            } else
                            {
                                Color = CreateColFromStr(reader["color"].ToString());
                            }
                            Theme = reader["theme"].ToString().Equals("0");
                            German = reader["german"].ToString().Equals("1");
                            InitAccounts();
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

        private void InitAccounts()
        {
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "SELECT * " +
                                "FROM AccountTable " +
                                "WHERE username = '" + Username + "';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        Account acc = new Account { Email = reader["email"].ToString(),
                            Onlineuser = reader["onlineuser"].ToString(),
                            Password = reader["password"].ToString(),
                            Priority = reader["priority"].ToString()[0],
                            Title = reader["title"].ToString(),
                            Url = reader["url"].ToString(),
                            marked = reader["marked"].ToString().Equals("1") };

                        Accounts.Add(acc);
                    }
                }
                    con.Close();
     
            }
            catch (SqlException ex)
            {
                throw new Exception("Fehler beim Verbinden zur Datenbank!" + ex.StackTrace);

            }
        }

        private Color CreateColFromStr(string col)
        {
            string[] rgbStr = col.Split(',');
            int r = Convert.ToInt32(rgbStr[0]);
            int g = Convert.ToInt32(rgbStr[1]);
            int b = Convert.ToInt32(rgbStr[2]);
            return Color.FromArgb(r, g, b);
        }

        public void Register(string username, string email, string password)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "SELECT username, email " +
                                "FROM UserTable " +
                                "WHERE username = '"+ username+ "' OR email = '" + email + "';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (email.Equals(reader["email"])) throw new Exception("Email ist bereits vergeben, wollen Sie stattdessen ihr Passwort zurücksetzen?");
                        else throw new Exception("Dieser Username ist leider schon vergeben!");
                    }
                    con.Close();

                }
                comStr = "INSERT INTO UserTable VALUES('"+username+ "','" + password + "','" + email + "',0,NULL,0,1);";
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
