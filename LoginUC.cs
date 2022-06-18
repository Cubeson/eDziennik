using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace edziennik
{
    public partial class LoginUC : UserControl
    {
        public LoginUC()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            int id = 0;
            string name = "";
            string surname = "";

            var conn = DB.GetInstance();
            conn.Open();
            try
            {
                using (var cmd = new MySqlCommand(
                "SELECT id, name, surname FROM teacher " +
                "WHERE login = @login AND password = @password LIMIT 1", conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Prepare();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = (int)reader[0];
                            name = (string)reader[1];
                            surname = (string)reader[2];

                        }
                    }
                }
            }
            catch(MySqlException ex)
            {
            }
            
            conn.Close();
            if(id == 0)
                labelInfo.Text = "Błąd w loginie lub haśle";
            else
            {

                Form1.FullPanel.Controls.Clear();
                Form1.FullPanel.Controls.Add(new MainUC(new CurrentUser(id,name,surname)));
            }
        }

        private void LoginUC_Load(object sender, EventArgs e)
        {

        }
    }
}
