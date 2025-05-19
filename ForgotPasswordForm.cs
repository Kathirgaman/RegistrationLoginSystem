using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAuthSystem
{
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            string connectionString = "Data Source=DESKTOP-391MDBU\\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
            string enteredEmail = txtEmail.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT SecurityQuestion FROM Users WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", enteredEmail);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    txtSecurityQuestion.Text = result.ToString(); // Display the question
                    MessageBox.Show("Email verified. Please answer the security question.");
                }
                else
                {
                    MessageBox.Show("Email not found.");
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-391MDBU\\SQLEXPRESS;Initial Catalog=UserAuthDB;Integrated Security=True;";
            string enteredEmail = txtEmail.Text.Trim();
            string answer = txtSecurityAnswer.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND SecurityAnswer = @Answer";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Email", enteredEmail);
                checkCmd.Parameters.AddWithValue("@Answer", answer);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    string updateQuery = "UPDATE Users SET Password = @NewPassword WHERE Email = @Email";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                    updateCmd.Parameters.AddWithValue("@Email", enteredEmail);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Password reset successful!");
                }
                else
                {
                    MessageBox.Show("Security answer is incorrect.");
                }
            }
        }
    }
        }
    

