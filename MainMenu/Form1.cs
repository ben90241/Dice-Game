using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dice;

namespace MainMenu
{
    public partial class Form1 : Form
    {
        private Dice.Form1 form2 = new Dice.Form1();
        public Form1()
        {
            InitializeComponent();
        }

        private void onePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.Show();
        }
    }
}
