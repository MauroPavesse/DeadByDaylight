﻿namespace DeadByDaylight.Domain.Entities;

public class Categoria
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;

    public ICollection<VentajaCategoria> VentajasCategorias { get; set; } = new List<VentajaCategoria>();
}
