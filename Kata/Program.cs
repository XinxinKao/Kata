using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class Program
    {
        public Program()
        {
            FormLoad();
        }

        static void Main(string[] args)
        {
        }

        public struct Member
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public List<string> Phones { get; set; }
        }

        List<Member> _memberList = new List<Member>();
        private void FormLoad()
        {
            this._memberList = new List<Member>() 
            { 
                new Member(){Name="Yao",Age=18,Phones=new List<string>(){"0911123456789","0912123456789"}},
                new Member(){Name="gy",Age=20,Phones=new List<string>(){"0913123456789","0914123456789"}},
                new Member(){Name="LaLa",Age=19,Phones=new List<string>(){"0915123456789","0916123456789"}},
                new Member(){Name="9GY",Age=12,Phones=new List<string>(){"0917123456789","0918123456789"}}
            };

            var find = from data in _memberList
                where data.Name.ToUpper() == "YAO"
                select data;
            foreach (var item in find)
            {
                //TODO:
            }
        }


    }
}
