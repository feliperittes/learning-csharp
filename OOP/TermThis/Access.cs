using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermThis
{
    class Access
    {
        string password = "123";

        public bool Login(string password)
        {
            // return this.password == password; // mesma coisa
            return this.password.Equals(password);
        }
    }
}
