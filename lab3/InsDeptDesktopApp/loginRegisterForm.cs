using InsDeptDesktopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsDeptDesktopApp
{
    public partial class loginRegisterForm : Form
    {
        HttpClient client;
        public loginRegisterForm()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser user = new LoginUser();
            user.UserName = txtUsernameLogin.Text;
            user.Password = txtPasswordLogin.Text;
            HttpResponseMessage resultIns = client.PostAsJsonAsync(ConfigurationManager.AppSettings["Login"], user).Result;
            if (resultIns.IsSuccessStatusCode)
            {
                Form1 win = new Form1();
                this.Hide();
                win.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Check username and password again!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
            RegisterUser user = registerForm.newUser;
            HttpResponseMessage resultIns = client.PostAsJsonAsync(ConfigurationManager.AppSettings["Register"], user).Result;
            if (resultIns.IsSuccessStatusCode)
            {
                MessageBox.Show("Account added successfully!");
            }
            else
            {
                MessageBox.Show("Error while creating account!");
                MessageBox.Show(resultIns.RequestMessage.ToString());
            }
        }
    }
}
