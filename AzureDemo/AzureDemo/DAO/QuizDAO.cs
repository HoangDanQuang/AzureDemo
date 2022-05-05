using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AzureDemo.DTO;
namespace AzureDemo.DAO
{
    class QuizDAO
    {
        private static QuizDAO instance;

        public static QuizDAO Instance
        {
            get { if (instance == null) instance = new QuizDAO(); return instance; }
            private set => instance = value;
        }
        private QuizDAO() { }
        public List<Quiz> getQuiz()
        {
            List<Quiz> listQuiz = new List<Quiz>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXECUTE dbo.USP_GetQuiz", new object[] {});
            for (int i = 0; i < data.Rows.Count; i++)
            {
                listQuiz.Add(new Quiz(data.Rows[i]));
            }
            return listQuiz;
        }
    }
}
