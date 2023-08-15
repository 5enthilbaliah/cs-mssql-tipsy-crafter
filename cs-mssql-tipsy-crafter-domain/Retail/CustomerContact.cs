namespace AmritaDb.Tipsy.Domain.Retail;

using Universal;

public class CustomerContact
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Detail { get; set; } = null!;
    public bool IsPrimary { get; set; }
    public string CustomerId { get; set; } = null!;
    public string ContactTypeId { get; set; } = null!;
    
    public Customer Customer { get; set; } = null!;
    public ContactType ContactType { get; set; } = null!;
}