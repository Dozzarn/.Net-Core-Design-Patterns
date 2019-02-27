using System;

namespace AbstractFactory
{
     class WebPage : IPage
    {
        public WebPage()
        {
            Console.WriteLine("Web Page ");
        }
    }
}