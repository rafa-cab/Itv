using System.Collections.Generic;

namespace SistemaITV;

public interface IVehiculoRepository
{
   
    IEnumerable<Vehiculo> ObtenerTodos(int pagina, int tamañoPagina);
    
    Vehiculo? ObtenerPorId(long id);
    
    
    void Guardar(Vehiculo vehiculo);
    void Actualizar(Vehiculo vehiculo);
    
    void BorrarLogico(long id);
}
