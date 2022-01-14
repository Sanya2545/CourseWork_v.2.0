using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_BLL;
namespace DAL_SQLite_
{
    public class AppContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public AppContext() : base("DefaultConnection"){}
    }
}
