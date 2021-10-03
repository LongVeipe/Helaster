using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterHelper.Data
{
    class Account
    {
        private static Account __instant;

        public static Account getInstant()
        {
            if (__instant == null)
                __instant = new Account();
            return __instant;
        }


        string avatar;
        string name;
        bool gender;
        string birthday;
        string email;

        public Account()
        {
            name = "Nguyễn Đình Long";
            gender = true;
            birthday = "2000";
            email = "18521032@gm.uit.edu.vn";

        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}
