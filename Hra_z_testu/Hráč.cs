using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hra_z_testu
{
    internal class Hráč: Hernípostava
    {
        private string specializace;

        private string oblicej;
        private string vlasy;
        private string barva_vlasu;
        public int XP;
       /* enum Oblicej
        {
            velky_nos,
            ušoplesk,
            make-up
        }*/
        public Hráč(string jmeno, int level, int x, int y, string oblicej, string vlasy, string barva_vlasu):base(jmeno)
        {
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barva_vlasu = barva_vlasu;
            XP = 0;
        }


        public string Specializace
        {
            get
            {
                return specializace;
            }
            set
            {
                specializace = value;
                if (specializace != "Kouzelník" || specializace != "Berserker" || specializace != "Inženýr" || specializace != "Cizák")
                {
                    specializace = "";
                }
            }
        }






    }
}
