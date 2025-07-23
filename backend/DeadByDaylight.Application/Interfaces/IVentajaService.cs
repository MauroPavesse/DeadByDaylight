using DeadByDaylight.Application.DtosShared;
using DeadByDaylight.Domain.Entities;

namespace DeadByDaylight.Application.Interfaces;

public interface IVentajaService
{
    Task<ResponseApi<Ventaja>> Search(SearchContract contract);
}
