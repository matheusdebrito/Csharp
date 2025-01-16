São métodos que estendem a funcionalidade de um tipo, sem precisar alterar o código fonte deste tipo, nem herdar desse tipo.

Como fazer um extension method?
 - Criar uma classe estática
 - Na classe, criar um método estático
 - O primeiro parâmetro do método deverá ter o prefixo this, seguido da declaração de um parâmetro do tipo que se deseja estender. Esta será uma referência para o próprio objeto.

código da classe
 ````c#
using System;
using System.Globalization;

namespace Course.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now - thisObj;

            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + "hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + "days";
            }
        }
    }
}
````

código principal
````c#
using Course.Extensions;
internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime());
    }
}
````