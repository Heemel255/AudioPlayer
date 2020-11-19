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
            this.buttonResume = new System.Windows.Forms.Button();
            this.panelPlayTime = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.trackBarPlayTime = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelVolume = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlaybackSpeed = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.panelVolume = new System.Windows.Forms.Panel();
            this.panelPlayList = new System.Windows.Forms.Panel();
            this.listViewPlayList = new System.Windows.Forms.ListView();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelListen.SuspendLayout();
            this.panelPlayTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlayTime)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.panelVolume.SuspendLayout();
            this.panelPlayList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVisual
            // 
            this.panelVisual.BackColor = System.Drawing.Color.White;
            this.panelVisual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVisual.Location = new System.Drawing.Point(13, 13);
            this.panelVisual.Name = "panelVisual";
            this.panelVisual.Size = new System.Drawing.Size(680, 274);
            this.panelVisual.TabIndex = 1;
            this.panelVisual.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVisual_Paint);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(103, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(94, 44);
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
            this.panelListen.Controls.Add(this.buttonResume);
            this.panelListen.Location = new System.Drawing.Point(13, 293);
            this.panelListen.Name = "panelListen";
            this.panelListen.Size = new System.Drawing.Size(202, 101);
            this.panelListen.TabIndex = 3;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(103, 52);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 44);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonResume
            // 
            this.buttonResume.Location = new System.Drawing.Point(3, 3);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(94, 44);
            this.buttonResume.TabIndex = 0;
            this.buttonResume.Text = "Resume";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // panelPlayTime
            // 
            this.panelPlayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlayTime.Controls.Add(this.label2);
            this.panelPlayTime.Controls.Add(this.labelCurrentTime);
            this.panelPlayTime.Controls.Add(this.labelEndTime);
            this.panelPlayTime.Controls.Add(this.labelStart);
            this.panelPlayTime.Controls.Add(this.trackBarPlayTime);
            this.panelPlayTime.Location = new System.Drawing.Point(13, 400);
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
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(3, 240);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(25, 13);
            this.labelVolume.TabIndex = 3;
            this.labelVolume.Text = "100";
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
            this.labelPlaybackSpeed.Location = new System.Drawing.Point(3, 83);
            this.labelPlaybackSpeed.Name = "labelPlaybackSpeed";
            this.labelPlaybackSpeed.Size = new System.Drawing.Size(27, 13);
            this.labelPlaybackSpeed.TabIndex = 1;
            this.labelPlaybackSpeed.Text = "1.0x";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(3, 19);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(247, 45);
            this.trackBarSpeed.TabIndex = 0;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // panelVolume
            // 
            this.panelVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVolume.Controls.Add(this.label1);
            this.panelVolume.Controls.Add(this.trackBarSpeed);
            this.panelVolume.Controls.Add(this.labelPlaybackSpeed);
            this.panelVolume.Location = new System.Drawing.Point(221, 293);
            this.panelVolume.Name = "panelVolume";
            this.panelVolume.Size = new System.Drawing.Size(264, 101);
            this.panelVolume.TabIndex = 7;
            // 
            // panelPlayList
            // 
            this.panelPlayList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlayList.Controls.Add(this.listViewPlayList);
            this.panelPlayList.Controls.Add(this.buttonPlay);
            this.panelPlayList.Controls.Add(this.buttonRemove);
            this.panelPlayList.Controls.Add(this.buttonAdd);
            this.panelPlayList.Location = new System.Drawing.Point(493, 293);
            this.panelPlayList.Name = "panelPlayList";
            this.panelPlayList.Size = new System.Drawing.Size(295, 208);
            this.panelPlayList.TabIndex = 8;
            // 
            // listViewPlayList
            // 
            this.listViewPlayList.HideSelection = false;
            this.listViewPlayList.Location = new System.Drawing.Point(3, 46);
            this.listViewPlayList.MultiSelect = false;
            this.listViewPlayList.Name = "listViewPlayList";
            this.listViewPlayList.Size = new System.Drawing.Size(287, 153);
            this.listViewPlayList.TabIndex = 4;
            this.listViewPlayList.UseCompatibleStateImageBehavior = false;
            this.listViewPlayList.View = System.Windows.Forms.View.List;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(3, 3);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(85, 37);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(185, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(85, 37);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(94, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 37);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.panelPlayList);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.panelVolume.ResumeLayout(false);
            this.panelVolume.PerformLayout();
            this.panelPlayList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelVisual;
        private System.Windows.Forms.Panel panelListen;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonResume;
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
        private System.Windows.Forms.Panel panelPlayList;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.ListView listViewPlayList;
    }
}