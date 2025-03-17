using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class Applicant_dashboard : Form
    {
        private int userId;
        private Label lblUserId;

        public Applicant_dashboard()
        {
            InitializeComponent();
        }

        public Applicant_dashboard(int userId) : this()
        {
            this.userId = userId;
        }
        private void Applicant_dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'formapp.applicant_info' table. You can move, or remove it, as needed.
            this.applicant_infoTableAdapter.Fill(this.formapp.applicant_info);
            // TODO: This line of code loads data into the 'formapp.applied_universities' table. You can move, or remove it, as needed.
            this.applied_universitiesTableAdapter.Fill(this.formapp.applied_universities);
            // TODO: This line of code loads data into the 'formapp.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.formapp.users);
            string connectionString = "Server=DESKTOP-CA19AHD\\SQLEXPRESS;Database=formapp;Trusted_Connection=True;";
            string query = @"
                SELECT a.application_id, a.status, i.name AS university_name
                FROM applied_universities a
                JOIN institution i ON a.institution_id = i.institution_id
                WHERE a.user_id = @UserId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    MessageBox.Show("Connection to database established successfully.");

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", this.userId);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvApplications.DataSource = dataTable;

                        // Set the DataGridView to display only the required columns
                        //dgvApplications.Columns["application_id"].HeaderText = "Application ID";
                        //dgvApplications.Columns["status"].HeaderText = "Status";
                        dgvApplications.Columns["university_name"].HeaderText = "University Name";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            // Code to handle new application creation
            MessageBox.Show("New Application button clicked.");
        }
          
        private void btnViewApplication_Click(object sender, EventArgs e)
        {
            // Code to handle viewing an application code

            MessageBox.Show("View Application button clicked.");
            //dgvApplications gd = new dgvApplications(); 
        }

        private void btnUploadDocuments_Click(object sender, EventArgs e)
        {
            // Code to handle document upload
            MessageBox.Show("Upload Documents button clicked.");
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            // Code to handle making a payment
            MessageBox.Show("Make Payment button clicked.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Code to handle logout
            MessageBox.Show("Logout button clicked.");
            this.Close();
        }

        //private void Applicant_dashboard_Load(object sender, EventArgs e)
        //{

        //}

        private void dgvApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.userTableAdapter.FillBy(this.testDataSet1.user);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void testDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void formappBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) =>
            // Set the text of the label to the user ID
            lblUserId.Text = "User ID: " + this.userId.ToString();
    }
}
