using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic<int> generyczna = new Generic<int>();
            Generic<string> generyczna2 = new Generic<string>();
            generyczna.wypisz(1, 2);
            generyczna2.wypisz("trzy", "cztery");
        }
    }
    public class Generic<T>
    {
        public void wypisz(T a, T b)
        {
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }
    }
}
