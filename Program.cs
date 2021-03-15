using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)

        {        
            Console.WriteLine("Para saber seu imc, digite:");

            Console.WriteLine("Sua altura (M): ");
            double altura = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Seu peso (KG): ");
            double peso = Convert.ToDouble(Console.ReadLine()); 

            double IMC = Math.Pow(altura, 2); 
            double resultado = peso/IMC; 

            Console.WriteLine($"Seu IMC é: {resultado:N1} kg/m²");

        }
    }
}
