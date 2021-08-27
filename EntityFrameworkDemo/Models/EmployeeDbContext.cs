using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApproachDemo.Models
{
    public class EmployeeDbContext: DbContext // FOr this we need Microsoft.EntityFrameworkCore;
    {
        private const string connectionString = "server=admivm\\SQLEXPRESS;database=PracticeDemo;user id=sa;password=pass@123";


        public EmployeeDbContext()
        {

        }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
                   : base(options) { }
        
        public DbSet<Emp> Emps { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        {
            modelBuilder.UseSqlServer(connectionString);
        }


        }
    }
