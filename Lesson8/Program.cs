using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //int res = MyMath.Sum(5,7);
            //Console.WriteLine(res);

            //2
            //ConstAndReadOnly C1 = new ConstAndReadOnly(5);
            //Console.WriteLine(ConstAndReadOnly.E);
            //Console.WriteLine(C1.id);

            //ConstAndReadOnly.E = 34.3;
            //C1.id = 6;

            //3

            string[] waterElem = new string [2] {"H2","O"};
            Liq water = new Liq(0.6, waterElem);
            water.Info();

            string[] spirtElem = new string[3] { "C2", "H5", "O" };
            Liq spirt = new Liq(0.4, spirtElem);
            spirt.Info();

            Liq vodka = water + spirt;
            vodka.Info();
        
        
        
        
        
        }



    }
}
