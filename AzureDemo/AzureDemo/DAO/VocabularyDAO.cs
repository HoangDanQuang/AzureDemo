using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AzureDemo.DTO;
using System.Data.SqlClient;
namespace AzureDemo.DAO
{
    class VocabularyDAO
    {
        private static VocabularyDAO instance;

        public static VocabularyDAO Instance
        {
            get { if (instance == null) instance = new VocabularyDAO(); return instance; }
            private set => instance = value;
        }
        private VocabularyDAO() { }
        public List<Vocabulary> getVocabulary(int id)
        {
            List<Vocabulary> listVocabulary = new List<Vocabulary>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXECUTE dbo.USP_GetListVocabulary @id", new object[] {id});
            for (int i = 0; i < data.Rows.Count; i++)
            {
                listVocabulary.Add(new Vocabulary(data.Rows[i]));
            }
            return listVocabulary;
        }
        public int getVocabularyID() {
            int id = 0;
            string query = "EXEC dbo.USP_GetVocabularyId";
            string connectStr = @"Server=tcp:engsup.database.windows.net,1433;Initial Catalog=envoca;Persist Security Info=False;User ID=huynhtrongphuc;Password=Trongphuc123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = @"EXEC dbo.USP_GetVocabularyId";
                    connection.Open();
                    using (var cc = command.ExecuteReader())
                    {
                        while (cc.Read())
                        {
                            if(!cc.IsDBNull(0))
                            id = cc.GetInt32(0);
                        }
                    }
                    connection.Close();
                }
            }
            return id;
        }
        public bool addVocabulary(string en, string vn, int userId)
        {
            int id = getVocabularyID() + 1;
            string query = "EXEC dbo.USP_AddVocabulary @id , @en , @vn , @userId";
            int data = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { id, en, vn, userId });
            return data > 0;

        }
        public bool deleteVocabulary(int id)
        {
            string query = "EXEC dbo.USP_DeleteVocabulary @id";
            int data = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { id});
            return data > 0;
        }
        public bool setVocabulary(string vn, string en, int id)
        {
            string query = "EXEC dbo.USP_SetVocabulary @id , @en , @vn ";
            int data = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { id, en, vn });
            return data > 0;
        }
    }
}
