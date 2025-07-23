using DeadByDaylight.Application.DtosShared;
using DeadByDaylight.Domain.Entities;

namespace DeadByDaylight.Application.Interfaces;

public interface IRolService
{
    public Task<ResponseApi<Rol>> Search(SearchContract contract);
}
