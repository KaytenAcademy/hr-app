using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HR.Authorization.Roles;
using HR.Authorization.Users;
using HR.MultiTenancy;
using HR.Models;

namespace HR.EntityFrameworkCore
{
    public class HRDbContext : AbpZeroDbContext<Tenant, Role, User, HRDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Departman> Departman { get; set; }
        public DbSet<EmployeeDepartmen> EmployeeDepartmen { get; set; }
       






        public HRDbContext(DbContextOptions<HRDbContext> options)
            : base(options)
        {



           
    }
       
    }
}
