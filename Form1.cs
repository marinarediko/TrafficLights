using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    public partial class TrafficLights : Form
    {
        private Timer timerSwitch;
        private bool R_to_G = true;
        private int tickCount = 0;
        private bool greenOff = true;
        int counter;
               
        public TrafficLights()
        {
            InitializeComponent();
            InitializeTrafficLight();
            InitializeTimerSwitch();
        }

        private void InitializeTimerSwitch()
        {
            timerSwitch = new Timer();
            timerSwitch.Interval = 250;
            timerSwitch.Tick += new EventHandler(TimerSwitchTick);
            timerSwitch.Start();
        }

        private void TimerSwitchTick(object sender, EventArgs e)
        {
            if (tickCount >= 14 && tickCount < 20 && !greenOff)
            {
                if (GreenLight.BackColor == Color.Gray)
                    GreenLight.BackColor = Color.Green;
                else
                    GreenLight.BackColor = Color.Gray;
                tickCount++;
            }
            else if (tickCount == 20)
            {
                if (RedLight.BackColor == Color.Red)
                {
                    RedLight.BackColor = Color.Gray;
                    YellowLight.BackColor = Color.Yellow;
                }
                else if (YellowLight.BackColor == Color.Yellow && R_to_G)
                {
                    YellowLight.BackColor = Color.Gray;
                    GreenLight.BackColor = Color.Green;
                    R_to_G = false;
                    greenOff = false;
                }
                else if (YellowLight.BackColor == Color.Yellow && !R_to_G)
                {
                    YellowLight.BackColor = Color.Gray;
                    RedLight.BackColor = Color.Red;
                    R_to_G = true;
                }
                else if (GreenLight.BackColor == Color.Green)
                {
                    YellowLight.BackColor = Color.Yellow;
                    GreenLight.BackColor = Color.Gray;
                    greenOff = true;
                }
                tickCount = 0;
            }
            else
                tickCount++;
        }

        private void InitializeTrafficLight()
        {
            RedLight.BackColor = Color.Red;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
        }

    }
}
