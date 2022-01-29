using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prikladyprocvic
{
    public partial class Ukol3 : Form
    {
        public Ukol3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int pocetlich = 0, mincislo = int.MaxValue, cifernysoucet = 0, maximalnicislo = int.MinValue;
            long soucin = 1;
            try
            {
                foreach (string prvek in textBox1.Lines)
                {
                    int cislo = Convert.ToInt32(prvek);
                    if (cislo % 2 == 1) pocetlich++;
                    if (cislo < mincislo) mincislo = cislo;
                    if (cislo >= 5 && cislo < 20) soucin *= cislo;
                    if(cislo>maximalnicislo) maximalnicislo = cislo;
                }
            }
            catch
            {
                MessageBox.Show("Něco se nepovedlo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            while (maximalnicislo > 0)
            {
                cifernysoucet += maximalnicislo % 10;
                maximalnicislo = maximalnicislo / 10;
            }
            if (textBox1.Text != "")
            {
                label5.Text = pocetlich.ToString();
                label6.Text = mincislo.ToString();
                label7.Text = soucin.ToString();
                label8.Text = cifernysoucet.ToString();
            }
            else
            {
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                label8.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pomocí cyklu foreach procházejte všechny řádky komponenty TextBox. Řádky obsahují čísla.\na.Vypište počet čísel lichých\nb.Vypište minimální číslo\nc.Vypište součin čísel neležících v intervalu < 5; 20)\nd.Zjistěte ciferný součet maximálního čísla", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); 
        }
    }
}
