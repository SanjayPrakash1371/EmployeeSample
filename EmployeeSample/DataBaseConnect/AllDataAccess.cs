using EmployeeSample.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeSample.DataBaseConnect
{
    public class AllDataAccess:DbContext
    {

        public AllDataAccess(DbContextOptions<AllDataAccess> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<EmployeeRoles> EmployeesRoles { get; set; }

        public DbSet<UsernamePassword> usernamepassword { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasIndex(p => new { p.EmployeeId})
                .IsUnique(true);
        }

    }
}
