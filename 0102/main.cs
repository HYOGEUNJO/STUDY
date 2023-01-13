using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0102
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Go();

            Sonata mySonata = new Sonata();
            mySonata.Go();


            Dog myDog = new Dog();
            myDog.Eat();
            myDog.Yelp();

            WhatIsCollection a = new WhatIsCollection();
            a.CollectionDesc();








        }
    }
}
