using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hra_z_testu
{
    internal class Hernípostava
    {
        public string Jmeno { get; set; }
        private int level;
        protected int X;
        protected int Y;

        public Hernípostava(string jmeno)
        {
            Jmeno = jmeno;
            level = 1;
            X = 0;
            Y = 0;
        }

        public void Zmena_pozice()
        {
            X++;
            Y++;
        }

        public string ToString()
        {
            return string.Format($"Jmenuješ se {Jmeno} máš level {level} a jsi na souradnicích {X}, {Y}");
        }
    }
}
