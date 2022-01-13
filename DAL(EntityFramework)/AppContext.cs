using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Library_BLL;

namespace DAL_EntityFramework_
{
    public class AppContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public AppContext() : base("DefaultConnection") { };
    }
}
