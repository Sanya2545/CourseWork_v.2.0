using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BLL
{
    public class Employee
    {
        public int id{ get; set; }
        public string login{ get; set; }
        public string password{ get; set; }
        public string email{ get; set; }

        public Employee(string login = "", string password = "", string email = "")
        {
            this.login = login;
            this.password = password;
            this.email = email;
        }


    }
}
