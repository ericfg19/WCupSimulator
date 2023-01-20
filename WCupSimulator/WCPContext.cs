using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace WCupSimulator
{
    public class WCPContext : DbContext
    {
        public WCPContext(DbContextOptions options) 
            : base(options) 
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("SrvConn"));
        }

        public DbSet<Team> Teams { get; set; }
    }
}
