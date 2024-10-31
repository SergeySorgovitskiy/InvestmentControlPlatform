using InvestmentControlPlatform.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using InvestmentControlPlatform;

public class InvestmentControlPlatformDbContext : DbContext
{
    public InvestmentControlPlatformDbContext(DbContextOptions<InvestmentControlPlatformDbContext> options)
        : base(options)
    {
    }

    public DbSet<Asset> Assets { get; set; }
    public DbSet<AssetPrice> AssetPrices { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Forecast> Forecasts { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<PortfolioAsset> PortfolioAssets { get; set; }
    public DbSet<TradingStrategy> TradingStrategies { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserSetting> UserSettings { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

   
}
