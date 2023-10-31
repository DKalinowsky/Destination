using System;
using System.Collections.Generic;
using System.Text;

namespace Marekv2
{
    public class WorldMarket
    {
        public static int GetInitialPricePerKg()
        {
            Random random = new Random();
            int poczatek = 100;
            int koniec = 1000;
            int cena = random.Next(poczatek, koniec);
            return cena;
        }

        public static int GetNewPricePerKg(int cena)
        {
            Random random = new Random();
            int poczatek = -50;
            int koniec = 200;
            int nowa_cena = random.Next(poczatek, koniec);
            int nowa_cena1 = cena + nowa_cena ;
            return nowa_cena1;
        }
    }
}
