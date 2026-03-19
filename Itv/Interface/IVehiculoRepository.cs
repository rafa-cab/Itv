using System.Collections.Generic;

namespace SistemaITV;

public interface IVehiculoRepository
{
    // Listado paginado (para no saturar la memoria)
    IEnumerable<Vehiculo> ObtenerTodos(int pagina, int tamañoPagina);
    
    // Buscar uno solo
    Vehiculo? ObtenerPorId(long id);
    
    // Guardar y Actualizar
    void Guardar(Vehiculo vehiculo);
    void Actualizar(Vehiculo vehiculo);
    
    // Borrado Lógico (el requisito principal)
    void BorrarLogico(long id);
}
