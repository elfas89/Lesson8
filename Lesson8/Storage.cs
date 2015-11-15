using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Storage
    {
        public int FirstArgument { get; set; }
        public int SecondArgument { get; set; }
    }

    public static class StorageExt
    {
        public static int SumArgs(this int x, int y)
        {
            return x + y;
        }

        public static int DivArgs(this int x, int y)
        {
            return x - y;
        }

    }


}
