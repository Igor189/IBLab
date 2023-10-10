using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLab1
{
    internal class NoAdmin : User
    {
        public string Login { get; set; }
        public string Password { get; private  set; }
    }
}
