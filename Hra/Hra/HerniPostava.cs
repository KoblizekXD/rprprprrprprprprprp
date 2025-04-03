using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hra
{
    public class HerniPostava
    {
        public int PoziceX { get; set; } = 0;
        public int PoziceY { get; set; } = 0;
        public int Level { get; set; } = 1;
        private string jmeno;

        public string Jmeno
        {
            get => jmeno;
            set
            {
                if (value.Length > 10)
                {
                    Console.WriteLine("Příliš dlouhé jméno!");
                }
                else
                {
                    jmeno = value;
                }
            }
        }

        public HerniPostava(string jmeno)
        {
            Jmeno = jmeno;
        }

        public virtual void ZmenaPozice(int x, int y)
        {
            PoziceX = x;
            PoziceY = y;
        }

        public override string ToString()
        {
            return $"Jméno: {Jmeno}, Level: {Level}, Pozice: ({PoziceX}, {PoziceY})";
        }
    }

}
