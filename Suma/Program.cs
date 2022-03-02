using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 8;
            double num2 = 4.5;
            double resultado;

            //Variable string 
            string saludo = "Hola";
            string nombre = "Hugo";
            //Sumamos las dos variables
            //resultado = num1 + num2;

            //Sumando una variable y un dato puesto explicitamente
            resultado = num1 + 22;
            //Console.WriteLine(resultado);


            //Sumando o concatenando dos cadenas almacenadas en variables 
            Console.WriteLine(saludo + " " + nombre + " " + "Como estas?");
            Console.ReadKey();
        }
    }
}
