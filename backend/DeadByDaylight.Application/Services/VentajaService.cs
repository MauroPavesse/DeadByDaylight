using DeadByDaylight.Application.DtosShared;
using DeadByDaylight.Application.Interfaces;
using DeadByDaylight.Domain.Entities;
using DeadByDaylight.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace DeadByDaylight.Application.Services;

public class VentajaService : IVentajaService
{
    private readonly AppDbContext _context;

    public VentajaService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ResponseApi<Ventaja>> Search(SearchContract contract)
    {
        var query = _context.Ventajas
            .Include(x => x.VentajasCategorias)
            .AsQueryable();

        if (contract.Id > 0)
        {
            query = query.Where(x => x.Id == contract.Id);
        }
        else
        {
            var rolFiltro = contract.Filters.SingleOrDefault(x => x.Field == "RolId");
            if (rolFiltro != null)
            {
                query = query.Where(x => x.RolId == Convert.ToInt32(rolFiltro.Value));
            }

            var categoriasFiltro = contract.Filters.SingleOrDefault(x => x.Field == "CategoriasIds");
            if (categoriasFiltro != null)
            {
                query = query.Where(x => x.VentajasCategorias.Any(x => categoriasFiltro.Ids.Contains(x.CategoriaId)));
            }
        }

        var ventajas = await query.ToListAsync();
        return new ResponseApi<Ventaja>()
        {
            Data = ventajas,
            Success = true
        };
    }
}
