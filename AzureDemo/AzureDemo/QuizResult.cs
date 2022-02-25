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
    public partial class QuizResult : Form
    {
        int id;
        string displayName;
        public QuizResult(int numofRight, int numOfTotal, string name, int uId)
        {
            InitializeComponent();
            displayName = name;
            this.id = uId;
            lbDisplayName.Text = name.Trim();
            label2.Text = "Số câu đúng:   " + numofRight + "/" + numOfTotal;
        }

        private void lbQues_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void translateNavBtn_Click(object sender, EventArgs e)
        {
            TranslateForm translateForm = new TranslateForm("", 1);
            this.Hide();
            translateForm.Closed += (s, args) => this.Close();
            translateForm.Show();
        }

        private void newWordNavBtn_Click(object sender, EventArgs e)
        {

        }

        private void savedWordNavBtn_Click(object sender, EventArgs e)
        {
            SavedWordForm savedWordForm = new SavedWordForm(id, displayName);
            this.Hide();
            savedWordForm.Closed += (s, args) => this.Close();
            savedWordForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            QuizQuestionForm quizQuestionForm = new QuizQuestionForm(id,displayName);
            this.Hide();
            quizQuestionForm.Closed += (s, args) => this.Close();
            quizQuestionForm.Show();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            this.Hide();
            signInForm.Closed += (s, args) => this.Close();
            signInForm.Show();
        }
    }
}
