namespace SistemaITV;

public class Vehiculo 
{
    public long Id { get; set; }
    public string Matricula { get; set; }
    public string Marca { get; set; }
        public string Modelo { get; set; }

        // La potencia del motor
        public int Cilindrada { get; set; }

        // Aquí guardaremos si es Diesel, Gasolina, etc.
        public Tipocombustible Combustible { get; set; }

        public string DniDueño { get; set; }

        // Esto sirve para el "Borrado Lógico" (si es true, el coche "no existe")
        public bool EstaBorrado { get; set; } = false;
    
        // ESTE ES EL CONSTRUCTOR
        public Vehiculo(long id, string matricula, string marca, string modelo, int cilindrada, Tipocombustible combustible, string dniDueño)
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


