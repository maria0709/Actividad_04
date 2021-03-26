using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_04
{
    class Program
    {
        static void Main(string[] args)

        //Permita el ingreso de frases, finalizando cuando el usuario ingresa “fin”.
        {
            string finalizar;

            do
            {
                Console.WriteLine("Ingrese una frase/s: ");
              
                finalizar = Console.ReadLine();
                Console.WriteLine(" \r ");

                Console.WriteLine("Para finalizar el programa, debe ingresar la palabra 'fin' ");
            } while (finalizar != "fin");
            
    }
    }
}
