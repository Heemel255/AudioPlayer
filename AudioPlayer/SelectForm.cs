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
    public partial class SelectForm : Form
    {
        private String filePath;

        public SelectForm()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "MP3 files|*.mp3|Wav files|*.wav*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                filePath = ofd.FileName;
                textBoxFP.Text = filePath;
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                PlayerForm ef = new PlayerForm(filePath);
                ef.Show();
            }
        }
    }
}
