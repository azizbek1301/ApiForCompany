using ApiForCompany.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiForCompany.DataAcsess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Staff> Staff { get; set; }
        public virtual DbSet<EmployeeStaff> EmployeeStaff { get; set; }
    }
}
