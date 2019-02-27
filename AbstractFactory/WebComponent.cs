using System;

namespace AbstractFactory
{
     class WebComponent : IComponent
    {
        public WebComponent()
        {
            Console.WriteLine("Web component");

        }

    }
}