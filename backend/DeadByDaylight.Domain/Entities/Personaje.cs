namespace DeadByDaylight.Domain.Entities;

public class Personaje
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public int RolId { get; set; }
    public Rol? Rol { get; set; }
    public double VelocidadMovimiento { get; set; }
    public int RadioTerror { get; set; }
    public double Altura { get; set; }
    public string Imagen { get; set; } = string.Empty;
}
