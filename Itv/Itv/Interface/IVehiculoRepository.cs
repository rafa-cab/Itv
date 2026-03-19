using Itv.Models;
using Itv.Vehiculo;

namespace Itv.Interface;

public interface IVehiculoRepository
{
    // Obtener todos los vehículos con paginación (para no cargar 1 millón de golpe)
    IEnumerable<Vehiculo> ObtenerTodos(int pagina, int tamañoPagina);

   

    // Guardar un nuevo vehículo
    void Guardar(Vehiculo<> vehiculo);

    // Actualizar uno existente
    void Actualizar(Vehiculo<> vehiculo);

    // Borrado Lógico (solo marcarlo como borrado)
    void BorrarLogico(long id);
}
