using AutomaticInversionofControl.API.Contracts.Repositories;
using AutomaticInversionofControl.API.Entities;

namespace AutomaticInversionofControl.API.Concretes.Repositories;

public class ProductionRepository : BaseRepository<Production>, IProductionRepository
{
    public ProductionRepository() : base(new List<Production>
    {
        new Production
        {
            Id = Guid.Parse("AAE67099-0830-43D8-9B6A-2AF96784D16C"),
            Name = "Monster",
            Category = "Laptop",
            Price = 25550
        },
        new Production
        {
            Id = Guid.Parse("08C49C17-009D-4CED-BE8D-B3DB4A565C0B"),
            Name = "Asus",
            Category = "Laptop",
            Price = 32500
        },
        new Production
        {
            Id = Guid.Parse("E3EA54E6-A264-4DEE-A62F-0C9DAF97D656"),
            Name = "Iphone",
            Category = "Mobile Phone",
            Price = 77500
        },
        new Production
        {
            Id = Guid.Parse("5F438F7B-E6C2-4B2B-8E7B-CC9C36F61440"),
            Name = "Samsung",
            Category = "Mobile Phone",
            Price = 42500
        }
    })
    {
    }
}
