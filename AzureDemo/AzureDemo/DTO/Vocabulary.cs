using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AzureDemo.DTO
{
    class Vocabulary
    {
        int id;
        string en;
        string vn;
        int userID;
        public Vocabulary(string e, string v, int uid)
        {
            this.UserID = uid;
            this.EN = e;
            this.VN = v;
        }
        public Vocabulary(DataRow data)
        {
            this.EN = data["en"].ToString();
            this.VN = data["vn"].ToString();
            this.UserID = (int)data["userId"];
            this.ID = (int)data["id"];
        }
        public string EN { get => en; set => en = value; }
        public string VN { get => vn; set => vn = value; }
        public int UserID { get => userID; set => userID = value; }
        public int ID { get => ID; set => ID = value; }

    }
}
