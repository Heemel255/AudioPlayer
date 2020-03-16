using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioEditor
{
    public partial class PlayerForm : Form
    {
        private String FilePath { get; set; }
        private AudioFile audioFile;

        private Timer timer;
        private Timer timerG;

        private Graphics g;
        private SolidBrush b;

        public PlayerForm(String fp)
        {
            InitializeComponent();
            FilePath = fp;

            audioFile = new AudioFile(FilePath);

            timer = new Timer { Interval = 1000 };
            timerG = new Timer { Interval = 100 };

            g = panelVisual.CreateGraphics();
            b = new SolidBrush(Color.Red);
        }
        
        private void EditorForm_Load(object sender, EventArgs e)
        {
            int totTime = audioFile.GetTotalTime();
            trackBarPlayTime.Maximum = totTime;
            
            UpdateLabel(totTime, labelEndTime);
            
            timer.Tick += new EventHandler(timer_Tick);
            timerG.Tick += new EventHandler(timerG_Tick);
        }

        private void timerG_Tick(object sender, EventArgs e)
        {
            panelVisual.Refresh();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            audioFile.SetSpeed();
            
            int updatedTime = (int)audioFile.GetCurrentTime();

            if(updatedTime < trackBarPlayTime.Maximum)
            {
                trackBarPlayTime.Value = updatedTime;

                UpdateLabel(updatedTime, labelCurrentTime);
            }
            else
            {
                audioFile.Stop();
                timer.Stop();
                timerG.Stop();

                trackBarPlayTime.Value = 0;
                audioFile.Reset();
                UpdateLabel(0, labelCurrentTime);
            }
        }

        private void trackBarPlayTime_Scroll(object sender, EventArgs e)
        {
            int timeSelected = trackBarPlayTime.Value;

            if (timeSelected == 0)
            {
                labelCurrentTime.Text = "0:00";
            }
            else
            {
                UpdateLabel(timeSelected, labelCurrentTime);
            }
        }

        private void trackBarPlayTime_MouseUp(object sender, MouseEventArgs e)
        {
            
            audioFile.ChangeTime(trackBarPlayTime.Value);
        }


        private void panelVisual_Paint(object sender, PaintEventArgs e)
        {
            float w = panelVisual.Width * audioFile.GetVolume();

            g.FillRectangle(b, 0, 0, w, panelVisual.Height);
        }
        
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if(trackBarPlayTime.Value >= trackBarPlayTime.Maximum)
            {
                trackBarPlayTime.Value = 0;
            }

            timer.Start();
            timerG.Start();
            audioFile.Play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            audioFile.Stop();
            timer.Stop();
            timerG.Stop();
        }

        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
            timerG.Stop();
            audioFile.Close();
        }

        

        private void buttonReset_Click(object sender, EventArgs e)
        {
            audioFile.Reset();

            trackBarPlayTime.Value = 0;
            UpdateLabel(0, labelCurrentTime);
        }

        private void UpdateLabel(int time, Label l)
        {
            int mins = time / 60;
            int seconds = time % 60;

            if (seconds < 10)
                l.Text = mins + ":0" + seconds;
            else
                l.Text = mins + ":" + seconds;
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            double speed = 1 + (trackBarSpeed.Value / 10.0);

            labelPlaybackSpeed.Text = "x" + string.Format("{0:N1}", speed);

            audioFile.Pace = speed;
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            labelVolume.Text = trackBarVolume.Value.ToString();

            float v = (float)(trackBarVolume.Value / 100.0);
            audioFile.SetOverallVolume(v);
        }
    }
}
