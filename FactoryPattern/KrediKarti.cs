using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class KrediKarti : IOdeme
    {
        public bool OdemeYap()
        {
            return KrediKartiIleOdeme();
        }

        private bool KrediKartiIleOdeme()
        {
            Console.WriteLine("Kredi Kartıyla Odeme Yapıldı");
            return true;
        }
    }
}
