using ApilPortfolio.Models.AdminModels;
using Microsoft.EntityFrameworkCore;
using ApilPortfolio.Models;

namespace ApilPortfolio.Data
{
    public class PortfolioDbContext: DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options): base(options) { }

        public DbSet<ProjectModel> Projects { get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<LoginModel> LoginModel { get; set; }


    }
}
