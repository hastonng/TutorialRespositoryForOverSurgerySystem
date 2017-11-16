using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    public class Receptionist
    {
        string name;
        int status;
        DateTime datejoined;
        string loginName;
        string password;

        public string Name { get => name; set => name = value; }
        public int Status { get => status; set => status = value; }
        public DateTime Datejoined { get => datejoined; set => datejoined = value; }
        public string LoginName { get => loginName; set => loginName = value; }
        public string Password { get => password; set => password = value; }
    }
}
