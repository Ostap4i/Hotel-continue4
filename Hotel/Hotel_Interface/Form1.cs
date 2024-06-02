using Hotel_Interface;
using Project_Hotel.Controllers;
using Project_Hotel.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private AccountController accountController = new AccountController();

        public Form1()
        {
            InitializeComponent();
            loggedMessage.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Account account = accountController.login(loginName.Text, loginPassword.Text);

            if (loginName.Text == account.Name && loginPassword.Text == account.Password)
            {
                loggedMessage.Visible = true;
                //loggedMessage.Text = $"You have been successfully logged as {account.Name}";
                loggedMessage.ForeColor = Color.Red;
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                loggedMessage.Visible = true;
                loggedMessage.Text = "Enter name and password to login";
                loggedMessage.ForeColor = Color.Green;
            }

        }

        private void loggedMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
