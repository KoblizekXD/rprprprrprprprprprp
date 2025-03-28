using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra
{
    public class NPC: HerniPostava
    {
        public enum Prace 
        {
            Obchodnik,
            Nepritel,
            Obyvatel
        }

        public Prace Práce { get; }
        public bool Sila { get; } 

        private bool _poziceNastavena;

        public NPC(string jmeno, Prace prace, bool jeBoss): base(jmeno)
        {
            Práce = prace;
            Sila = jeBoss;
        }

        public NPC(string jmeno, Prace prace) : base(jmeno)
        {
            Práce = prace;
            Sila = false;
        }

        public override void ZmenaPozice(int x, int y)
        {
           
        }

        public override string ToString()
        {
            return "";
        }
    }
}
