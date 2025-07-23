namespace DeadByDaylight.Domain.Entities;

public class Ventaja
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public int RolId { get; set; }
    public Rol? Rol { get; set; }
    public string Imagen { get; set; } = string.Empty;

    public ICollection<VentajaCategoria> VentajasCategorias { get; set; } = new List<VentajaCategoria>();
}
