using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class OdemeFactory
    {

        public IOdeme OdemeTipiOlustur(OdemeTipi tip)
        {
            if (tip == OdemeTipi.KrediKarti)
            {
                return new KrediKarti();
            }else if (tip == OdemeTipi.BankaHavalesi)
            {
                return new BankaHavalesi();
            }
            else
            {
                return new KrediKarti();
            }
        }
    }
}
