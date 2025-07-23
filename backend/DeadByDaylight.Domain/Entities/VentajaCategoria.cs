namespace DeadByDaylight.Domain.Entities;

public class VentajaCategoria
{
    public int Id { get; set; }
    public int VentajaId { get; set; }
    public Ventaja Ventaja { get; set; } = null!;
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; } = null!;
}
