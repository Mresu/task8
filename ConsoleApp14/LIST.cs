using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class CustomList
    {
        
        static t[] list;
        public  CustomList()
        {
            list = Array.Empty<t>();
        }
        public void Add(t item)
        {
            Array.Resize(ref list, list.Length + 1);
            list[^1] = item;
        }

        public static t[] Find(t[] list, Predicate<t> method)
        {

            t[] findlist = new t[0];
            foreach (t t in list)
            {
                if (method(t))
                {
                    Array.Resize<t>(ref findlist, findlist.Length + 1);
                    findlist[^1] = t;
                    Console.WriteLine(t);
                    break;
                }
            }
            return findlist;

        }

        public static t[] FindAll(t[] list, Predicate<t> method)
        {
            t[] findlist = new t[0];

            foreach (t item in list)
            {
                if (method(item))
                {
                    Array.Resize<t>(ref findlist, findlist.Length + 1);
                    findlist[^1] = item;
                    Console.WriteLine(item);
                }

            }
            return findlist;

        }
    }
}
