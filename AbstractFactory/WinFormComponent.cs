using System;

namespace AbstractFactory
{
     class WinFormComponent : IComponent
    {
        public WinFormComponent()
        {
            Console.WriteLine("Win Component ");

        }
    }
}