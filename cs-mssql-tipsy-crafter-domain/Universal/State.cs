namespace AmritaDb.Tipsy.Domain.Universal;

public class State
{
    public string Id { get; set; } = null!;
    public string CountryId { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Code { get; set; } = null!;
    
    public Country Country { get; set; } = null!;
}