using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_if
{
    class Program
    {
        static void Main(string[] args)
        {
            double sal, inss, pen;

            Console.WriteLine("Digite o salário do funcionário.");
            sal = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o % de INSS.");
            inss = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o % de pensão.");
            pen = double.Parse(Console.ReadLine());

            sal -= sal*inss/100;
            sal -= sal*pen/100;

            Console.WriteLine("Salário final: "+sal.ToString("C"));

            Console.ReadKey();








        }
    }
}
