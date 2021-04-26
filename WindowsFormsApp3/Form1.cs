using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
         Color color; 
      
        public Form1()
        {
            InitializeComponent();
            color = this.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            R.Text = trackBar1.Value.ToString();
            g.BackColor = Color.Black;
            B.BackColor = Color.Black;
        }

      

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);

            R.Text = trackBar1.Value.ToString();
            g.BackColor = Color.Black;
            B.BackColor = Color.Black;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {

            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
   
            R.Text = trackBar1.Value.ToString();
            g.BackColor = Color.Black;
            B.BackColor = Color.Black;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void R_Click(object sender, EventArgs e)
        {

        }
    }
}
