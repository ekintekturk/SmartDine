using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GörselProgramlamaProje
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void LoadReservations()
        {
            Database db = new Database();
            var conn = db.GetConnection();
            conn.Open();

           
            string query = @"SELECT r.ReservationID, u.Username, r.Guests, 
                                    r.ReservationDate, r.ReservationTime, r.Status 
                             FROM Reservations r 
                             JOIN Users u ON r.UserID = u.UserID";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            conn.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int resId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ReservationID"].Value);
                UpdateStatus(resId, "Confirmed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int resId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ReservationID"].Value);
                UpdateStatus(resId, "Cancelled");
            }
        }

        private void UpdateStatus(int reservationId, string status)
        {
            Database db = new Database();
            var conn = db.GetConnection();
            conn.Open();

            string query = "UPDATE Reservations SET Status=@s WHERE ReservationID=@r";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@s", status);
            cmd.Parameters.AddWithValue("@r", reservationId);
            cmd.ExecuteNonQuery();

            conn.Close();
            LoadReservations(); // Listeyi güncelle
        }
    }
}
