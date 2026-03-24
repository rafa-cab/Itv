using System.Text.RegularExpressions;

public class ValidadorVehiculo
{
   
    private const string PatronMatricula = @"^[0-9]{4}[A-Z]{3}$";

    public bool EsMatriculaValida(string matricula)
    {
        
        if (string.IsNullOrWhiteSpace(matricula)) return false;
        
        return Regex.IsMatch(matricula.ToUpper(), PatronMatricula);
    }
    
    public bool EsCilindradaValida(int cilindrada)
    {
        return cilindrada > 0;
    }
}

