using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselProgramlamaProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            Database db = new Database();
            MySqlConnection conn = db.GetConnection();
            conn.Open();

            string query = "SELECT * FROM Users WHERE Username=@u AND Password=@p";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", password);

            var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string role = reader["Role"].ToString();
                MessageBox.Show("Giriş başarılı: " + role);

                if (role == "admin")
                {
                    AdminPanel admin = new AdminPanel();
                    admin.Show();
                }
                else
                {
                    CustomerDashboard customer = new CustomerDashboard(Convert.ToInt32(reader["UserID"]));
                    customer.Show();
                }
                this.Hide();
            }
            else
            {
                lblStatus.Text = "Hatalı giriş.";
                lblStatus.Visible = true;
            }

            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
