using AutomaticInversionofControl.API.Contracts.Repositories;
using AutomaticInversionofControl.API.Contracts.Services;
using AutomaticInversionofControl.API.Entities;

namespace AutomaticInversionofControl.API.Concretes.Services;

public class ProductionService : IProductionService
{
    private readonly IProductionRepository _productionRepository;

    public ProductionService(IProductionRepository repository)
    {
        _productionRepository = repository;
    }

    public List<Production> GetProductions()
    {
        var products= _productionRepository.GetQueryable().ToList();
        return products;
    }

}
