using DeadByDaylight.Application.DtosShared;
using DeadByDaylight.Application.Interfaces;
using DeadByDaylight.Domain.Entities;
using DeadByDaylight.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace DeadByDaylight.Application.Services;

public class RolService : IRolService
{
    private AppDbContext _context;

    public RolService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<ResponseApi<Rol>> Search(SearchContract contract)
    {
        var query = _context.Roles.AsQueryable();

        if (contract.Id > 0)
        {
            query = query.Where(x => x.Id == contract.Id);
        }

        var roles = await query.ToListAsync();
        return new ResponseApi<Rol>()
        {
            Data = roles,
            Success = true
        };
    }
}
