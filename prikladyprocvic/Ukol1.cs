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
    public partial class Ukol1 : Form
    {
        public Ukol1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();
            double poradi = 1, maximum = int.MinValue, minimum = int.MaxValue, prvniporadimax = 0, posledniporadimax = 0, prvniporadimin = 0;
            double posledniporadimin = 0, pocetmax = 1, pocetmin = 1, prumer = 0, soucet = 0, pocet = 0;
            int n =Convert.ToInt32( numericUpDown1.Value);
            for(int i = 0; i < n;i++)
            {
                double cislo=random.Next(-15, 60);
                listBox1.Items.Add(cislo);
                if (cislo == maximum) pocetmax++;
                if (cislo == minimum) pocetmin ++;
                if (cislo > maximum)
                {
                    maximum = cislo;
                    prvniporadimax = poradi;
                    pocetmax = 1;
                }
                if (cislo == maximum)
                {
                    posledniporadimax = poradi;
                }
                if(cislo<minimum)
                {
                    minimum = cislo;
                    prvniporadimin = poradi;
                    pocetmin = 1;
                }
                if (cislo == minimum) posledniporadimin = poradi;
                soucet += cislo;
                poradi++;
                pocet++;
            }
            double rozdil = ( pocetmin*minimum) + (maximum*pocetmax) ;
            double rozdil2 =  pocetmax + pocetmin;
            if (poradi > 2&&(pocet-rozdil2)!=0) prumer = (soucet - rozdil) / (pocet - rozdil2);
            if (maximum > -20) label3.Text = Convert.ToString(maximum);
            else label3.Text = "";
            label4.Text = Convert.ToString(prvniporadimax);
            if (pocetmax > 1)
            {
                label8.Text = Convert.ToString(posledniporadimax);
                label6.Text = Convert.ToString(pocetmax);
            }
            else
            {
                label8.Text = "";
                label6.Text = "";
            }
            if (minimum < 60) label13.Text = Convert.ToString(minimum);
            else label13.Text = "";
            if(pocetmin>1)
            {
                label14.Text = Convert.ToString(pocetmin);
                label16.Text = Convert.ToString(posledniporadimin);
            }
            else
            {
                label14.Text = "";
                label16.Text = "";
            }
            if (poradi > 1) label18.Text = Convert.ToString(prumer);
            else label18.Text = "";
            label15.Text = Convert.ToString(prvniporadimin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Na vstupu je posloupnost N náhodných celých čísel z intervalu <-15,60).\nČísla vypište do ListBoxu. Vypište maximum posloupnosti a jeho pořadí v posloupnosti.\nPokud je těchto hodnot více, vypište pořadí posledního z nich, dále vypište i kolikrát se v posloupnosti maximum vyskytuje.\nVypište minimum posloupnosti a jeho pořadí v posloupnosti.\nPokud je těchto hodnot více, vypište pořadí prvního z nich, dále vypište i kolikrát se v posloupnosti minimum vyskytuje.\nDále spočítejte aritmetický průměr bez všech minimálních a maximálních čísel.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
