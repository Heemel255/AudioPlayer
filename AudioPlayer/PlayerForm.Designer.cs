namespace AudioEditor
{
    partial class PlayerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelVisual = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panelListen = new System.Windows.Forms.Panel();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelPlayTime = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.trackBarPlayTime = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlaybackSpeed = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.panelVolume = new System.Windows.Forms.Panel();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.panelListen.SuspendLayout();
            this.panelPlayTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlayTime)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.panelVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // panelVisual
            // 
            this.panelVisual.BackColor = System.Drawing.Color.White;
            this.panelVisual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVisual.Location = new System.Drawing.Point(13, 13);
            this.panelVisual.Name = "panelVisual";
            this.panelVisual.Size = new System.Drawing.Size(680, 329);
            this.panelVisual.TabIndex = 1;
            this.panelVisual.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVisual_Paint);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(113, 4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(84, 44);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // panelListen
            // 
            this.panelListen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListen.Controls.Add(this.buttonReset);
            this.panelListen.Controls.Add(this.buttonStop);
            this.panelListen.Controls.Add(this.buttonPlay);
            this.panelListen.Location = new System.Drawing.Point(491, 353);
            this.panelListen.Name = "panelListen";
            this.panelListen.Size = new System.Drawing.Size(202, 101);
            this.panelListen.TabIndex = 3;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(113, 52);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(84, 44);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(3, 3);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(84, 44);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // panelPlayTime
            // 
            this.panelPlayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlayTime.Controls.Add(this.label2);
            this.panelPlayTime.Controls.Add(this.labelCurrentTime);
            this.panelPlayTime.Controls.Add(this.labelEndTime);
            this.panelPlayTime.Controls.Add(this.labelStart);
            this.panelPlayTime.Controls.Add(this.trackBarPlayTime);
            this.panelPlayTime.Location = new System.Drawing.Point(13, 353);
            this.panelPlayTime.Name = "panelPlayTime";
            this.panelPlayTime.Size = new System.Drawing.Size(472, 101);
            this.panelPlayTime.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Time:";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Location = new System.Drawing.Point(220, 35);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(28, 13);
            this.labelCurrentTime.TabIndex = 4;
            this.labelCurrentTime.Text = "0:00";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Location = new System.Drawing.Point(430, 37);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(28, 13);
            this.labelEndTime.TabIndex = 3;
            this.labelEndTime.Text = "0:00";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(12, 35);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(28, 13);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "0:00";
            // 
            // trackBarPlayTime
            // 
            this.trackBarPlayTime.Location = new System.Drawing.Point(3, 53);
            this.trackBarPlayTime.Maximum = 5;
            this.trackBarPlayTime.Name = "trackBarPlayTime";
            this.trackBarPlayTime.Size = new System.Drawing.Size(464, 45);
            this.trackBarPlayTime.TabIndex = 1;
            this.trackBarPlayTime.Scroll += new System.EventHandler(this.trackBarPlayTime_Scroll);
            this.trackBarPlayTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarPlayTime_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelVolume);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.trackBarVolume);
            this.panel1.Location = new System.Drawing.Point(699, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 274);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skip";
            // 
            // labelPlaybackSpeed
            // 
            this.labelPlaybackSpeed.AutoSize = true;
            this.labelPlaybackSpeed.Location = new System.Drawing.Point(2, 127);
            this.labelPlaybackSpeed.Name = "labelPlaybackSpeed";
            this.labelPlaybackSpeed.Size = new System.Drawing.Size(27, 13);
            this.labelPlaybackSpeed.TabIndex = 1;
            this.labelPlaybackSpeed.Text = "1.0x";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(38, 3);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSpeed.Size = new System.Drawing.Size(45, 154);
            this.trackBarSpeed.TabIndex = 0;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // panelVolume
            // 
            this.panelVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVolume.Controls.Add(this.label1);
            this.panelVolume.Controls.Add(this.trackBarSpeed);
            this.panelVolume.Controls.Add(this.labelPlaybackSpeed);
            this.panelVolume.Location = new System.Drawing.Point(700, 294);
            this.panelVolume.Name = "panelVolume";
            this.panelVolume.Size = new System.Drawing.Size(88, 160);
            this.panelVolume.TabIndex = 7;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(43, 3);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarVolume.Size = new System.Drawing.Size(45, 266);
            this.trackBarVolume.TabIndex = 3;
            this.trackBarVolume.Value = 100;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Volume";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(3, 240);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(25, 13);
            this.labelVolume.TabIndex = 3;
            this.labelVolume.Text = "100";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.panelVolume);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPlayTime);
            this.Controls.Add(this.panelListen);
            this.Controls.Add(this.panelVisual);
            this.Name = "PlayerForm";
            this.Text = "Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorForm_FormClosing);
            this.Load += new System.EventHandler(this.EditorForm_Load);
            this.panelListen.ResumeLayout(false);
            this.panelPlayTime.ResumeLayout(false);
            this.panelPlayTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlayTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.panelVolume.ResumeLayout(false);
            this.panelVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelVisual;
        private System.Windows.Forms.Panel panelListen;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Panel panelPlayTime;
        private System.Windows.Forms.TrackBar trackBarPlayTime;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPlaybackSpeed;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Panel panelVolume;
        private System.Windows.Forms.Label labelVolume;
    }
}