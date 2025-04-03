using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hra
{
    public partial class Form1 : Form
    {
        private Hrac hrac;
        private NPC npc;
        private Label lblInfo;
        private Button btnUp, btnDown, btnLeft, btnRight, btnInterakce;

        public Form1()
        {
            InitializeComponent();
            InicializujHru();
        }

        private void InicializujHru()
        {
            hrac = new Hrac("Hrdina", Hrac.SpecializaceType.Kouzelník, Hrac.Oblicij.VelkýNos, Hrac.Vlasy.Culík, Hrac.BarvaVlasů.Kaštanová);
            npc = new NPC("Obchodník", NPC.Prace.Obchodnik);

            lblInfo = new Label { Text = hrac.ToString(), AutoSize = true, Top = 10, Left = 10 };
            Controls.Add(lblInfo);

            btnUp = VytvorTlacitko("Nahoru", 100, 50, (s, e) => PosunHrace(0, 1));
            btnDown = VytvorTlacitko("Dolů", 100, 150, (s, e) => PosunHrace(0, -1));
            btnLeft = VytvorTlacitko("Doleva", 50, 100, (s, e) => PosunHrace(-1, 0));
            btnRight = VytvorTlacitko("Doprava", 150, 100, (s, e) => PosunHrace(1, 0));
            btnInterakce = VytvorTlacitko("Interakce", 100, 200, (s, e) => Interakce());
        }

        private Button VytvorTlacitko(string text, int x, int y, EventHandler onClick)
        {
            Button btn = new Button { Text = text, Left = x, Top = y, Width = 75 };
            btn.Click += onClick;
            Controls.Add(btn);
            return btn;
        }

        private void PosunHrace(int x, int y)
        {
            hrac.ZmenaPozice(hrac.PoziceX + x, hrac.PoziceY + y);
            lblInfo.Text = hrac.ToString();
        }

        private void Interakce()
        {
            MessageBox.Show($"{hrac.Jmeno} potkal {npc.Jmeno}, který je {npc.Práce}");
        }
    }
}
