using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int change = flowLayoutPanel1.VerticalScroll.Value + flowLayoutPanel1.VerticalScroll.SmallChange * 30;
            flowLayoutPanel1.AutoScrollPosition = new Point(0, change);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int change = flowLayoutPanel1.VerticalScroll.Value - flowLayoutPanel1.VerticalScroll.SmallChange * 30;
            flowLayoutPanel1.AutoScrollPosition = new Point(0, change);
        }
    }
}
