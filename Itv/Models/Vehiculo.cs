namespace SistemaITV;

public class Vehiculo 
{
    public long Id { get; set; }
    public string Matricula { get; set; }
    public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Cilindrada { get; set; }
        
        public Tipocombustible Combustible { get; set; }

        public string DniDueño { get; set; }
        
        public bool EstaBorrado { get; set; } = false;
        
        public Vehiculo(long id, string matricula, string marca, string modelo, int cilindrada, Tipocombustible combustible, string dniDueño)
        {
                Id = id;
                Matricula = matricula;
                Marca = marca;
                Modelo = modelo;
                Cilindrada = cilindrada;
                Combustible = combustible;
                DniDueño = dniDueño;
                EstaBorrado = false; 
                
        public Vehiculo() { }
}


