// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese un mes:");
        string mes = Console.ReadLine();
        switch (mes)
        {
            case "enero":
                Console.WriteLine("Los mejores deseos para ti!");
                break;
            case "febrero":
                Console.WriteLine("Relájate y disfruta de los momentos!");
                break;
            case "marzo":
                Console.WriteLine("Todo cambio es una oportunidad para crecer!");
                break;
            case "abril":
                Console.WriteLine("Es momento de abrazar los nuevos retos!");
                break;
            case "mayo":
                Console.WriteLine("Activa tu paz interior para mantener el equilibrio!");
                break;
            case "junio":
                Console.WriteLine("Deja que la positividad te guíe hacia el camino del éxito!");
                break;
            case "julio":
                Console.WriteLine("Es momento de disfrutar de la vida!");
                break;
            case "agosto":
                Console.WriteLine("Aprovecha el día a día para ser la mejor versión de ti!");
                break;
            case "septiembre":
                Console.WriteLine("Es momento de afrontar los retos que nos acobardan!");
                break;
            case "octubre":
                Console.WriteLine("Todo lo que deseas está a tu alcance!");
                break;
            case "noviembre":
                Console.WriteLine("Es momento de tomar el control de tu vida!");
                break;
            case "diciembre":
                Console.WriteLine("Es momento de disfrutar de la vida!");
                break;
            default:
                Console.WriteLine("Mes no válido!");
                break;
        }
    }
}

