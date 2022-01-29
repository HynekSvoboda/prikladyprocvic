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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ukol1 ukol1=new Ukol1();
            ukol1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ukol2 ukol2 = new Ukol2();
            ukol2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ukol3 ukol3 = new Ukol3();
            ukol3.Show();
        }
    }
}
