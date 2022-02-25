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
    public partial class QuizForm : Form
    {
        int id;
        string displayName;
        public QuizForm(int uid, string name)
        {
            InitializeComponent();
            displayName = name;
            this.id = uid;
            label1.Text = displayName.Trim();
        }

        private void translateNavBtn_Click(object sender, EventArgs e)
        {
            TranslateForm translateForm = new TranslateForm("",1);
            this.Hide();
            translateForm.Closed += (s, args) => this.Close();
            translateForm.Show();
        }

        private void savedWordNavBtn_Click(object sender, EventArgs e)
        {
            SavedWordForm savedWordForm = new SavedWordForm(id, displayName);
            this.Hide();
            savedWordForm.Closed += (s, args) => this.Close();
            savedWordForm.Show();
        }

        private void startQuizBtn_Click(object sender, EventArgs e)
        {
            QuizQuestionForm quizQuestionForm = new QuizQuestionForm(id,displayName);
            this.Hide();
            quizQuestionForm.Closed += (s, args) => this.Close();
            quizQuestionForm.Show();
        }

      
        private void logoutNavBtn_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            this.Hide();
            signInForm.Closed += (s, args) => this.Close();
            signInForm.Show();
        }

        private void newWordNavBtn_Click(object sender, EventArgs e)
        {
            NewWordForm newWordForm = new NewWordForm(id, displayName);
            this.Hide();
            newWordForm.FormClosed += (s, args) => this.Close();
            newWordForm.Show();
        }
    }
}
