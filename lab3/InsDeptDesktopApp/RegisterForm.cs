using InsDeptDesktopApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsDeptDesktopApp
{
    public partial class RegisterForm : Form
    {
        public RegisterUser newUser;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (txtPasswordRegister.Text == txtConfirmPassRegister.Text)
            {
                newUser = new RegisterUser();
                newUser.UserName = txtUsernameRegister.Text;
                newUser.Password = txtPasswordRegister.Text;
                newUser.Email = txtEmailRegister.Text;
                newUser.ConfirmPassword = txtConfirmPassRegister.Text;
                this.Close();
            }
            else
                MessageBox.Show("Password doesn't match");
        }
    }
}
