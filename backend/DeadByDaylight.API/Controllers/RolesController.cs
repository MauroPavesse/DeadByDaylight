using DeadByDaylight.Application.DtosShared;
using DeadByDaylight.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DeadByDaylight.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RolesController : ControllerBase
{
    private readonly IRolService _rolService;

    public RolesController(IRolService rolService)
    {
        _rolService = rolService;
    }

    [HttpPost("buscar")]
    [AllowAnonymous]
    public async Task<IActionResult> Buscar([FromBody] SearchContract contract)
    {
        var response = await _rolService.Search(contract);
        return Ok(response);
    }
}