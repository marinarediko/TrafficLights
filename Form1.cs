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
        private Timer timerSwitch = null;
        private Timer timerBlink = null;
        private int timeCounter = 0;
        private int seconds = 0;
        private PictureBox lightToBlink = null;

        public TrafficLights()
        {
            InitializeComponent();
            InitializeTrafficLight();
            InitializeTimerSwitch();
            InitializeTimerBlink();
        }
        private void InitializeTimerSwitch()
        {
            timerSwitch = new Timer();
            timerSwitch.Interval = 1000;
            timerSwitch.Tick += new EventHandler(TimerSwitchTick);
            timerSwitch.Start();
        }
        private void InitializeTimerBlink()
        {
            timerBlink = new Timer();
            timerBlink.Interval = 200;
            timerBlink.Tick += new EventHandler(TimerBlinkTick);
            
        }

        private void TimerBlinkTick(object sender, EventArgs e)
        {
            if (GreenLight.BackColor == Color.Gray)
            {
                GreenLight.BackColor = Color.Green;
            }
            else
            {
                GreenLight.BackColor = Color.Gray;
            }
        }

        private void TimerSwitchTick(object sender, EventArgs e)
        {
            SwitchLights();
        }

        private void SwitchLights()
        {
            switch (seconds)
            {
                case 0:
                    RedLight.BackColor = Color.Red;
                    break;
                case 3:
                    YellowLight.BackColor = Color.Yellow;
                    //RedLight.BackColor = Color.Gray;
                    break;
                case 5:
                    RedLight.BackColor = Color.Gray;
                    YellowLight.BackColor = Color.Gray;
                    GreenLight.BackColor = Color.Green;
                    break;
                case 7:
                    timerBlink.Start();
                    break;
                case 9:
                    timerBlink.Stop();
                    YellowLight.BackColor = Color.Yellow;
                    GreenLight.BackColor = Color.Gray;
                    break;
                case 11:
                    YellowLight.BackColor = Color.Gray;
                    RedLight.BackColor = Color.Red;
                    seconds = -1;
                    break;
            }
            seconds++;
        }


        private void InitializeTrafficLight()
        {
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
        }

    }
}
