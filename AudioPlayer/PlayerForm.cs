using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AudioEditor
{
    public partial class PlayerForm : Form
    {
        private String currentFilePath;
        private AudioFile audioFile;

        private Timer timer;
        private Timer timerG;
        private Graphics g;
        private SolidBrush b;

        public PlayerForm(String fp)
        {
            InitializeComponent();
            
            timer = new Timer { Interval = 1000 };
            timerG = new Timer { Interval = 100 };

            g = panelVisual.CreateGraphics();
            b = new SolidBrush(Color.Red);

            currentFilePath = fp;
        }
        
        private void EditorForm_Load(object sender, EventArgs e)
        {
            setAudioFile(currentFilePath);
            addToViewList(currentFilePath);

            timer.Tick += new EventHandler(timer_Tick);
            timerG.Tick += new EventHandler(timerG_Tick);
        }

        private void EditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop();
            audioFile.Close();
        }

        //update visualization
        private void timerG_Tick(object sender, EventArgs e)
        {
            panelVisual.Refresh();
        }

        //update time on trackbar
        //trackbar increases based on pace
        private void timer_Tick(object sender, EventArgs e)
        {

            audioFile.SetSpeed();
            
            int updatedTime = (int)audioFile.GetCurrentTime();

            if(updatedTime < trackBarPlayTime.Maximum)
            {
                trackBarPlayTime.Value = updatedTime;

                UpdateTimeLabel(updatedTime, labelCurrentTime);
            }
            else
            {
                audioFile.Stop();
                timer.Stop();
                timerG.Stop();

                trackBarPlayTime.Value = 0;
                audioFile.Reset();
                UpdateTimeLabel(0, labelCurrentTime);
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
                UpdateTimeLabel(timeSelected, labelCurrentTime);
            }
        }

        private void trackBarPlayTime_MouseUp(object sender, MouseEventArgs e)
        {
            
            audioFile.ChangeTime(trackBarPlayTime.Value);
        }
        
        //visualization of audio using the volume
        private void panelVisual_Paint(object sender, PaintEventArgs e)
        {
            float w = panelVisual.Width * audioFile.GetVolume();

            g.FillRectangle(b, 0, 0, w, panelVisual.Height);
        }
        
        //will play the default starting file if clicked
        private void buttonResume_Click(object sender, EventArgs e)
        {
            play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            stop();
        }
        
        private void buttonReset_Click(object sender, EventArgs e)
        {
            audioFile.Reset();

            trackBarPlayTime.Value = 0;
            UpdateTimeLabel(0, labelCurrentTime);
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

            setVolume();
        }
        
        private void buttonRemove_Click(object sender, EventArgs e)
        {

            listViewPlayList.SelectedItems[0].Remove();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //max amount of audio files should be 9 in play list
            if(listViewPlayList.Items.Count >= 9)
            {
                MessageBox.Show("No more than 9 items");
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = AudioFileTypes.TYPES
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    addToViewList(ofd.FileName);
                }
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //play the audio file
            //if audio file gets deleted in Windows after its chosen then AudioFile constructor will catch it
            if(listViewPlayList.SelectedItems.Count > 0)
            {
                stop();
                setAudioFile(listViewPlayList.SelectedItems[0].Tag.ToString());
                setVolume();
                play();
            }
        }
        
        private void setAudioFile(String fp)
        {
            //creates an AudioFile object from the given file path
            currentFilePath = fp;
            audioFile = new AudioFile(currentFilePath);

            int totTime = audioFile.GetTotalTime();
            trackBarPlayTime.Maximum = totTime;

            UpdateTimeLabel(totTime, labelEndTime);
        }

        private void addToViewList(String fp)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Tag = fp;
            lvi.Text = Path.GetFileNameWithoutExtension(fp);
            listViewPlayList.Items.Add(lvi);
        }

        private void setVolume()
        {
            float v = (float)(trackBarVolume.Value / 100.0);
            audioFile.SetOverallVolume(v);
        }
        
        private void UpdateTimeLabel(int time, Label l)
        {
            int mins = time / 60;
            int seconds = time % 60;

            if (seconds < 10)
                l.Text = mins + ":0" + seconds;
            else
                l.Text = mins + ":" + seconds;
        }

        private void play()
        {
            //the track bar will reset in case it exceeds the total time of the audio file
            if (trackBarPlayTime.Value >= trackBarPlayTime.Maximum)
            {
                trackBarPlayTime.Value = 0;
            }

            timer.Start();
            timerG.Start();
            audioFile.Play();
        }
        
        private void stop()
        {
            audioFile.Stop();
            timer.Stop();
            timerG.Stop();
        }
    }
}
