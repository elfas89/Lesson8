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

            //string[] waterElem = new string [2] {"H2","O"};
            //Liq water = new Liq(0.6, waterElem);
            //water.Info();

            //string[] spirtElem = new string[3] { "C2", "H5", "O" };
            //Liq spirt = new Liq(0.4, spirtElem);
            //spirt.Info();

            //Liq vodka = water + spirt;
            //vodka.Info();
            
            //// на троих
            //Liq[] parts = vodka / 3;
            //for (int i = 0; i < parts.Length; i++)
            //{
            //    parts[i].Info();
            //}
        

            //4
            //Storage stor = new Storage();
            //stor.FirstArgument = 2;
            //stor.SecondArgument = 5;
            //int sum = StorageExt.SumArgs(stor.FirstArgument, stor.SecondArgument);
            //Console.WriteLine(sum);
            //int div = StorageExt.DivArgs(stor.FirstArgument, stor.SecondArgument);
            //Console.WriteLine(div);

            //5
            //CommonClass<string> comm = new CommonClass<string>("common class name");
            //Console.WriteLine(comm.ToString());
            //Console.WriteLine(comm.Name);

            //CommonClass<int> commI = new CommonClass<int>(56);
            //Console.WriteLine(commI.Name);

            //CommonClass<object> commO = new CommonClass<object>(56);
            //Console.WriteLine(commI.Name);

            //Bank<string> bank1 = new Bank<string>();
            //Bank<string>.session = "45245";
            //Bank<int> bank2 = new Bank<int>();
            //Bank<int>.session = 5452;
            //Console.WriteLine(Bank<string>.session);
            //Console.WriteLine(Bank<int>.session); 


            //6
            Human Man = new Human();
            Console.WriteLine(Man.Children("Василий Иваныч", null));



        
        
        }



    }
}
