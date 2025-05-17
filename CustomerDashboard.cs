using MySql.Data.MySqlClient;
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
    public partial class CustomerDashboard : Form
    {
        private int userId;
        public CustomerDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            cmbTime.Items.AddRange(new string[] { "12:00", "13:00", "14:00", "19:00", "20:00" });
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            DateTime date = dtpDate.Value.Date;
            string timeStr = cmbTime.SelectedItem.ToString();
            TimeSpan time = TimeSpan.Parse(timeStr);
            int guests = int.Parse(txtGuests.Text);

            Database db = new Database();
            var conn = db.GetConnection();
            conn.Open();

            string insert = "INSERT INTO Reservations (UserID, Guests, ReservationDate, ReservationTime, Status) VALUES (@u, @g, @d, @t, 'Pending')";
            MySqlCommand cmd = new MySqlCommand(insert, conn);
            cmd.Parameters.AddWithValue("@u", userId);
            cmd.Parameters.AddWithValue("@g", guests);
            cmd.Parameters.AddWithValue("@d", date);
            cmd.Parameters.AddWithValue("@t", time);

            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("Rezervasyon talebiniz alındı.");
            else
                MessageBox.Show("Hata oluştu.");

            conn.Close();
        }

        
    }
}
