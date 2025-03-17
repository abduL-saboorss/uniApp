using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FormsApp1
{
    public partial class LoginForm : Form
    {
        // private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=formapp;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT user_id 
                        FROM users
                        WHERE username = @username
                          AND password = @password;
                    ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        _ = cmd.Parameters.AddWithValue("@username", username);
                        _ = cmd.Parameters.AddWithValue("@password", password);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            int userId = (int)result;
                            lblMessage.Text = "Login successful!";
                            Applicant_dashboard dashboardForm = new Applicant_dashboard(userId);
                            dashboardForm.Show();
                            Hide();
                        }
                        else
                        {
                            lblMessage.Text = "Invalid username or password.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error: " + ex.Message;
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /*  private void guna2Button1_Click(object sender, EventArgs e)
          {
              // Instantiate and show the Applicant_dashboard form

          }*/
    }
}