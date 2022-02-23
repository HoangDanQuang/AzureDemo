using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AzureDemo.DTO
{
    class Account
    {
        string userName;
        string displayName;
        string passWord;
        int id;
        public Account(string user, string display, string pass)
        {
            this.UserName = user;
            this.DisplayName = display;
            this.PassWord = pass;
        }
        public Account(DataRow data)
        {
            this.UserName = data["userName"].ToString();
            this.DisplayName = data["displayName"].ToString();
            this.PassWord = data["password"].ToString();
            this.ID = (int)data["id"];
        }
        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int ID { get => id; set => id = value; }
    }
}
