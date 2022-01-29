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
    public partial class Ukol2 : Form
    {
        public Ukol2()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            listBox1.Items.Clear();
            Random random = new Random();
            int n = Convert.ToInt32(numericUpDown1.Value);
            int pocet = 0;
            for (int i = 0; i < n; i++)
            {
                int cislo = random.Next(-5, 20);
                listBox1.Items.Add(cislo.ToString());
                if (cislo > 2 &&cislo<= 5) break;
                pocet++;
            }
            if (pocet< n-1) label2.Text = "Došlo k předčasnému ukončení (bylo nalezeno číslo v intervalu (2;5> )";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            listBox1.Items.Clear();
            Random random = new Random();
            int n = Convert.ToInt32(numericUpDown1.Value);
            int pocet = 0;
            bool rychlost = false;
            for (int i = 0; i < n&&rychlost==false; i++)
            {
                int cislo = random.Next(-5, 20);
                listBox1.Items.Add(cislo.ToString());
                if (cislo > 2 && cislo <= 5) rychlost = true;
                pocet++;
            }
            if (pocet < n - 1) label2.Text = "Došlo k předčasnému ukončení (bylo nalezeno číslo v intervalu (2;5> )";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            listBox1.Items.Clear();
            Random random = new Random();
            int n = Convert.ToInt32(numericUpDown1.Value);
            int pocet = 0, i = 0;
            bool rychlost = false;
            while( i < n && rychlost == false)
            {
                int cislo = random.Next(-5, 20);
                listBox1.Items.Add(cislo.ToString());
                if (cislo > 2 && cislo <= 5) rychlost = true;
                pocet++;
                i++;
            }
            if (pocet < n - 1) label2.Text = "Došlo k předčasnému ukončení (bylo nalezeno číslo v intervalu (2;5> )";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            listBox1.Items.Clear();
            Random random = new Random();
            int n = Convert.ToInt32(numericUpDown1.Value);
            int pocet = 0, i = 0;
            bool rychlost = false;
            if (n > 0)
            {
                do
                {
                    int cislo = random.Next(-5, 20);
                    listBox1.Items.Add(cislo.ToString());
                    if (cislo > 2 && cislo <= 5) rychlost = true;
                    pocet++;
                    i++;
                } while (i < n && rychlost == false);
                if (pocet < n - 1) label2.Text = "Došlo k předčasnému ukončení (bylo nalezeno číslo v intervalu (2;5> )";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Na vstupu je dáno celé číslo n a n-prvková posloupnost náhodných reálných čísel z intervalu <-5;20). Čísla zobrazuj do ListBoxu. Zjistěte, zda posloupnost obsahuje číslo z intervalu (2;5>.\nCyklus časově optimalizujte (po nalezení čísla z intervalu cyklus předčasně ukončete). Projekt bude obsahovat 4 tlačítka.\nV prvním tlačítku použijte cyklus for a cyklus předčasně ukončete pomocí break.\nV druhém tlačítku použijte cyklus for a cyklus předčasně ukončete pomocí bool.\nV třetím tlačítku použijte cyklus while a cyklus předčasně ukončete pomocí bool.\nVe čtvrtém tlačítku použijte cyklus do while a cyklus předčasně ukončete pomocí bool.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
