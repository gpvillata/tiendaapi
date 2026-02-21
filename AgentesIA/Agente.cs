namespace TiendaApi.AgentesIA;

public class Agente
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public List<string> Habilidades { get; set; }

    public Agente(string nombre, string descripcion, List<string> habilidades)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Habilidades = habilidades;
    }

    public string EjecutarTarea(string tarea)
    {
        return $"Agente {Nombre} está ejecutando la tarea: {tarea}";
        // Aquí podrías agregar lógica para que el agente realice acciones específicas según la tarea.
    }
}