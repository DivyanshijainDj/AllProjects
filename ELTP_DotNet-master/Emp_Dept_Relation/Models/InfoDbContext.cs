using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Dept_Relation.Models
{
    public class InfoDbContext : DbContext
    {
        public InfoDbContext()
        {

        }

        public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DJAIN-LAP-0087\\MSSQLSERVER01;Initial Catalog=EmpDepartRelationship;Integrated Security=SSPI;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>()
                        .HasOne<Department>(e => e.department)
                        .WithMany(d => d.employees)
                        .IsRequired(true)
                        .HasForeignKey(e => e.DeptNo);

           
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
