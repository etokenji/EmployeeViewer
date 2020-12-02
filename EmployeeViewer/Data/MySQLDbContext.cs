using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeViewer.Data
{
    public class MySQLDbContext:DbContext
    {

        public MySQLDbContext(DbContextOptions<MySQLDbContext> options) : base(options)
        {

        }

        public DbSet<Models.EmployeeInfo> MST_EMPLOYEEINFO { get; set; }
        public DbSet<Models.DepartmentInfo> MST_DEPARTMENT { get; set; }
    }
}
