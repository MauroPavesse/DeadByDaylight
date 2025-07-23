namespace DeadByDaylight.Domain.Entities;

public class Rol
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;

    public ICollection<Personaje> Personajes { get; set; } = new List<Personaje>();
    public ICollection<Ventaja> Ventajas { get; set; } = new List<Ventaja>();
}
