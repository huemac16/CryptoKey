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
        private ArrayList filtered = new ArrayList();

        public ArrayList Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public ArrayList Filtered
        {
            get { return filtered; }
            set { filtered = value; }
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Color Color { get; set; }
        public bool Theme { get; set; }
        public bool German { get; set; }
        public string cryptokey { get; set; }


        public void changeUserColor(Color col)
        {
            Color = col;
            string colStr = col.R + "," + col.G + "," + col.B + ",";
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "UPDATE UserTable SET color = '" + colStr + "';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException)
            {
                if (German) throw new Exception("Fehler beim Verbinden zur Datenbank!\n Versuchen Sie es in einer halben Stunde erneut, wenn Sie sich bis dahin noch immer nicht anmelden können, schreiben Sie ein Email an: cryptokey.pwmanager@gmail.com");
                throw new Exception("An error accured while trying to connect to the database!\n Try to connect again in 30 minutes, if it won't work then contact us at: cryptokey.pwmanager@gmail.com");
            }
        }

        public void changeUserTheme(bool darktheme)
        {
            Theme = darktheme;
            char theme = '0';
            if (darktheme) theme = '1';
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "UPDATE UserTable SET theme = '" + theme + "';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException)
            {
                if (German) throw new Exception("Fehler beim Verbinden zur Datenbank!\n Versuchen Sie es in einer halben Stunde erneut, wenn Sie sich bis dahin noch immer nicht anmelden können, schreiben Sie ein Email an: cryptokey.pwmanager@gmail.com");
                throw new Exception("An error accured while trying to connect to the database!\n Try to connect again in 30 minutes, if it won't work then contact us at: cryptokey.pwmanager@gmail.com");
            }
        }

        public void changeUserLanguage(bool german)
        {
            German = german;
            char lan = '0';
            if (german) lan = '1';
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "UPDATE UserTable SET german = '" + german + "';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException)
            {
                if (German) throw new Exception("Fehler beim Verbinden zur Datenbank!\n Versuchen Sie es in einer halben Stunde erneut, wenn Sie sich bis dahin noch immer nicht anmelden können, schreiben Sie ein Email an: cryptokey.pwmanager@gmail.com");
                throw new Exception("An error accured while trying to connect to the database!\n Try to connect again in 30 minutes, if it won't work then contact us at: cryptokey.pwmanager@gmail.com");
            }
        }

        public void add(Account acc, ListBox list)
        {
            acc.id = getNewID();
            accounts.Add(acc);
            filtered.Add(acc);
            update(list);
            try
            {

                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = comStr = "INSERT INTO AccountTable (username,title,email,onlineuser,password,url,marked,deleted) VALUES ('" + Username + "','" + acc.Title + "','" + acc.Email + "','" + acc.Onlineuser + "','" + EncryptionHelper.Encrypt(acc.Password,cryptokey) + "','" + acc.Url + "','0','0')";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (SqlException)
            {
                if(German) throw new Exception("Fehler beim Verbinden zur Datenbank!\n Versuchen Sie es in einer halben Stunde erneut, wenn Sie sich bis dahin noch immer nicht anmelden können, schreiben Sie ein Email an: cryptokey.pwmanager@gmail.com");
                throw new Exception("An error accured while trying to connect to the database!\n Try to connect again in 30 minutes, if it won't work then contact us at: cryptokey.pwmanager@gmail.com");
            }
        }

        public void change(int idx, Account acc, ListBox list)
        {
            accounts.RemoveAt(idx);
            accounts.Insert(idx, acc);
            filtered.RemoveAt(idx);
            filtered.Insert(idx, acc);
            update(list);
            try
            {
                char m = '0';
                if (acc.marked) m = '1';
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "UPDATE AccountTable SET title = '" + acc.Title + "', email = '" + acc.Email + "', onlineuser = '" + acc.Onlineuser + "', password = '" + EncryptionHelper.Encrypt(acc.Password,cryptokey) + "', url = '" + acc.Url + "', marked = '" + m + "' WHERE id = '" + acc.id + "';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch (SqlException)
            {
                if (German) throw new Exception("Fehler beim Verbinden zur Datenbank!\n Versuchen Sie es in einer halben Stunde erneut, wenn Sie sich bis dahin noch immer nicht anmelden können, schreiben Sie ein Email an: cryptokey.pwmanager@gmail.com");
                throw new Exception("An error accured while trying to connect to the database!\n Try to connect again in 30 minutes, if it won't work then contact us at: cryptokey.pwmanager@gmail.com");
            }
        }

        public void delete(Account acc, ListBox list)
        {
            int id = acc.id;
            accounts.Remove(acc);
            filtered.Remove(acc);
            update(list);
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "UPDATE AccountTable SET deleted = '1'"
                              + "WHERE id = '" + id + "';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException)
            {
                if (German) throw new Exception("Fehler beim Verbinden zur Datenbank!\n Versuchen Sie es in einer halben Stunde erneut, wenn Sie sich bis dahin noch immer nicht anmelden können, schreiben Sie ein Email an: cryptokey.pwmanager@gmail.com");
                throw new Exception("An error accured while trying to connect to the database!\n Try to connect again in 30 minutes, if it won't work then contact us at: cryptokey.pwmanager@gmail.com");
            }
        }

        private int getNewID()
        {
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "SELECT MAX(id) max "
                              + "FROM AccountTable;";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    int max = 0;
                    if (reader.Read()) max = Convert.ToInt32(reader["max"].ToString());
                    con.Close();
                    return max + 1;
                }

            }
            catch (SqlException)
            {
                if (German) throw new Exception("Fehler beim Verbinden zur Datenbank!\n Versuchen Sie es in einer halben Stunde erneut, wenn Sie sich bis dahin noch immer nicht anmelden können, schreiben Sie ein Email an: cryptokey.pwmanager@gmail.com");
                throw new Exception("An error accured while trying to connect to the database!\n Try to connect again in 30 minutes, if it won't work then contact us at: cryptokey.pwmanager@gmail.com");
            }
        }

        public void update(ListBox list)
        {
            int sel = list.SelectedIndex;
            list.BeginUpdate();
            list.Items.Clear();
            for (int i = 0; i<filtered.Count; i++)
            {
                list.Items.Add(filtered[i].ToString());              
            }
            list.EndUpdate();
        }

        public void Logout()
        {
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = comStr = "UPDATE UserTable SET online = '0' WHERE username = '" + Username + "';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                con.Close();
                accounts.Clear();
            }
            catch (SqlException)
            {
                if (German) throw new Exception("Fehler beim Verbinden zur Datenbank!\n Versuchen Sie es in einer halben Stunde erneut, wenn Sie sich bis dahin noch immer nicht anmelden können, schreiben Sie ein Email an: cryptokey.pwmanager@gmail.com");
                throw new Exception("An error accured while trying to connect to the database!\n Try to connect again in 30 minutes, if it won't work then contact us at: cryptokey.pwmanager@gmail.com");

            }
        }

        public void Login(string username, string password)
        {
            string col = "username";
            if (username.Contains("@"))
            {
                col = "email";
            }
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                string comStr = "SELECT * " +
                                "FROM UserTable " +
                                "WHERE " + col + " = '" + username + "';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();

                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        cryptokey = reader["cryptokey"].ToString();
                        if (EncryptionHelper.Decrypt(reader["password"].ToString(),cryptokey).Equals(password))
                        {
                            if (reader["online"].ToString().Equals("1")) throw new Exception("Sie sind bereits an einem anderen Gerät angemeldet!");
                            Username = reader["username"].ToString();
                            Password = reader["password"].ToString();
                            Email = reader["email"].ToString();
                            if (reader["color"].ToString().Equals(""))
                            {
                                Color = Color.FromArgb(0, 51, 204);
                            }
                            else
                            {
                                Color = CreateColFromStr(reader["color"].ToString());
                            }
                            Theme = reader["theme"].ToString().Equals("0");
                            German = reader["german"].ToString().Equals("1");
                            reader.Close();
                            comStr = "UPDATE UserTable SET online = '1' WHERE username = '" + Username + "';";
                            using (SqlCommand cmd2 = new SqlCommand(comStr, con))
                            {
                                cmd2.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            if(German) throw new Exception("Passwort stimmt nicht mit dem Username/Email überein!");
                            throw new Exception("Password doesn't match Username/Email");
                        }
                    }
                    else
                    {
                        if(German)throw new Exception("Username / Email konnte nicht erkannt werden!");
                        throw new Exception("Username/Email not found!");
                    }
                    con.Close();
                }
            }
            catch (SqlException)
            {
                if (German) throw new Exception("Fehler beim Verbinden zur Datenbank!\n Versuchen Sie es in einer halben Stunde erneut, wenn Sie sich bis dahin noch immer nicht anmelden können, schreiben Sie ein Email an: cryptokey.pwmanager@gmail.com");
                throw new Exception("An error accured while trying to connect to the database!\n Try to connect again in 30 minutes, if it won't work then contact us at: cryptokey.pwmanager@gmail.com");
            }
        }

        public void InitAccounts(ListBox list, string sorting)
        {
            try
            {
                Accounts.Clear();
                Filtered.Clear();
                SqlConnection con = new SqlConnection(conStrSQL);
                if (!sorting.Equals("")) sorting = String.Format(" ORDER BY {0}", sorting);
                string comStr = "SELECT * " +
                                "FROM AccountTable " +
                                "WHERE username = '" + Username + "' AND deleted = '0'" + sorting + ";";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        Account acc = new Account
                        {
                            id = Convert.ToInt32(reader["id"]),
                            Email = reader["email"].ToString(),
                            Onlineuser = reader["onlineuser"].ToString(),
                            Password = EncryptionHelper.Encrypt(reader["password"].ToString(),cryptokey),
                            Title = reader["title"].ToString(),
                            Url = reader["url"].ToString(),
                            marked = reader["marked"].ToString().Equals("1")
                        };

                        Accounts.Add(acc);
                        Filtered.Add(acc);
                    }
                }
                con.Close();
                update(list);
            }
            catch (SqlException)
            {
                if (German) throw new Exception("Fehler beim Verbinden zur Datenbank!\n Versuchen Sie es in einer halben Stunde erneut, wenn Sie sich bis dahin noch immer nicht anmelden können, schreiben Sie ein Email an: cryptokey.pwmanager@gmail.com");
                throw new Exception("An error accured while trying to connect to the database!\n Try to connect again in 30 minutes, if it won't work then contact us at: cryptokey.pwmanager@gmail.com");

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
                                "WHERE username = '" + username + "' OR email = '" + email + "';";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        if (email.Equals(reader["email"]))
                        {
                            if(German) throw new Exception("Email ist bereits vergeben, wollen Sie stattdessen ihr Passwort zurücksetzen?");
                            throw new Exception("Email is already used, do you want to reset your password instead?");
                        }
                        else
                        {
                            if(German) throw new Exception("Dieser Username ist leider schon vergeben!");
                            throw new Exception("This username is already used!");
                        }
                    }
                    con.Close();

                }
                cryptokey = EncryptionHelper.generateCryptoKey();
                char lan = '0';
                if (German) lan = '1';
                comStr = "INSERT INTO UserTable VALUES('" + username + "','" + EncryptionHelper.Encrypt(password,cryptokey) + "','" + email + "',0,NULL,0,"+lan+",'"+cryptokey+"')";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
            catch (SqlException)
            {
                if (German) throw new Exception("Fehler beim Verbinden zur Datenbank!\n Versuchen Sie es in einer halben Stunde erneut, wenn Sie sich bis dahin noch immer nicht anmelden können, schreiben Sie ein Email an: cryptokey.pwmanager@gmail.com");
                throw new Exception("An error accured while trying to connect to the database!\n Try to connect again in 30 minutes, if it won't work then contact us at: cryptokey.pwmanager@gmail.com");

            }
        }

        public void filter(string txt)
        {
            filtered.Clear();
            foreach (Account acc in accounts)
            {
                if (acc.Title.ToLower().Contains(txt.ToLower()))
                {
                    filtered.Add(acc);
                }
            }
        }
    }

}
