using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMA_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            try
            {
                Console.Write("Ingresa un numero entero: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("El valor del cuadrado es: " + Math.Pow(num,2));
            }
            catch(FormatException x)
            {
                
                Console.WriteLine(x.Message);
            }
            catch(OverflowException x)
            {
                Console.WriteLine(x.Message);
            }
            catch(NullReferenceException x)
            {
                Console.WriteLine(x.Message);
            }
            Console.WriteLine("Presiona enter para salir del programa");
            Console.ReadKey();
        }
    }
}
