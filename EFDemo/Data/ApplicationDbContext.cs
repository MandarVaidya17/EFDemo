using EFDemo.Models;
using Microsoft.EntityFrameworkCore;
namespace EFDemo.Data
{
    //applicationDbContext-child class ,DBcontex -parent class of EF
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
