using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton uniqueInstance = new Singleton();
        public int SingletonData = 0;

        private Singleton()
        {
            Console.WriteLine("The constructor has been called.");
        }

        public static Singleton GetInstance()
        {
            return uniqueInstance;
        }

        public void print()
        {
            Console.WriteLine($"SingletonData: {SingletonData}");
        }
    }
}
