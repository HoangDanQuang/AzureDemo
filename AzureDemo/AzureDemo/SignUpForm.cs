using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzureDemo.DAO;
using AzureDemo.DTO;
namespace AzureDemo
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            tbPassword.Clear();
            tbDisplayName.Clear();
            tbUserName.Focus();
        }
        public bool createAccount(string userName,string display, string passWord)
        {
            return AccountDAO.Instance.createAccount(userName,display, passWord);
        }
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (createAccount(tbUserName.Text.ToString(),tbDisplayName.Text.ToString(), tbPassword.Text.ToString()))
            {
                Account account = AccountDAO.Instance.getAccount(tbUserName.Text, tbPassword.Text);
                TranslateForm translateForm = new TranslateForm();
                this.Hide();
                translateForm.Closed += (s, args) => this.Close();
                translateForm.Show();
            }
            else
            {
                MessageBox.Show("Lỗi thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            this.Hide();
            signInForm.Closed += (s, args) => this.Close();
            signInForm.Show();
        }
    }
}
