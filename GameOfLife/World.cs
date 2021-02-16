using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class World
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine(a.toString());
            Console.ReadKey();
        }    
    }
}
