using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TaxiAppWebApi.Data
{

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TaxiAppDbContext>
    {
        public TaxiAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TaxiAppDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-5D75IDE\\SQLEXPRESS;Database=TaxiAppDb;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False;MultipleActiveResultSets=true;");

            return new TaxiAppDbContext(optionsBuilder.Options);
        }
    }

}
