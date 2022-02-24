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
    public partial class LearnNewWordForm : Form
    {
        public LearnNewWordForm()
        {
            InitializeComponent();
        }

        private void savedWordNavBtn_Click(object sender, EventArgs e)
        {
            SavedWordForm savedWordForm = new SavedWordForm();
            this.Hide();
            savedWordForm.Closed += (s, args) => this.Close();
            savedWordForm.Show();
        }

        private void quizNavBtn_Click(object sender, EventArgs e)
        {
            QuizForm quizForm = new QuizForm();
            this.Hide();
            quizForm.Closed += (s, args) => this.Close();
            quizForm.Show();
        }

        private void logoutNavBtn_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            this.Hide();
            signInForm.Closed += (s, args) => this.Close();
            signInForm.Show();
        }

        private void TranslateNavBtn_Click(object sender, EventArgs e)
        {
            TranslateForm translateForm = new TranslateForm();
            this.Hide();
            translateForm.Closed += (s, args) => this.Close();
            translateForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewWordForm learnForm = new NewWordForm();
            this.Hide();
            learnForm.Closed += (s, args) => this.Close();
            learnForm.Show();
        }
    }
}
