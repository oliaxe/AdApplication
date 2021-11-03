using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdApplication
{
    public class User1
    {
        private static User1 _user;
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public static User1 GetUser()
        {
            if (_user is null)
            {
                _user = new User1();
            }
            return _user;
        }

       }
}
