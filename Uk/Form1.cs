using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Uk
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Uk();
            LK();
        }

        public void LK()
        {
            TimeSpan STime = DateTime.Now.TimeOfDay;
            TimeSpan OTime = new TimeSpan(18, 00, 00);
            TimeSpan RemTime = OTime - STime;
            label1.Text = RemTime.ToString(@"hh\:mm\:ss");
            TimeSpan Zero = new TimeSpan(0, 00, 00);

            if (RemTime < Zero)
            {
                label1.ForeColor = Color.Red;
                label3.Text = "OT";
                label3.ForeColor = Color.PaleVioletRed;
            }
        }


        public void Uk()
        {
            TimeSpan STime2 = DateTime.Now.TimeOfDay;
            TimeSpan UKhours = new TimeSpan(04, 30, 00);
            TimeSpan LondonTime = STime2 - UKhours;
            label2.Text = LondonTime.ToString(@"hh\:mm\:ss");

            TimeSpan RajiAwake = new TimeSpan(06, 30, 00);
            
            if (LondonTime  > RajiAwake)
            {
                label2.ForeColor = Color.Green; 
            }
            else
            {
                label2.ForeColor = Color.Red; 
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
