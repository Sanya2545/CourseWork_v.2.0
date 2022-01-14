using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_BLL;

namespace DAL_SQLite_
{
    public class EmployeeHelper
    {
        public EmployeeHelper(){}
        public void AddEmployee(Employee employee)
        {
            AppContext db = new AppContext();
            db.Employees.Add(employee);
            db.SaveChanges();
        }
    }
}
