using AzureDemo.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace AzureDemo.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value;
        }
        private AccountDAO() { }
        public bool login(string userName, string pass)
        {
            //Mã hóa MD5

            MD5 md = MD5.Create();
            byte[] temp = Encoding.ASCII.GetBytes(pass);
            byte[] hashData = md.ComputeHash(temp);
            string hashPass = "";
            foreach (byte item in hashData)
            {
                hashPass += item;
            }
            string query = "EXECUTE dbo.USP_Login @user , @pass";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hashPass });
            if (data.Rows.Count > 0) return true;
            return false;
        }
        public Account getAccount(string userName, string pass)
        {
            MD5 md = MD5.Create();
            byte[] temp = Encoding.ASCII.GetBytes(pass);
            byte[] hashData = md.ComputeHash(temp);
            string hashPass = "";
            foreach (byte item in hashData)
            {
                hashPass += item;
            }
            DataTable data = DataProvider.Instance.ExecuteQuery("EXECUTE dbo.USP_GetAccount @userName , @passWord", new object[] { userName, hashPass });
            Account account = new Account(data.Rows[0]);
            return account;
        }
        public int getUserID() {
            int id=0;
            string query = "EXEC dbo.USP_GetUserId";
            string connectStr = @"Server=tcp:envoca.database.windows.net,1433;Initial Catalog=DP900;Persist Security Info=False;User ID=huynhtrongphuc;Password=Trongphuc123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            using (SqlConnection connection = new SqlConnection(connectStr))
            {
                using (var command = connection.CreateCommand()) {
                    command.CommandText = @"EXEC dbo.USP_GetUserId";
                    connection.Open();
                    using (var cc = command.ExecuteReader()) {
                        while(cc.Read())
                        {
                            id = cc.GetInt32(0)+1;
                        }
                    }
                    connection.Close();
                }
            }
            return id;
        }
        public bool createAccount(string user, string display, string pass)
        {
            MD5 md = MD5.Create();
            byte[] temp = Encoding.ASCII.GetBytes(pass);
            byte[] hashData = md.ComputeHash(temp);
            string hashPass = "";
            int id = getUserID();
            foreach (byte item in hashData)
            {
                hashPass += item;
            }
            string query = "EXEC dbo.USP_CreateAccount @id , @display , @user , @pass";
            int data = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { id, display, user , hashPass});
            return data > 0;
        }
    }
}
