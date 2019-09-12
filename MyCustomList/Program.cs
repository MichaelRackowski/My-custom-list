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
            List<int> name = new List<int>();
            name.Add(1);
            name.Add(3);
            name.Add(4);
            name.Add(9);
            name.Add(0);
            name.Add(3);
            name.Add(2);
            name.Add(7);
            name.Remove(7);       // only removes first instance of item
                                    // when reomving every item should shift into correct spot
            name.Add(0);
            name.Add(6);



        }
    }
}
