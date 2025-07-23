using DeadByDaylight.Application.DtosShared;
using DeadByDaylight.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DeadByDaylight.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriasController : ControllerBase
{
    private readonly ICategoriaService _categoriaService;

    public CategoriasController(ICategoriaService categoriaService)
    {
        _categoriaService = categoriaService;
    }

    [HttpPost("buscar")]
    [AllowAnonymous]
    public async Task<IActionResult> Buscar([FromBody] SearchContract contract)
    {
        var response = await _categoriaService.Search(contract);
        return Ok(response);
    }
}
