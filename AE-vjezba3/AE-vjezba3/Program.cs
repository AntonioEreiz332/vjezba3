using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AE_vjezba3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 4; double b = 10; double c = 4; double d = 5;
            double x = (Math.Pow(a,2)+ Math.Pow(b, 2)+ Math.Pow(c, 2)+Math.Pow(d, 2))
                / (Math.Pow(a+b, 2)+ Math.Pow(c+d, 2));
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
