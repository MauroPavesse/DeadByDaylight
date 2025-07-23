using DeadByDaylight.Application.DtosShared;
using DeadByDaylight.Domain.Entities;

namespace DeadByDaylight.Application.Interfaces;

public interface ICategoriaService
{
    public Task<ResponseApi<Categoria>> Search(SearchContract contract);
}
