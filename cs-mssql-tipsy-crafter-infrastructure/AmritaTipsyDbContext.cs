﻿namespace AmritaDb.Tipsy.Infrastructure;

using Domain.Purchase;
using Domain.Retail;
using Domain.Universal;

using Microsoft.EntityFrameworkCore;

public class AmritaTipsyDbContext : DbContext
{
    public AmritaTipsyDbContext(DbContextOptions<AmritaTipsyDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<ContactType> ContactTypes { get; set; } = null!;
    public DbSet<Country> Countries { get; set; } = null!;
    public DbSet<State> States { get; set; } = null!;
    public DbSet<PaymentMode> PaymentModes { get; set; } = null!;
    
    public DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
    
    public DbSet<SaleStatus> SaleStatuses { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(typeof(AmritaTipsyDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}