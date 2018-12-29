using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HR.Authorization.Roles;
using HR.Authorization.Users;
using HR.MultiTenancy;

namespace HR.EntityFrameworkCore
{
    public class HRDbContext : AbpZeroDbContext<Tenant, Role, User, HRDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HRDbContext(DbContextOptions<HRDbContext> options)
            : base(options)
        {
        }
    }
}
