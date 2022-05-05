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
        int id;
        string displayName;
        public LearnNewWordForm(int uId, string displayName)
        {
            InitializeComponent();
            this.id = uId;
            this.displayName = displayName;
            label1.Text = displayName.Trim();
        }

        private void savedWordNavBtn_Click(object sender, EventArgs e)
        {
            SavedWordForm savedWordForm = new SavedWordForm(id, displayName);
            this.Hide();
            savedWordForm.Closed += (s, args) => this.Close();
            savedWordForm.Show();
        }

        private void quizNavBtn_Click(object sender, EventArgs e)
        {
            QuizForm quizForm = new QuizForm(id,displayName);
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
            TranslateForm translateForm = new TranslateForm(displayName,1);
            this.Hide();
            translateForm.Closed += (s, args) => this.Close();
            translateForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewWordForm learnForm = new NewWordForm(id, displayName);
            this.Hide();
            learnForm.Closed += (s, args) => this.Close();
            learnForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
