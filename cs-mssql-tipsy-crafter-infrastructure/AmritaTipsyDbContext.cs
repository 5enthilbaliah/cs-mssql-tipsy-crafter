namespace AmritaDb.Tipsy.Infrastructure;

using Domain.Purchase;
using Domain.Retail;
using Domain.Stock;
using Domain.Universal;

using Microsoft.EntityFrameworkCore;

public class AmritaTipsyDbContext : DbContext
{
    public AmritaTipsyDbContext(DbContextOptions<AmritaTipsyDbContext> options)
        : base(options)
    {
    }
    
    // Universal
    public DbSet<ContactType> ContactTypes { get; set; } = null!;
    public DbSet<Country> Countries { get; set; } = null!;
    public DbSet<State> States { get; set; } = null!;
    public DbSet<PaymentMode> PaymentModes { get; set; } = null!;
    
    // Purchase
    public DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
    public DbSet<Brand> Brands { get; set; } = null!;

    // Retail
    public DbSet<SaleStatus> SaleStatuses { get; set; } = null!;
    
    // Stock
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<ProductType> ProductTypes { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<ProductImage> ProductImages { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(AmritaTipsyDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}