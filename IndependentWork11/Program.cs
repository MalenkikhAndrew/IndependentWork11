using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести значения k,b для линейного уравнения 0=kx+b");
            Console.Write("k=");
            double k=Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b=Convert.ToDouble(Console.ReadLine());

            LinUr linur=new LinUr(k,b);
            Console.WriteLine(linur.Root());
            Console.ReadKey();

        }
    }
}
