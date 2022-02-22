using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AzureDemo.DTO
{
    class Quiz
    {
        string ques;
        string option1;
        string option2;
        string option3;
        string option4;
        int ans;
        public Quiz(string q, string op1, string op2, string op3, string op4, int a) {
            this.Ques = q;
            this.Ans = a;
            this.Option1 = op1;
            this.Option2 = op2;
            this.Option3 = op3;
            this.Option4 = op4;
        }
        public Quiz(DataRow data)
        {
            this.Ques = data["quiz"].ToString();
            this.Option1 = data["option1"].ToString();
            this.Option2 = data["option2"].ToString();
            this.Option3 = data["option3"].ToString();
            this.Option4 = data["option4"].ToString();
            this.Ans = (int)data["ans"];
        }
        public string Ques { get => ques; set => ques = value; }
        public string Option1 { get => option1; set => option1 = value; }
        public string Option2 { get => option2; set => option2 = value; }
        public string Option3 { get => option3; set => option3 = value; }
        public string Option4 { get => option4; set => option4 = value; }
        public int Ans { get => ans; set => ans = value; }

    }
}
