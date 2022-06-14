using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Hello");
            list.Add(45);
            list.Remove("Hello");
            list.RemoveAt(0);
            list.Insert(1, 15);
            list.Insert(0, 5);
            string name = list[1].ToString();
            int a = Convert.ToInt32(list[0]);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
