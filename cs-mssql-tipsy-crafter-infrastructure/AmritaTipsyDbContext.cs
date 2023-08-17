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
    public DbSet<Shipper> Shippers { get; set; } = null!;
    
    // Purchase
    public DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
    public DbSet<Brand> Brands { get; set; } = null!;
    public DbSet<Supplier> Suppliers { get; set; } = null!;
    public DbSet<SupplierContact> SupplierContacts { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;
    public DbSet<Delivery> Deliveries { get; set; } = null!;
    public DbSet<OrderItem> OrderItems { get; set; } = null!;
    public DbSet<Settlement> Settlements { get; set; } = null!;

    // Retail
    public DbSet<SaleStatus> SaleStatuses { get; set; } = null!;
    public DbSet<Store> Stores { get; set; } = null!;
    public DbSet<StoreContact> StoreContacts { get; set; } = null!;
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<CustomerContact> CustomerContacts { get; set; } = null!;
    public DbSet<Receipt> Receipts { get; set; } = null!;
    public DbSet<Payment> Payments { get; set; } = null!;

    // Stock
    public DbSet<Category> Categories { get; set; } = null!;
    public DbSet<ProductType> ProductTypes { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<ProductImage> ProductImages { get; set; } = null!;
    public DbSet<Inventory> Inventories { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(AmritaTipsyDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
        
        // Add last modified by to all entities - default to system no fk relation ship needed
    }
}