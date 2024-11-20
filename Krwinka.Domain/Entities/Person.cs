namespace Krwinka.Domain.Entities;

public class Person
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Pesel { get; set; } = default!;
    public string Phone { get; set; } = default!;
    public string Email { get; set; } = default!;
    public List<Order> Orders { get; set; } = new();

}
