using System.Text.RegularExpressions;

public class ValidadorVehiculo
{
   
    private const string PatronMatricula = @"^[0-9]{4}[A-Z]{3}$";

    public bool EsMatriculaValida(string matricula)
    {
        // Si la matrícula está vacía, no es válida
        if (string.IsNullOrWhiteSpace(matricula)) return false;

        // Comparamos la matrícula con nuestro molde
        return Regex.IsMatch(matricula.ToUpper(), PatronMatricula);
    }
    
    public bool EsCilindradaValida(int cilindrada)
    {
        // Un coche no puede tener 0 o cilindrada negativa
        return cilindrada > 0;
    }
}

