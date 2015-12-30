using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seek_Sale
{
    class UserInfo
    {
        public bool logined;
        public string username;
        public int userid;

        public static readonly UserInfo instance = new UserInfo();
        private UserInfo()
        {
            this.logined = false;
        }
    }
}
