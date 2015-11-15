using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class CommonClass <T>  where T : new()
    {
        private T name {get; set; }
        public T Name;
        public CommonClass(T x) {
            Name = x;
        }
        
    }

    class Bank<T>
    {
        public static T session;
        public Bank()
        {
        }
    }

}
