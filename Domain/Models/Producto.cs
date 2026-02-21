namespace TiendaApi.Domain.Models;

class Producto 
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public decimal Precio { get; set; }
    public string? Descripcion { get; set; }    
    public string? Categoria { get; set; }
    public int Stock { get; set; }
    public DateOnly FechaCreacion { get; set; }

    
}
 