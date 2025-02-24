using System;
using System.Data.SqlClient;  // <-- For SQL Server
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // 1) Validate that the password fields match
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblMessage.Text = "Passwords do not match!";
                return;
            }

            // 2) Define the connection string for SQL Server
            //    Adjust if your instance name or authentication is different
            string connectionString =
                "Server=localhost\\SQLEXPRESS;Database=formapp;Trusted_Connection=True;";

            // 3) Use SqlConnection and SqlCommand to insert into 'users'
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 4) Prepare an INSERT statement that matches the columns in your 'users' table
                    string query = @"
                            INSERT INTO users (fullname, username, email, password, role)
                            VALUES (@FullName, @Username, @Email, @Password, @Role)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Role", cmbRole.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                    }

                    lblMessage.Text = "Registration successful!";
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Error: " + ex.Message;
                }
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
