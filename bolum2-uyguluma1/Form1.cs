using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum2_uyguluma1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesaj_Click(object sender, EventArgs e)
        {
            int yas = 17;
            // yaş 18 ve üzerindeyse "ehliyet alınabilir" yazdıran program.
            if (yas >= 18)
            {
                MessageBox.Show("Ehliyet Alabilirsiniz");
            }

            if (yas <= 18)
            {
                MessageBox.Show("Biraz daha büyümelisin");
            }
        }
}   }
