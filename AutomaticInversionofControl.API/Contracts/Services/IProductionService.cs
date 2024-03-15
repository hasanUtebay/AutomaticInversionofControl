using AutomaticInversionofControl.API.Entities;

namespace AutomaticInversionofControl.API.Contracts.Services;

public interface IProductionService : IScopedService
{
    List<Production> GetProductions();
}
