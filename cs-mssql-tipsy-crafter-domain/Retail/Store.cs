namespace AmritaDb.Tipsy.Domain.Retail;

using Purchase;

using Stock;

public class Store
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? WebsiteUrl { get; set; }
    public string Address1 { get; set; } = null!;
    public string? Address2 { get; set; }
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
    public bool IsWarehouse { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public string PreferredCurrency { get; set; } = null!;

    public ICollection<StoreContact> Contacts => null!;
    public ICollection<Order> Orders => null!;
    public ICollection<Inventory> Inventories => null!;
    public ICollection<Receipt> Receipts => null!;
}