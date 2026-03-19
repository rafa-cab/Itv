namespace DefaultNamespace;

public class Vehiculo
{

    public class Vehiculo
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
        public string TipoCombustible { get; set; }

        public string DniDueño { get; set; }

        // Esto sirve para el "Borrado Lógico" (si es true, el coche "no existe")
        public bool EstaBorrado { get; set; } = false;
    }

}