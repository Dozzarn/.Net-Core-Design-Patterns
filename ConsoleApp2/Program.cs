using System;
using System.Collections.Generic;
using AbstractFactory;
using FactoryPattern;
using Singleton;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton
            Deneme deneme = Deneme.Instance();
            Deneme deneme2 = Deneme.Instance();

            //factory 
            OdemeFactory factory = new OdemeFactory();
            IOdeme tip =factory.OdemeTipiOlustur(0);
            tip.OdemeYap();


            //Abstract Fac
            AbstractScreenGenerate abstractScreen = new GenerateWinForm();
            abstractScreen.CreateComponent();
            abstractScreen.CreatePage();
        }
    }
}
