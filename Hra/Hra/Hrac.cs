using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra
{
    public class Hrac: HerniPostava
    {
        public enum SpecializaceType { Kouzelník, Berserker, Inženýr, Cizák, Neznámý }
        public enum Oblicij { VelkýNos, Ušoplesk, MakeUp }
        public enum Vlasy { Drdol, Culík, Pleška }
        public enum BarvaVlasů { Kaštanová, Blond, Červená }

        private Oblicij _oblicij;
        private Vlasy _vlasy;
        private BarvaVlasů _barvaVlasu;

        public SpecializaceType Specializace { get; set; }
        public int XP { get; private set; }

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
            if(hodnota <= 0)
            {
                return;
            }
            else
            {
                XP += hodnota;
                Level += XP / 100;
            }

        }

        public override string ToString()
        {
            return "";
        }
    }
}
