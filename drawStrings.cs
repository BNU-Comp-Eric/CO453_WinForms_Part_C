using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace drawString
{
    /// <summary>
    /// Task 6.1 
    /// </summary>
    public partial class drawStrings : Form
    {
        public drawStrings()
        {
            InitializeComponent();
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int x = 50;
            int y = 20;
            int fontsize = 30;

            Graphics g = e.Graphics;                
            Font myFont = new Font("Helvetica", fontsize);    // create a font myFont

            for (int i = 1; i <= 6; i++)
            {
                g.DrawString("Eric is texting a Window", myFont, Brushes.Blue, x, y);
                BackColor = Color.Yellow;

                System.Threading.Thread.Sleep(200);
                y = y + fontsize;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
