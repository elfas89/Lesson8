using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Human
    {
        private string name { get; set; }
        public string Name;

        public Human() {}


        public string Children(string name, int? children)
        {
            switch (children)
            {
                case(null):
                    return name + ", нет данных о детях";
                   // break;
                case(0):
                    return name + ", нет детей";
                   // break;
                default:
                    return name + ", детей: " + children;
            }
        }
    }
}
