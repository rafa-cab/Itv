namespace Itv.Models;

public class Vehiculo<TipoCombustible>
{
    
        // Este es el ID interno que pide el ejercicio (no es la matrícula)
        public long Id { get; set; }

        // El formato debe ser 0000XXX
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        // La potencia del motor
        public int Cilindrada { get; set; }

        // Aquí guardaremos si es Diesel, Gasolina, etc.
        public TipoCombustible Combustible { get; set; }

        public string DniDueño { get; set; }

        // Esto sirve para el "Borrado Lógico" (si es true, el coche "no existe")
        public bool EstaBorrado { get; set; } = false;
    
        // ESTE ES EL CONSTRUCTOR
        public Vehiculo(long id, string matricula, string marca, string modelo, int cilindrada, TipoCombustible combustible, string dniDueño)
        {
                Id = id;
                Matricula = matricula;
                Marca = marca;
                Modelo = modelo;
                Cilindrada = cilindrada;
                Combustible = combustible;
                DniDueño = dniDueño;
                EstaBorrado = false; // Por defecto, un coche nuevo no está borrado
        }

        

        // Es buena práctica dejar también uno vacío por si usamos JSON más adelante
        public Vehiculo() { }

}