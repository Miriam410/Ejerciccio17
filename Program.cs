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
            double numero1;
            double numero2;
            try
            {
                Console.WriteLine("Por favor, ingrese 2 némeros");
                numero1 = Convert.ToSingle(Console.ReadLine());
                numero2 = Convert.ToSingle(Console.ReadLine());

                double suma = numero1 + numero2;
                double resta = numero1 - numero2;
                double multiplicacion = numero1 * numero2;
                double division = numero1/numero2;
                double resto = numero1 % numero2;
                double Potencia = Math.Pow(numero1, numero2);
                Console.WriteLine(
                   $"La suma dió: {suma} \r\n" + $"La resta dió: {resta} \r\n" +
                   $"La multipliación dió: {multiplicacion} \r\n" +
                   $"La división dió: {division} \r\n" + $"El resto dió: {resto} \r\n" +
                   $"La potencia es: {Potencia} \r\n");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("No se puede dividir por 0", e);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hay un error en el ingreso",ex);
            }
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}