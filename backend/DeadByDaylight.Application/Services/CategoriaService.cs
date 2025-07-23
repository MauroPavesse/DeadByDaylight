using DeadByDaylight.Application.DtosShared;
using DeadByDaylight.Application.Interfaces;
using DeadByDaylight.Domain.Entities;
using DeadByDaylight.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace DeadByDaylight.Application.Services;

public class CategoriaService : ICategoriaService
{
    private AppDbContext _context;

    public CategoriaService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ResponseApi<Categoria>> Search(SearchContract contract)
    {
        var query = _context.Categorias.AsQueryable();

        if(contract.Id > 0)
        {
            query = query.Where(x => x.Id == contract.Id);
        }

        var categorias = await query.ToListAsync();
        return new ResponseApi<Categoria>()
        {
            Data = categorias,
            Success = true
        };
    }
}
