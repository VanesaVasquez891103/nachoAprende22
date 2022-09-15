using System;
using nachoAprende;

namespace nachoAprende
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite los numero: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2= int.Parse(Console.ReadLine());

            int resultado = (nachoAprende.clslib.suma(num1,num2));

            Console.WriteLine("El resultado es: "+resultado);
         

         
        }
    }
}
