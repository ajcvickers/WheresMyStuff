public class SampleData
{
    public static Customer CreateSampleCustomer()
        => new()
        {
            Name = "Willow",
            Contact = new()
            {
                PrimaryAddress = new()
                {
                    Line1 = "Baking Gate",
                    City = "Walpole St Peter",
                    Postcode = "PE157ZN",
                    Country = new() { FullName = "United Kingdom", ShortName = "UK", CountryCode = 44 },
                    PrimaryPhone = new()
                    {
                        Country = new() { FullName = "United Kingdom", ShortName = "UK", CountryCode = 44 },
                        Number = "(1234) 1234-333"
                    }
                },
                PrimaryPhone = new()
                {
                    Country = new() { FullName = "United Kingdom", ShortName = "UK", CountryCode = 44 },
                    Number = "(1234) 1234-333"
                },
                Addresses =
                {
                    new()
                    {
                        Line1 = "Baking Gate",
                        City = "Walpole St Peter",
                        Postcode = "PE157ZN",
                        Country = new() { FullName = "United Kingdom", ShortName = "UK", CountryCode = 44 },
                        PrimaryPhone = new()
                        {
                            Country = new() { FullName = "United Kingdom", ShortName = "UK", CountryCode = 44 },
                            Number = "(1234) 1234-333"
                        }
                    },
                    new()
                    {
                        Line1 = "Baking Gate",
                        City = "Walpole St Peter",
                        Postcode = "PE157ZN",
                        Country = new() { FullName = "United Kingdom", ShortName = "UK", CountryCode = 44 },
                        PrimaryPhone = new()
                        {
                            Country = new() { FullName = "United Kingdom", ShortName = "UK", CountryCode = 44 },
                            Number = "(1234) 1234-333"
                        }
                    },
                },
                PhoneNumbers =
                {
                    new()
                    {
                        Country = new() { FullName = "United Kingdom", ShortName = "UK", CountryCode = 44 },
                        Number = "(1234) 1234-333"
                    },
                    new()
                    {
                        Country = new() { FullName = "United Kingdom", ShortName = "UK", CountryCode = 44 },
                        Number = "(1234) 1234-333"
                    }
                }
            }
        };
}