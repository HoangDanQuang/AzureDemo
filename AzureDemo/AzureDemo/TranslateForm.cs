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
using System.Net.Http;
using Newtonsoft.Json;
namespace AzureDemo
{
    public partial class TranslateForm : Form
    {
        private static readonly string subscriptionKey = "9f23c91f740e4fd68231d35c330347ff";
        private static readonly string endpoint = "https://api.cognitive.microsofttranslator.com/";
        private static readonly string location = "southeastasia";
        string route = "/translate?api-version=3.0&from=en&to=vi";
        string DisplayName;
        int UserId;
        public TranslateForm(string dislayname, int userID)
        {
            DisplayName = dislayname;
            UserId = userID;
            InitializeComponent();
            lbName.Text = dislayname.Trim();
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
            QuizForm quizForm = new QuizForm(DisplayName);
            this.Hide();
            quizForm.Closed += (s, args) => this.Close();
            quizForm.Show();
        }
        string res = "";
        private async void translate()
        {
            string textToTranslate = tbEN.Text;
            object[] body = new object[] { new { Text = textToTranslate } };
            var requestBody = JsonConvert.SerializeObject(body);

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Build the request.
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(endpoint + route);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
                request.Headers.Add("Ocp-Apim-Subscription-Region", location);

                // Send the request and get response.
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                // Read response as a string.
                string result = await response.Content.ReadAsStringAsync();
                res = result.Split('"')[5];
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            translate();
            tbVN.Text = res;
        }
        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = cbBox.SelectedItem.ToString();
            if (curItem == "Tiếng việt sang tiếng anh") {
                bt2.Text = "Tiếng Anh";
                bt1.Text = "Tiếng Việt";
                route = "/translate?api-version=3.0&from=vi&to=en";
            }
            else
            {
                bt1.Text = "Tiếng Anh";
                bt2.Text = "Tiếng Việt";
                route = "/translate?api-version=3.0&from=en&to=vi";
            }
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
    }
}
