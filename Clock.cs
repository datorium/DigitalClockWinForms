using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClockWinForms
{
    public partial class Clock : Form
    {
        private int dsec = 0;
        private int sec = 0;
        private int min = 0;
        private int hou = 0;

        public Clock()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            Display.ForeColor = Color.White;
            ButtonStop.ForeColor = Color.White;
            ClockTimer.Start();
        }


        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            string dsecText;
            string secText;
            string minText;
            string houText;
            
            dsec += 1;
            if(dsec == 10)
            {
                sec += 1;
                dsec = 0;                
            }

            if(sec == 60)
            {
                min += 1;
                sec = 0;
            }

            if(min == 60)
            {
                hou += 1;
                min = 0;
            }

            dsecText = dsec.ToString();
            secText = sec.ToString("00");
            minText = min.ToString("00");
            houText = hou.ToString("00");
            Display.Text = 
                houText + ":" + 
                minText + ":" +
                secText + ":" +
                dsecText;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            ClockTimer.Stop();
        }
    }
}
