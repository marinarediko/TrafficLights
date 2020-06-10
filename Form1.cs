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
        private int seconds = 0;
        private int hou = 0, min = 0, sec = 0;

        private PictureBox lightToBlink = null;
        private Color colorToCheck = Color.Gray;
        private Label labelTime = null;

        public TrafficLights()
        {
            InitializeComponent();
            InitializeTrafficLight();
            InitializeTimerSwitch();
            InitializeTimerBlink();
            InitializeLabelTime();
        }

        private void InitializeLabelTime()
        {
            labelTime = new Label();
            labelTime.Font = new Font("Arial", 18, FontStyle.Regular);
            labelTime.Top = 20;
            labelTime.Width = 110;
            labelTime.Height = 50;
            labelTime.Left = 45;
            labelTime.Text = "00:00:00";
            this.Controls.Add(labelTime);
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
            if (lightToBlink.BackColor == Color.Gray)
            {
                lightToBlink.BackColor = colorToCheck;
            }
            else
            {
                lightToBlink.BackColor = Color.Gray;
            }
        }

        private void StartBlinking(PictureBox light, Color color)
        {
            lightToBlink = light;
            colorToCheck = color;
            timerBlink.Start();
        }

        private void StopBlinking()
        {
            timerBlink.Stop();
        }

        private void TimerSwitchTick(object sender, EventArgs e)
        {
            UpdateClock();
            SwitchLights();
            UpdateLabelTime();
        }

        private void UpdateClock()
        {

            sec++;
            if (sec == 60)
            {
                min++;
                sec = 0;
            }
            if (min == 60)
            {
                hou++;
                min = 0;
            }
            if (hou == 24)
            {
                ResetClock();
            }
        }

        private void ResetClock()
        {
            sec = 0;
            min = 0;
            hou = 0;
        }

        private void UpdateLabelTime()
        {
            //labelTime.Text = hou.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00");
            labelTime.Text = $"{hou:00}:{min:00}:{sec:00}";
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
                    StartBlinking(GreenLight, Color.Green);
                    break;
                case 9:
                    StopBlinking();
                    YellowLight.BackColor = Color.Yellow;
                    GreenLight.BackColor = Color.Gray;
                    break;
                case 11:
                    YellowLight.BackColor = Color.Gray;
                    RedLight.BackColor = Color.Red;
                    seconds = -1;
                    ResetClock();
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
