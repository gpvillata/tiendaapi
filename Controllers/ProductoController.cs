namespace TiendaApi.Controllers;
using TiendaApi.Domain.Models;
using TiendaApi.Application.Services;
using TiendaApi.AgentesIA;
using Microsoft.AspNetCore.Authentication;

public class ProductoController
{

    private readonly ProductoServices _productoServices; 
   
    public ProductoController(ProductoServices productoServices)
    {
        _productoServices = productoServices;
    }

    public String? GetProductos()
    {
        Agente _agente = new Agente("Agente de Productos", "Agente encargado de gestionar productos", new List<string> { "Obtener productos", "Agregar producto", "Actualizar producto", "Eliminar producto" });
       return _agente.EjecutarTarea("Obtener productos"); 
     
    }   
    
}