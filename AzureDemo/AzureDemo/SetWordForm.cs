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
    public partial class SetWordForm : Form
    {
        string EN;
        string VN;
        int ID;
        int uID;
        string displayName;
        public SetWordForm(string en, string vn, int id, int uID, string name)
        {
            InitializeComponent();
            this.EN = en;
            this.VN = vn;
            this.ID = id;
            this.tbEN.Text = vn;
            this.uID = uID;
            this.displayName = name;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VN = tbEN.Text;
            var rs = VocabularyDAO.Instance.setVocabulary(VN, EN, ID);
            SavedWordForm savedWordForm = new SavedWordForm(uID, displayName);
            this.FormClosed += (s, args) => savedWordForm.Close();
            savedWordForm.Show();
            this.Hide();
            if (rs)
            {
                MessageBox.Show("Từ này đã được sửa trong \"Từ vựng của bạn\"", "Sửa từ thành công", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Không thể sửa từ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }
    }
}
