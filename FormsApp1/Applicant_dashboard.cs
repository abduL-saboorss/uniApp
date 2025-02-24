using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class Applicant_dashboard : Form
    {
        public Applicant_dashboard()
        {
            InitializeComponent();
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            // Code to handle new application creation
            MessageBox.Show("New Application button clicked.");
        }
          
        private void btnViewApplication_Click(object sender, EventArgs e)
        {
            // Code to handle viewing an application
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

        private void Applicant_dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dgvApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
