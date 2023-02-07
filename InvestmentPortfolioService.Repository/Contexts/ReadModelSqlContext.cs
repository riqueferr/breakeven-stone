using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace InvestmentPortfolioService.Repository.Contexts;

public class ReadModelSqlContext : DbContext
{
    public ReadModelSqlContext(DbContextOptions<ReadModelSqlContext> options) : base(options)
    {
        this.Database.EnsureCreated();
    }
    
    public DbSet<AccountBanking> AccountBanking { get; set; }
}

