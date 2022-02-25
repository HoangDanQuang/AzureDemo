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
    public partial class SavedWordForm : Form
    {
        public SavedWordForm()
        {
            InitializeComponent();
        }

        private void translateNavBtn_Click(object sender, EventArgs e)
        {
            TranslateForm translateForm = new TranslateForm("", 1);
            this.Hide();
            translateForm.Closed += (s, args) => this.Close();
            translateForm.Show();
        }

        private void quizNavBtn_Click(object sender, EventArgs e)
        {
            QuizForm quizForm = new QuizForm("");
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

        private void newWordNavBtn_Click(object sender, EventArgs e)
        {
            NewWordForm newWordForm = new NewWordForm();
            this.Hide();
            newWordForm.FormClosed += (s, args) => this.Close();
            newWordForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddWordForm addWordForm = new AddWordForm();
            this.FormClosed += (s, args) => addWordForm.Close();
            addWordForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetWordForm setWordForm = new SetWordForm();
            this.FormClosed += (s, args) => setWordForm.Close();
            setWordForm.Show();
        }
    }
}
