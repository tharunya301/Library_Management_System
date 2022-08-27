using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class class_admin
    {
        String userName = "user";
        String password = "1";

        String securityQuestion = "When Your Birth Year..?";
        String ans = "1555";

        public String un()
        {
            return userName;
        }

        public String p()
        {
            return password;
        }

        public String setUname(String u)
        {
            userName = u;
            return null;
        }

        public String setPass(String p)
        {
            password = p;
            return null;
        }

        public string setQs()
        {
            return securityQuestion;
        }

        public string setAns()
        {
            return ans;
        }

        public string setAns(String a)
        {
            ans = a;
            return null;
        }

        public string setQues(string q)
        {
            securityQuestion = q;
            return null;
        }
    }
}
