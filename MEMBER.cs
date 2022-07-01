using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR_week13_3
{
    class MEMBER:PERSON,IADDRESS
    {
        public int MEMBERNO { set; get; }
        private string ADDRESS { set; get; }
        public int AGE { set; get; }
        public MEMBER(string a,int m,int age,string n,int i)
        {
            ADDRESS = a;
            AGE = age;
            MEMBERNO = m;
            NAME = n;
            ID = i;
        }
        public string MEMBERINFO()
        {
            return $"\n編號：{MEMBERNO}，姓名：{NAME}，身分證：{ID}，地址：{ADDRESS}，年紀：{AGE}";
        }
        string IADDRESS.getADDRESS()
        {
            return $"地址：{ ADDRESS}";
        }
    }
}
