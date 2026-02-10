using Microsoft.EntityFrameworkCore;

namespace WebApplicationprac.Models
{
    public class Appdb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=KRITIKKANDWAL-1;Initial catalog=db_testdb;integrated security=true;trustservercertificate=true");
        }

        public DbSet<RegisterModel> Register { get; set; } 
    }
}
