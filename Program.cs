
using TiendaApi.Domain.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();



app.MapGet("/", () =>
{
  return "Bienvenidos a Tienda Online Api";

}).WithName("GetWelcomeMessage").WithTags("Welcome");

// endpoints de productos

app.MapGet("/productos",()=>{

    var productos = new List<Producto>
    {
      new Producto
      {
        Id = 1,
        Nombre = "Producto 1",
        Precio = 10.99m,
        Descripcion = "Descripción del producto 1",
        Categoria = "Categoría A",
        Stock = 100,
        FechaCreacion = DateOnly.FromDateTime(DateTime.Now)
      },
      new Producto 
      {
        Id = 2,
        Nombre = "Producto 2",
        Precio = 19.99m,
        Descripcion = "Descripción del producto 2",
        Categoria = "Categoría B",
        Stock = 50,
        FechaCreacion = DateOnly.FromDateTime(DateTime.Now)
      },
        new Producto
        {
          Id = 3,
          Nombre = "Producto 3",
          Precio = 5.99m,
          Descripcion = "Descripción del producto 3",
          Categoria = "Categoría C",
          Stock = 200,
          FechaCreacion = DateOnly.FromDateTime(DateTime.Now)
        }
    };
    return productos;
    
}).WithName("GetProductos").WithTags("Productos");
app.Run();




