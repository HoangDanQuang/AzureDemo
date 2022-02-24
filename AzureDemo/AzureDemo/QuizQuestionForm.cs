using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzureDemo.DTO;
using AzureDemo.DAO;

namespace AzureDemo
{
    public partial class QuizQuestionForm : Form
    {
        List<Quiz> listQuiz = new List<Quiz>();
        int score = 0;
        int index;
        string displayName;
        public QuizQuestionForm(string displayname)
        {
            InitializeComponent();
            getListQuiz();
            index = 0;
            displayName = displayname;
            showQuiz();
            button10.Hide();
            lbDisplayname.Text = displayname.Trim();
            btOp1.BackColor = Color.White;
            btOp2.BackColor = Color.White;
            btOp3.BackColor = Color.White;
            btOp4.BackColor = Color.White;
            btOp1.ForeColor = Color.Black;
            btOp2.ForeColor = Color.Black;
            btOp3.ForeColor = Color.Black;
            btOp4.ForeColor = Color.Black;
        }
        private void getListQuiz()
        {
            listQuiz = QuizDAO.Instance.getQuiz();
        }
        private void showQuiz() {
            lbQues.Text = listQuiz[index].Ques.Trim();
            btOp1.Text = listQuiz[index].Option1.Trim();
            btOp2.Text = listQuiz[index].Option2.Trim();
            btOp3.Text = listQuiz[index].Option3.Trim();
            btOp4.Text = listQuiz[index].Option4.Trim();

        }
        private void translateNavBtn_Click(object sender, EventArgs e)
        {
            TranslateForm translateForm = new TranslateForm("", 1);
            this.Hide();
            translateForm.Closed += (s, args) => this.Close();
            translateForm.Show();
        }

        private void savedWordNavBtn_Click(object sender, EventArgs e)
        {
            SavedWordForm savedWordForm = new SavedWordForm();
            this.Hide();
            savedWordForm.Closed += (s, args) => this.Close();
            savedWordForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (btOp1.BackColor == Color.Blue && listQuiz[index].Ans == 1)
            {
                score++;
            }
            else if (btOp2.BackColor == Color.Blue && listQuiz[index].Ans == 2)
            {
                score++;
            }
            else if (btOp3.BackColor == Color.Blue && listQuiz[index].Ans == 3)
            {
                score++;
            }
            else if (btOp4.BackColor == Color.Blue && listQuiz[index].Ans == 4)
            {
                score++;
            }
            
            if (index < listQuiz.Count-1)
            {           
                index += 1;
                showQuiz();
                if (index == listQuiz.Count - 1) {
                    button10.Hide();
                }
            }
            btOp1.BackColor = Color.White;
            btOp2.BackColor = Color.White;
            btOp3.BackColor = Color.White;
            btOp4.BackColor = Color.White;
            btOp1.ForeColor = Color.Black;
            btOp2.ForeColor = Color.Black;
            btOp3.ForeColor = Color.Black;
            btOp4.ForeColor = Color.Black;
            button10.Hide();
        }

        private void btOp1_Click(object sender, EventArgs e)
        {
            if (btOp1.BackColor == Color.Blue)
            {
                btOp1.ForeColor = Color.Black;
                btOp1.BackColor = Color.White;
                button10.Hide();
            }
            else
            {
                btOp1.BackColor = Color.Blue;
                btOp1.ForeColor = Color.White;
                btOp2.BackColor = Color.White;
                btOp3.BackColor = Color.White;
                btOp4.BackColor = Color.White;
                btOp2.ForeColor = Color.Black;
                btOp3.ForeColor = Color.Black;
                btOp4.ForeColor = Color.Black;
                if(index < listQuiz.Count -1)
                button10.Show();
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (btOp1.BackColor == Color.Blue && listQuiz[index].Ans == 1)
            {
                score++;
            }
            else if (btOp2.BackColor == Color.Blue && listQuiz[index].Ans == 2)
            {
                score++;
            }
            else if (btOp3.BackColor == Color.Blue && listQuiz[index].Ans == 3)
            {
                score++;
            }
            else if (btOp4.BackColor == Color.Blue && listQuiz[index].Ans == 4)
            {
                score++;
            }
            QuizResult savedWordForm = new QuizResult(score, listQuiz.Count, displayName);
            this.Hide();
            savedWordForm.Closed += (s, args) => this.Close();
            savedWordForm.Show();
        }

        private void btOp2_Click(object sender, EventArgs e)
        {

            if (btOp2.BackColor == Color.Blue)
            {
                btOp2.ForeColor = Color.Black;
                btOp2.BackColor = Color.White;
                button10.Hide();
            }
            else
            {
                btOp2.BackColor = Color.Blue;
                btOp2.ForeColor = Color.White;
                btOp1.BackColor = Color.White;
                btOp3.BackColor = Color.White;
                btOp4.BackColor = Color.White;
                btOp1.ForeColor = Color.Black;
                btOp3.ForeColor = Color.Black;
                btOp4.ForeColor = Color.Black;
                if (index < listQuiz.Count - 1)
                    button10.Show();
            }
        }

        private void btOp4_Click(object sender, EventArgs e)
        {

            if (btOp4.BackColor == Color.Blue)
            {
                btOp4.ForeColor = Color.Black;
                btOp4.BackColor = Color.White;
                button10.Hide();
            }
            else
            {
                btOp4.BackColor = Color.Blue;
                btOp4.ForeColor = Color.White;
                btOp2.BackColor = Color.White;
                btOp1.BackColor = Color.White;
                btOp3.BackColor = Color.White;
                btOp1.ForeColor = Color.Black;
                btOp2.ForeColor = Color.Black;
                btOp3.ForeColor = Color.Black;
                if (index < listQuiz.Count - 1)
                    button10.Show();
            }
        }

        private void btOp3_Click(object sender, EventArgs e)
        {

            if (btOp3.BackColor == Color.Blue)
            {
                btOp3.ForeColor = Color.Black;
                btOp3.BackColor = Color.White;
                button10.Hide();
            }
            else
            {
                btOp3.BackColor = Color.Blue;
                btOp3.ForeColor = Color.White;
                btOp1.BackColor = Color.White;
                btOp2.BackColor = Color.White;
                btOp4.BackColor = Color.White;
                btOp1.ForeColor = Color.Black;
                btOp2.ForeColor = Color.Black;
                btOp4.ForeColor = Color.Black;
                if (index < listQuiz.Count - 1)
                    button10.Show();
            }
        }
    }
}
