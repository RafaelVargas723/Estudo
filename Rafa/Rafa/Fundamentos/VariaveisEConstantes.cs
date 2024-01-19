using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafa.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area de circunferencia 
            double area = 4.5;
            const double PI = 3.14;

            area = 5.5;
            // PI = 3.1415

            area = PI * area * area;
            Console.WriteLine(area);
            Console.WriteLine("Àrea é " + area + 1000);

            // tipos interno

            byte idade = 21;
            Console.WriteLine("Idade " + idade);
        }
    }
}
