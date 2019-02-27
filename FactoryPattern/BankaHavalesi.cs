using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class BankaHavalesi : IOdeme
    {
        public bool OdemeYap()
        {
            return BankaHavalesiKontrol();
        }

        private bool BankaHavalesiKontrol()
        {
            Console.Write("Havale Kontrol");
            return true;
        }
    }
}
