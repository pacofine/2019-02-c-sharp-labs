using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace missPackMan_Boundary_Detection_Testing
{
    public partial class Form1 : Form
    {
        int speedX = 10;
        int speedY = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            block.Left += speedX;
            block.Top += speedY;

            if (block.Left < 1 || block.Left + block.Width > ClientSize.Width)
            {
                speedX = -speedX;
            }

            if (block.Top < 1 || block.Top + block.Height > ClientSize.Height)
            {
                speedY = -speedY;
            }
        }

    }


}
