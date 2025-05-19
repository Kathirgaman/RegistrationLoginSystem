using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UserAuthSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = tbEmailID.Text.Trim();
            string username = tbusername.Text.Trim();
            string password = TBPassword.Text;

            if (string.IsNullOrWhiteSpace(tbEmailID.Text) ||
            string.IsNullOrWhiteSpace(TBPassword.Text) ||
            string.IsNullOrWhiteSpace(txtSecurityAnswer.Text))
            {
                MessageBox.Show("Please fill in all fields including security question.");
                return;
            }

            // ✅ Validate Inputs
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // ✅ Hash the password
            string hashedPassword = ComputeSha256Hash(password);
            string question = cmbSecurityQuestion.SelectedItem.ToString();
            string answer = txtSecurityAnswer.Text.Trim();

            try
            {
                using (SqlConnection conn = new SqlConnection(DatabaseHelper.connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Email, Username, PasswordHash,SecurityQuestion,SecurityAnswer  ) VALUES (@Email, @Username, @PasswordHash , @SecurityQuestion , @SecurityAnswer)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        cmd.Parameters.AddWithValue("@SecurityQuestion", question);
                        cmd.Parameters.AddWithValue("@SecurityAnswer", answer);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Registration successful!");
                            // Optionally clear fields
                            tbEmailID.Clear();
                            tbusername.Clear();
                            TBPassword.Clear();
                            LoginForm loginForm = new LoginForm();
                            loginForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ✅ SHA256 Hashing Method
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
    }
