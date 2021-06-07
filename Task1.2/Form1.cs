using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1._2
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void RunBtn_MouseEnter(object sender, EventArgs e)
        {
            int Xrandom = random.Next(Width-100);
            int Yrandom = random.Next(Height-100);
            RunBtn.Location = new Point(Xrandom, Yrandom);
        }
    }
}
