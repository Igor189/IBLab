using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IBLab1
{
    internal class Admin : User    {

        private string password_= "password";
        public string Login { get; set; }
        public string Password { get => password_; private set => password_ = value; }
    }
}
