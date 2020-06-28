using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AlarmClock
{
    public partial class Form1 : Form
    {
        public bool AlarmSet = false;
        public string[] time;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentTime.Text = DateTime.Now.TimeOfDay.ToString().Substring(0, 8);

            if (AlarmSet)
            {
                TimeToAlarm.Text = "До сигнала будильника: \n" + 
                    (int.Parse(time[0]) - DateTime.Now.Hour).ToString() + " часов " + Math.Abs(int.Parse(time[1]) - DateTime.Now.Minute).ToString() + " минут(а)";
            }
            if (AlarmSet && CurrentTime.Text.Substring(0,5) == AlarmTime.Text)
            {
                Alarm();
            }
        }

        private void SetAlarm_Click(object sender, EventArgs e)
        {
            if (AlarmSet)
            {
                AlarmSet = false;
                SetAlarm.Text = "Установить будильник";
                TimeToAlarm.Text = "";
                StopAlarm.Enabled = false;
            }
            else
            {
                time = AlarmTime.Text.Split(':');
                if (!int.TryParse(time[0], out int hour) || !int.TryParse(time[1], out int minute) || hour > 23 || minute > 59)
                {
                    MessageBox.Show("Время введено неверно");
                }
                else
                {
                    AlarmSet = true;
                    SetAlarm.Text = "Удалить будильник";
                    StopAlarm.Enabled = true;
                }
            }
        }

        private void StopAlarm_Click(object sender, EventArgs e)
        {
            AlarmSet = false;
            StopAlarm.Enabled = false;
            AlarmTime.Clear();
            SetAlarm.Text = "Установить будильник";
            TimeToAlarm.Text = "";
        }

        public void Alarm()
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = "sound.wav";
            sp.Play();
        }
    }
}
