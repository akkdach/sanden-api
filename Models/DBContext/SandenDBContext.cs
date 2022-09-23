using Microsoft.EntityFrameworkCore;
namespace sanden_api.Models.DBContext
{
    public class SandenDBContext:DbContext
    {

        public DbSet<Users> Users { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<AspNetRoles> AspNetRoles { get; set; }
        public  SandenDBContext(DbContextOptions<SandenDBContext> options):base(options){

        }
    }
}

