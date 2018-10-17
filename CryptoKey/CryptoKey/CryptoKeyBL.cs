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

        public void add(Account acc, ListBox list)
        {
            acc.id = getNewID();
            accounts.Add(acc);
            update(list);
            try
            {

                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = comStr = "INSERT INTO AccountTable (username,title,email,onlineuser,password,url,priority,marked) VALUES ('"+ Username + "','" + acc.Title + "','" + acc.Email + "','" + acc.Onlineuser + "','" + acc.Password + "','" + acc.Url + "','" + acc.Priority + "','0')";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Fehler beim Verbinden zur Datenbank!" + ex.Message + ex.Source);
            }
        }

        private int getNewID()
        {
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "SELECT MAX(id) "
                               + "FROM AccountTable;";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    reader.Read();
                    int max = Convert.ToInt32(reader["MAX[id]"]);
                    con.Close();
                    return max + 1;
                }

            }
            catch (SqlException ex)
            {
                throw new Exception("Fehler beim Verbinden zur Datenbank!" + ex.Message + ex.Source);
            }
        }

        public void update(ListBox list)
        {
            int sel = list.SelectedIndex;
            list.BeginUpdate();
            list.Items.Clear();
            foreach (Account acc in accounts)
            {
                list.Items.Add(acc.ToString());
            }
            list.EndUpdate();
        }

        public void Logout()
        {
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = comStr = "UPDATE UserTable SET online = '0';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                accounts.Clear();
            }
            catch (SqlException ex)
            {
                throw new Exception("Fehler beim Verbinden zur Datenbank!" + ex.Message + ex.Source);

            }
        }

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
                        if (EncryptionHelper.Decrypt(reader["password"].ToString()).Equals(password))
                        {
                            if(reader["online"].ToString().Equals("1")) throw new Exception("Sie sind bereits an einem anderen Gerät angemeldet!");
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
                            reader.Close();
                            comStr = "UPDATE UserTable SET online = '1';";
                            using(SqlCommand cmd2 = new SqlCommand(comStr, con))
                            {
                                cmd2.ExecuteNonQuery();
                            }
                        } else
                        {
                            throw new Exception("Passwort stimmt nicht mit dem Username/Email überein!");
                        }
                    } else
                    {
                        throw new Exception("Username/Email ist nicht vorhanden!");
                    }
                    con.Close();
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Fehler beim Verbinden zur Datenbank!" + ex.Message + ex.Source);
            }
        }

        public void InitAccounts(ListBox list)
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

                        Account acc = new Account {
                            id = Convert.ToInt32(reader["id"]),
                            Email = reader["email"].ToString(),
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
                update(list);
            }
            catch (SqlException ex)
            {
                throw new Exception("Fehler beim Verbinden zur Datenbank!" + ex.Message + ex.Source);

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
                throw new Exception("Fehler beim Verbinden zur Datenbank!" + ex.Message + ex.Source);
                
            }
        }

    } 
}
