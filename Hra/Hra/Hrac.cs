using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra
{
    public class Hrac : HerniPostava
    {
        public enum SpecializaceType { Kouzelník, Berserker, Inženýr, Cizák }
        public enum Oblicij { VelkýNos, Ušoplesk, MakeUp }
        public enum Vlasy { Drdol, Culík, Pleška }
        public enum BarvaVlasů { Kaštanová, Blond, Červená }

        private Oblicij _oblicij;
        private Vlasy _vlasy;
        private BarvaVlasů _barvaVlasu;

        public SpecializaceType Specializace { get; set; }
        public int XP { get; private set; } = 0;

        public Hrac(string jmeno, SpecializaceType specializace, Oblicij oblicij, Vlasy vlasy, BarvaVlasů barva)
            : base(jmeno)
        {
            Specializace = specializace;
            _oblicij = oblicij;
            _vlasy = vlasy;
            _barvaVlasu = barva;
        }

        public void PridejXP(int hodnota)
        {
            if (hodnota > 0)
            {
                XP += hodnota;
                while (XP >= Level * 100)
                {
                    XP -= Level * 100;
                    Level++;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", Specializace: {Specializace}, XP: {XP}";
        }
    }
}
