using DeadByDaylight.Application.DtosShared;
using DeadByDaylight.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DeadByDaylight.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VentajasController : ControllerBase
{
    private readonly IVentajaService _ventajaService;

    public VentajasController(IVentajaService ventajaService)
    {
        _ventajaService = ventajaService;
    }

    [HttpPost("buscar")]
    [AllowAnonymous]
    public async Task<IActionResult> Buscar([FromBody] SearchContract contract)
    {
        var response = await _ventajaService.Search(contract);
        return Ok(response);
    }
}
