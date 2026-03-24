namespace SistemaITV;

public class VehiculoServicio
{
    private readonly IVehiculoRepository _repository;
    private readonly VehiculoCache _cache;
    private readonly ValidadorVehiculo _validador;

    public VehiculoService(IVehiculoRepository repository, VehiculoCache cache)
    {
        _repository = repository;
        _cache = cache;
        _validador = new ValidadorVehiculo();
    }
    Public void RegistrarNuevoVehiculo(vehiculo V)
    {
        
    }    

}