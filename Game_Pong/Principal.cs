using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Pong
{
    public partial class Principal : Form
    {
        int speed_left = 0;
        int speed_top = 4;
        int ponits = 0;


        public Principal()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            raquet.Top = playground.Bottom - (playground.Bottom / 10);
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            raquet.Left = Cursor.Position.X - (raquet.Width / 2);            

            boll.Left += speed_left;
            boll.Top += speed_top;
           

            if (boll.Bottom >= raquet.Top && boll.Bottom <= raquet.Bottom && boll.Left >= raquet.Left && boll.Right <= raquet.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                ponits += 1;
            }

            if (boll.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if (boll.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }

            if (boll.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }

            if (boll.Bottom >= playground.Bottom)
            {
                speed_top = -speed_top;
            }

            if (boll.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
            }

        }

        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) { this.Close(); }
        }
    }
}
