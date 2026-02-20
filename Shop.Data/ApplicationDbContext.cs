using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Shop.Shared;

namespace Shop.Data;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<ShopItem> ShopItems => Set<ShopItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ShopItem>().HasData(
            new ShopItem { Id = 1, Name = "Apple", Price = 28.90, Shop = "Lidl", ActionTo = DateTime.Today.AddDays(2), IsBuy = false },
            new ShopItem { Id = 2, Name = "Banana", Price = 28.90, Shop = "Lidl", ActionTo = DateTime.Today.AddDays(2), IsBuy = false },
            new ShopItem { Id = 3, Name = "Orange", Price = 28.90, Shop = "Lidl", ActionTo = DateTime.Today.AddDays(2), IsBuy = false },
            new ShopItem { Id = 4, Name = "Milk", Price = 28.90, Shop = "Lidl", ActionTo = DateTime.Today.AddDays(2), IsBuy = false },
            new ShopItem { Id = 5, Name = "Bread", Price = 28.90, Shop = "Lidl", ActionTo = DateTime.Today.AddDays(2), IsBuy = false },
            new ShopItem { Id = 6, Name = "Butter", Price = 28.90, Shop = "Lidl", ActionTo = DateTime.Today.AddDays(2), IsBuy = false },
            new ShopItem { Id = 7, Name = "Cheese", Price = 28.90, Shop = "Lidl", ActionTo = DateTime.Today.AddDays(2), IsBuy = false },
            new ShopItem { Id = 8, Name = "Yogurt", Price = 28.90, Shop = "Lidl", ActionTo = DateTime.Today.AddDays(2), IsBuy = false },
            new ShopItem { Id = 9, Name = "Chicken", Price = 28.90, Shop = "Lidl", ActionTo = DateTime.Today.AddDays(2), IsBuy = false },
            new ShopItem { Id = 10, Name = "Rice", Price = 28.90, Shop = "Lidl", ActionTo = DateTime.Today.AddDays(2), IsBuy = false }
        );
    }
}

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlite("Data Source=shop.db");
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}