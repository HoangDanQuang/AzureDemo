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
    public partial class NewWordForm : Form
    {
        int id;
        string displayName;
        public NewWordForm(int uId, string name)
        {
            InitializeComponent();
            this.id = uId;
            this.displayName = name;
        }

        private void savedWordNavBtn_Click(object sender, EventArgs e)
        {
            SavedWordForm savedWordForm = new SavedWordForm(id,displayName);
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
            TranslateForm translateForm = new TranslateForm(displayName, id);
            this.Hide();
            translateForm.Closed += (s, args) => this.Close();
            translateForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LearnNewWordForm learnForm = new LearnNewWordForm(id, displayName);
            this.Hide();
            learnForm.Closed += (s, args) => this.Close();
            learnForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LearnNewWordForm learnForm = new LearnNewWordForm(id, displayName);
            this.Hide();
            learnForm.Closed += (s, args) => this.Close();
            learnForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            LearnNewWordForm learnForm = new LearnNewWordForm(id, displayName);
            this.Hide();
            learnForm.Closed += (s, args) => this.Close();
            learnForm.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            LearnNewWordForm learnForm = new LearnNewWordForm(id, displayName);
            this.Hide();
            learnForm.Closed += (s, args) => this.Close();
            learnForm.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            LearnNewWordForm learnForm = new LearnNewWordForm(id, displayName);
            this.Hide();
            learnForm.Closed += (s, args) => this.Close();
            learnForm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LearnNewWordForm learnForm = new LearnNewWordForm(id, displayName);
            this.Hide();
            learnForm.Closed += (s, args) => this.Close();
            learnForm.Show();
        }
    }
}
