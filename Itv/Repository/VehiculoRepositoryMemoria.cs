using System.Collections.Generic;
using System.Linq;


namespace SistemaITV;

public class VehiculoRepositoryMemoria : IVehiculoRepository
{
  
    private readonly List<Vehiculo> _vehiculos = new List<Vehiculo>();

    public void Guardar(Vehiculo vehiculo)
    {
        _vehiculos.Add(vehiculo);
    }

    public IEnumerable<Vehiculo> ObtenerTodos(int pagina, int tamañoPagina)
    {
        return _vehiculos
            .Where(v => !v.EstaBorrado)
            .Skip((pagina - 1) * tamañoPagina) 
            .Take(tamañoPagina);
    }

    public Vehiculo? ObtenerPorId(long id)
    {
        
        return _vehiculos.FirstOrDefault(v => v.Id == id && !v.EstaBorrado);
    }

    public void Actualizar(Vehiculo vehiculo)
    {
        var index = _vehiculos.FindIndex(v => v.Id == vehiculo.Id);
        if (index != -1)
        {
            _vehiculos[index] = vehiculo;
        }
    }

    public void BorrarLogico(long id)
    {
        var vehiculo = _vehiculos.FirstOrDefault(v => v.Id == id);
        if (vehiculo != null)
        {
            vehiculo.EstaBorrado = true; 
        }
    }
}