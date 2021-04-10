using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciccio17
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 17. Solicite el ingreso de dos nùmeros al usuario y presente la suma, 
            la resta, la multiplicación, la división, el resto, el primer nÚmero elevado
            a la potencia del segundo. */
            string numero1;
            double Salida1;
            string numero2;
            double Salida2;
            bool Flag = false;

            do
            {
                Console.WriteLine("Por favor, ingrese 2 némeros");
                numero1 = Console.ReadLine();
                numero2 = Console.ReadLine();
                if (!double.TryParse(numero1, out Salida1))
                {
                    Console.WriteLine("Ingrese un valor numérico");
                }
                if (!double.TryParse(numero2, out Salida2))
                {
                    Console.WriteLine("Ingrese un valor numérico");
                }
                else if (Salida2 == 0)
                {
                    Console.WriteLine("No puede ingresar un cero");
                }
                else
                {
                    Flag = true;
                    double suma = Salida1+ Salida2;
                    double resta = Salida1 - Salida2;
                    double multiplicacion = Salida1 * Salida2;
                    double division = Salida1 / Salida2;
                    double resto = Salida1 % Salida2;
                    double Potencia = Math.Pow(Salida1,Salida2);
                    Console.WriteLine(
                       $"La suma dió: {suma} \r\n" + $"La resta dió: {resta} \r\n" +
                       $"La multipliación dió: {multiplicacion} \r\n" +
                       $"La división dió: {division} \r\n" + $"El resto dió: {resto} \r\n" +
                       $"La potencia es: {Potencia} \r\n");
                    Console.WriteLine("Presione una tecla para salir");
                }
            } while (Flag==false);
            Console.ReadKey();
        }
    }
}