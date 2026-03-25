using system.text.Json;
using System.IO;


namespace SistemaITV.Repository;


public class VehiculoRepositoryJson : IVehiculoRepository
{
    private readonly string _path = "vehiculos.json";

    private List<Vehiculo> LeerDeArchivo()
    {
        if (!File.Exists(_path)) return new List<Vehiculo>();
        string json = File.ReadAllText(_path);
        return JsonSerializer.Deserialize<List<Vehiculo>>(json) ?? new List<Vehiculo>();
    }

    private void GuardarEnArchivo(List<Vehiculo> lista)
    {
        string json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_path, json);
    }

    public void Guardar(Vehiculo vehiculo)
    {
        var lista = LeerDeArchivo();
        lista.Add(vehiculo);
        GuardarEnArchivo(lista);
    }

    public IEnumerable<Vehiculo> ObtenerTodos(int pagina, int tamañoPagina)
    {
        return LeerDeArchivo()
            .Where(v => !v.EstaBorrado)
            .Skip((pagina - 1) * tamañoPagina)
            .Take(tamañoPagina);
    }

    public void BorrarLogico(long id)
    {
        var lista = LeerDeArchivo();
        var v = lista.FirstOrDefault(x => x.Id == id);
        if (v != null)
        {
            v.EstaBorrado = true;
            GuardarEnArchivo(lista);
        }
    }

   public Vehiculo? ObtenerPorId(long id) => LeerDeArchivo().FirstOrDefault(v => v.Id == id && !v.EstaBorrado);
    
    public void Actualizar(Vehiculo vehiculo) {  }
    

}