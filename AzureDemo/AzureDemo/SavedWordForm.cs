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
    public partial class SavedWordForm : Form
    {
        List<Vocabulary> listVoca = new List<Vocabulary>();
        int id = 1;
        string displayName;
        public SavedWordForm(int uId, string displayName)
        {
            InitializeComponent();
            id = uId;
            this.displayName = displayName;
            label1.Text = displayName.Trim();
            loadList();
            listView1.Items.Clear();
            for (var i = 0; i < listVoca.Count(); i++)
            {
                listView1.Items.Add(listVoca[i].EN);
            }
            if (listVoca.Count != 0)
            {
                label3.Text = listVoca[0].VN;
            }
        }
        private void loadList() {
            listVoca = VocabularyDAO.Instance.getVocabulary(id);
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

        private void newWordNavBtn_Click(object sender, EventArgs e)
        {
            NewWordForm newWordForm = new NewWordForm(id, displayName);
            this.Hide();
            newWordForm.FormClosed += (s, args) => this.Close();
            newWordForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddWordForm addWordForm = new AddWordForm(id,displayName);
            this.FormClosed += (s, args) => addWordForm.Close();
            addWordForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vocabulary vc = new Vocabulary(""," ",0);

            string en = this.listView1.SelectedItems[0].Text;

            for (int i = 0; i < listVoca.Count; i++)
            {
                if (en == listVoca[i].EN)
                {
                    vc = listVoca[i];
                }
            }
            SetWordForm setWordForm = new SetWordForm(vc.EN,vc.VN,vc.ID, id, displayName);
            this.FormClosed += (s, args) => setWordForm.Close();
            setWordForm.Show();
            this.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string en = listView1.SelectedItems[0].Text.ToString();
            for (int i = 0; i < listVoca.Count; i++)
            {
                if (en == listVoca[i].EN)
                {
                    var rs = VocabularyDAO.Instance.deleteVocabulary(listVoca[i].ID);
                    listVoca.RemoveAt(i);
                    listView1.Items.RemoveAt(i);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
                return;

            string en = this.listView1.SelectedItems[0].Text;
            for (int i = 0; i < listVoca.Count; i++)
            {
                if (en == listVoca[i].EN)
                {
                    label3.Text = "Nghĩa: " + listVoca[i].VN;
                }
            }
        }
    }
}
