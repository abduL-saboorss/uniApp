using System.Data.SqlClient;

using System.Windows.Forms;
using System;


namespace FormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1) Read text from the text boxes
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // 2) Connect to your 'formapp' database
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=formapp;Trusted_Connection=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 3) Query to check if a user row exists with matching username & password
                    string query = @"
                SELECT COUNT(*) 
                FROM users
                WHERE username = @username
                  AND password = @password;
            ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // 4) Parameterize the input to avoid SQL injection
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // For production, store hashed passwords!

                        // 5) Execute the query and get the number of matching rows
                        int count = (int)cmd.ExecuteScalar();

                        // 6) Check if at least one row was found
                        if (count > 0)
                        {
                            lblMessage.Text = "Login successful!";
                            // TODO: Navigate to another form or proceed with your app logic
                            // e.g., MainForm main = new MainForm();
                            // main.Show();
                            // this.Hide();
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
                // Display any errors
                lblMessage.Text = "Error: " + ex.Message;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Instantiate and show the Applicant_dashboard form
            Applicant_dashboard dashboardForm = new Applicant_dashboard();
            dashboardForm.Show();
            this.Hide();
        }
    }
}