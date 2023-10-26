public class Customer
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required ContactInfo Contact { get; set; }
}

public class ContactInfo
{
    public PhoneNumber? PrimaryPhone { get; set; }
    public required Address PrimaryAddress { get; set; }
    public List<PhoneNumber> PhoneNumbers { get; } = new();
    public List<Address> Addresses { get; } = new();
}

public class Address
{
    public required string Line1 { get; set; }
    public string? Line2 { get; set; }
    public string? Line3 { get; set; }
    public required string Postcode { get; set; }
    public required string City { get; set; }
    public required Country Country { get; set; }
    public PhoneNumber? PrimaryPhone { get; set; }
}

public class PhoneNumber
{
    public required Country Country { get; set; }
    public required string Number { get; set; }
}

public class Country
{
    public required string FullName { get; set; }
    public required string ShortName { get; set; }
    public required int CountryCode { get; set; }
}
