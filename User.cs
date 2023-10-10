using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLab1
{
    public interface User
    {
        string Login { get; set; }
        string Password { get; }
    }
}
