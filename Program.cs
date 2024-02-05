using System.Globalization;
using System.Reflection;

namespace Ej1.Fechas;

class Program
{

    public static void Main(string[] args)
    {

        DateTime fechaActual = DateTime.Now;
        
       DateTimeFormatInfo dateTimeFormatInfo = CultureInfo.GetCultureInfo("es-SP").DateTimeFormat;
        Type tipo = dateTimeFormatInfo.GetType();
        PropertyInfo[] propiedadesFormatos = tipo.GetProperties();
        foreach (var propiedad in propiedadesFormatos)
        {
            if (propiedad.Name.Contains("Patern"))
            {
                string formatofecha = propiedad.GetValue(dateTimeFormatInfo, null).ToString();
                Console.WriteLine(propiedad.Name + ": " + formatofecha + " " +
                                  fechaActual.ToString(formatofecha));
            }
        }
        Console.WriteLine("-----------------");
        Console.WriteLine("Formato fecha-tiempo: " + fechaActual.ToString("s"));






    }



}