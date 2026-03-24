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
        if(!validador.EsMaticulaValida(v .Matricula))
            throw new Exception("la  matricula no valida o no cumple el formato correspondiente");
        if (!_validador.ESCilindradaValida(v.Cilindrada))
            throw new Exception("la cilindrada debe ser mayor a 0");
        _repository.Guardar(v);
        _cache.Añadir(v);
    }    

}