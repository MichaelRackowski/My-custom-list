using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> num = new CustomList<string>() { "Cook", "Cobb", "Bobby" };
            CustomList<string> numb = new CustomList<string>() { "Nelson", "Cobb", "Bobby" };
            CustomList<string> x = new CustomList<string>();

            x = num - numb;

            foreach  (string item in x)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

        }
    }
}
