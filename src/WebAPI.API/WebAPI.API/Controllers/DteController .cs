using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Core.Interfaces.Services;

[Route("api/[controller]")]
[ApiController]
[AllowAnonymous]
public class DteController : ControllerBase
{
    private readonly IDteService _dteService;

    public DteController(IDteService dteService)
    {
        _dteService = dteService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllDtes()
    {
        var response = await _dteService.GetAllDtesAsync();
        return StatusCode(response.StatusCode, response);
    }

    [HttpGet("{codigoGeneracion}")]
    public async Task<IActionResult> GetDteByCodigoGeneracion(string codigoGeneracion)
    {
        var response = await _dteService.GetDteByCodigoGeneracionAsync(codigoGeneracion);
        return StatusCode(response.StatusCode, response);
    }
}
