using System.Collections.Generic;
using System.Linq;


namespace SistemaITV;

public class VehiculoRepositoryMemoria : IVehiculoRepository
{
    // Nuestra "Base de Datos" es simplemente una lista de fichas
    private readonly List<Vehiculo> _vehiculos = new List<Vehiculo>();

    public void Guardar(Vehiculo vehiculo)
    {
        _vehiculos.Add(vehiculo);
    }

    public IEnumerable<Vehiculo> ObtenerTodos(int pagina, int tamañoPagina)
    {
        return _vehiculos
            .Where(v => !v.EstaBorrado) // <--- ¡AQUÍ ESTÁ EL BORRADO LÓGICO!
            .Skip((pagina - 1) * tamañoPagina) // Salta los de las páginas anteriores
            .Take(tamañoPagina); // Coge solo los que caben en esta página
    }

    public Vehiculo? ObtenerPorId(long id)
    {
        // Buscamos el que coincida con el ID y que no esté marcado como borrado
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
            // NO usamos .Remove(). Simplemente le ponemos el sello de borrado.
            vehiculo.EstaBorrado = true; 
        }
    }
}