using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Deneme
    {
        private static Deneme _finder;

        private static object lockObject = new object();

        private Deneme()
        {

        }
        public static Deneme Instance()
        {
            if (_finder == null)
            {
                lock (lockObject)
                {
                    if (_finder == null)
                    {
                        Console.WriteLine("yeni");
                        _finder = new Deneme();
                    }
                }
            }
            else
            {
                Console.WriteLine("eski");

            }
            return _finder;
        }

    }
}
