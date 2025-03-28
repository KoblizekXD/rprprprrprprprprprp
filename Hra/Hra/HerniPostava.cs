using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra
{
    public class HerniPostava
    {
        public int PoziceX { get; private set; }
        public int PoziceY { get; private set; }
        public int Level { get; private set; } = 1;
        private string jmeno;

        public HerniPostava()
        {
           
        }

        public void changePosition(int x, int y)
        {

        }

        public string Jmeno
        {
            get; private set;
        }

        public HerniPostava(string jmeno)
        {
            if (jmeno.Length < 10)
                this.Jmeno = jmeno;
        }

        public virtual void ZmenaPozice(int x, int y)
        {
           
        }

        public override string ToString()
        {
            return "";
        }

    }
    
}
