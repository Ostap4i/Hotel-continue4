using Project_Hotel.Controllers;
using Project_Hotel.Entities;
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

namespace Hotel_Interface
{
    public partial class Form2 : Form
    {
        private ClientController clientController = new ClientController();
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnAddUser;

        public Form2()
        {
            InitializeComponent();



            Client client = new Client();
            string id = client.Number_room;
            client = clientController.getClientByRoom(id);


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=UserDB;Integrated Security=True";
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (UserName, Password, Email) VALUES (@UserName, @Password, @Email)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("User added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error adding user.");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
    

