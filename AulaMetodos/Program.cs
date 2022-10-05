using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Variaveis obVAR = new Variaveis();

            Console.WriteLine("Digite o primeiro numero");
            obVAR.num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            obVAR.num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero");
            obVAR.num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("O resultado é: " + obVAR.Calculo(obVAR.num1 ,obVAR.num2 ,obVAR.num3));
        }
    }
}
