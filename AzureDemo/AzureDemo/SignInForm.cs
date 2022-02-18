using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void signInBtn_Click(object sender, EventArgs e)
        {
            TranslateForm translateForm = new TranslateForm();
            this.Hide();
            translateForm.Closed += (s, args) => this.Close();
            translateForm.Show();
        }
    }
}
