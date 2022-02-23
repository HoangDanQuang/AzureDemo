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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.Closed += (s, args) => this.Close();
            signUpForm.Show();
        }
        public bool login(string userName, string passWord)
        {
            return AccountDAO.Instance.login(userName, passWord);
        }
        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (login(tBUsername.Text.ToString(), tbPassword.Text.ToString()))
            {
                Account account = AccountDAO.Instance.getAccount(tBUsername.Text, tbPassword.Text);
                TranslateForm translateForm = new TranslateForm(account.DisplayName, account.ID);
                tbPassword.Clear();
                tBUsername.Clear();
                tBUsername.Focus();
                this.Hide();
                translateForm.Closed += (s, args) => this.Close();
                translateForm.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhận không tồn tại hoặc mật khẩu sai", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
