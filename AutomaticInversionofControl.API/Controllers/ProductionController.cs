using AutomaticInversionofControl.API.Contracts.Services;
using AutomaticInversionofControl.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AutomaticInversionofControl.API.Controllers;
[ApiController]
[Route("[controller]/api/[action]")]
public class ProductionController : ControllerBase
{
    private readonly IProductionService _productionService;
    public ProductionController(IProductionService productionService)
    {
        _productionService = productionService;
    }

    [HttpGet]
    public   List<Production> GetProductions()
    {
       return  _productionService.GetProductions();
    }
}
