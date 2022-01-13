using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_BLL
{
    public class Employee
    {
        public Employee(string login = "", string password = "", string email = "")
        {
            Login = login;
            Password = password;
            Email = email;
        }
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}