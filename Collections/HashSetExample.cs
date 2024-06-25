using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Collections
{
    public static class HashSetExample
    {
        class Car
        {
            public string Color="";
            public int Price;
        }
        public static void Run()
        {
            HashSet<Car> set = new HashSet<Car>();
            Car honda=new();
            honda.Color="Red";
            honda.Price=300;
            set.Add(honda);
            Car sameHonda=new();
            sameHonda.Color="Red";
            sameHonda.Price=300;
            set.Add(sameHonda);
            
            Console.WriteLine(set.Count);

            foreach(object obj in set)
            {
                Console.WriteLine(obj.ToString());
            }


        }
    }
}