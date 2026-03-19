using System.Collections.Generic;

namespace SistemaITV;

public class VehiculoCache
{
    private readonly int _capacidad;
    private readonly Dictionary<long, LinkedListNode<Vehiculo>> _mapa;
    private readonly LinkedList<Vehiculo> _lista;

    public VehiculoCache(int capacidad)
    {
        _capacidad = capacidad;
        _mapa = new Dictionary<long, LinkedListNode<Vehiculo>>();
        _lista = new LinkedList<Vehiculo>();
        
    }
    public Vehiculo? Obtener(long id)
    {
        if (!_mapa.ContainsKey(id)) return null;

        // Si existe, lo movemos al principio (es el más reciente)
        var nodo = _mapa[id];
        _lista.Remove(nodo);
        _lista.AddFirst(nodo);

        return nodo.Value;
    }

}    
//obtener metodo caché// 

