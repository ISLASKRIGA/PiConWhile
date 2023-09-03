using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiConWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PI = 0;
            double i = 1;
            while (Math.Abs((Math.PI - PI)) > .01) 
                {
                if(i % 2==0)
                {
                    PI = PI - (4 / ((i * 2) - 1));
                }
                else
                {
                    PI = PI + (4 / ((i * 2) - 1));
                }
                Console.WriteLine(PI);
                i++;
                }
            Console.WriteLine("El valor de pi con la iteracion {0} es {1}",i,PI);
            Console.ReadLine();
        }
    }
}
