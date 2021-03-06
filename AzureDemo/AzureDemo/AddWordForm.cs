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
    public partial class AddWordForm : Form
    {
        int id;
        string displayName;
        public AddWordForm(int id, string name)
        {
            InitializeComponent();
            this.id = id;
            this.displayName = name;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string en = this.tbEN.Text;
            string vn = this.tbVN.Text;
            bool rs = VocabularyDAO.Instance.addVocabulary(en, vn, id);
            SavedWordForm savedWordForm = new SavedWordForm(id, displayName);
            this.FormClosed += (s, args) => savedWordForm.Close();
            savedWordForm.Show();
            this.Hide();
            if (rs)
            {
                MessageBox.Show("Từ " + en +" đã được thêm vào \"Từ vựng của bạn\"", "Thêm từ thành công", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không thể thêm từ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
