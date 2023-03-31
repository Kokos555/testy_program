using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hra_z_testu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string jmeno;
        private void button1_Click(object sender, EventArgs e)
        {
            jmeno = "Ivan povoroznik";
            Hernípostava Ivan = new Hernípostava(jmeno);
            MessageBox.Show(Ivan.ToString());
        }

        public string NameLenghtFalse()
        {
            return jmeno;
        }

        public string NameLenghtTrue() { return jmeno; }



    }
}
