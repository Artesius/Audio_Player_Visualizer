namespace Audio_Player
{
    partial class playerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerForm));
            this.playlistListBox = new System.Windows.Forms.ListBox();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.lengthTimeLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.switchModeButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.removeSongButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.addSongButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.analyzerButton = new System.Windows.Forms.Button();
            this.volumeSlider = new MB.Controls.ColorSlider();
            this.timeSlider = new MB.Controls.ColorSlider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // playlistListBox
            // 
            this.playlistListBox.FormattingEnabled = true;
            this.playlistListBox.ItemHeight = 25;
            this.playlistListBox.Location = new System.Drawing.Point(12, 27);
            this.playlistListBox.Name = "playlistListBox";
            this.playlistListBox.Size = new System.Drawing.Size(481, 179);
            this.playlistListBox.TabIndex = 0;
            this.playlistListBox.Tag = "Playlist";
            this.playlistListBox.DoubleClick += new System.EventHandler(this.btPlay_Click);
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Location = new System.Drawing.Point(12, 250);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(90, 25);
            this.currentTimeLabel.TabIndex = 6;
            this.currentTimeLabel.Text = "00:00:00";
            // 
            // lengthTimeLabel
            // 
            this.lengthTimeLabel.AutoSize = true;
            this.lengthTimeLabel.Location = new System.Drawing.Point(422, 250);
            this.lengthTimeLabel.Name = "lengthTimeLabel";
            this.lengthTimeLabel.Size = new System.Drawing.Size(90, 25);
            this.lengthTimeLabel.TabIndex = 7;
            this.lengthTimeLabel.Text = "00:00:00";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(12, 282);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(85, 25);
            this.volumeLabel.TabIndex = 50;
            this.volumeLabel.Text = "Volume:";
            // 
            // switchModeButton
            // 
            this.switchModeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("switchModeButton.BackgroundImage")));
            this.switchModeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.switchModeButton.Location = new System.Drawing.Point(227, 461);
            this.switchModeButton.Name = "switchModeButton";
            this.switchModeButton.Size = new System.Drawing.Size(60, 60);
            this.switchModeButton.TabIndex = 9;
            this.toolTip1.SetToolTip(this.switchModeButton, "Circle all songs");
            this.switchModeButton.UseVisualStyleBackColor = true;
            this.switchModeButton.Click += new System.EventHandler(this.switchModeButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.Transparent;
            this.previousButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previousButton.BackgroundImage")));
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousButton.Location = new System.Drawing.Point(162, 395);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(60, 60);
            this.previousButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.previousButton, "Previous song");
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.Location = new System.Drawing.Point(292, 395);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(60, 60);
            this.nextButton.TabIndex = 7;
            this.toolTip1.SetToolTip(this.nextButton, "Next song");
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.btNext_Click);
            // 
            // removeSongButton
            // 
            this.removeSongButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeSongButton.BackgroundImage")));
            this.removeSongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeSongButton.Location = new System.Drawing.Point(357, 461);
            this.removeSongButton.Name = "removeSongButton";
            this.removeSongButton.Size = new System.Drawing.Size(60, 60);
            this.removeSongButton.TabIndex = 10;
            this.toolTip1.SetToolTip(this.removeSongButton, "Remove songs");
            this.removeSongButton.UseVisualStyleBackColor = true;
            this.removeSongButton.Click += new System.EventHandler(this.btRmv_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseButton.BackgroundImage")));
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.Location = new System.Drawing.Point(97, 329);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(60, 60);
            this.pauseButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.pauseButton, "Pause");
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.btPause_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopButton.BackgroundImage")));
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopButton.Location = new System.Drawing.Point(357, 329);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(60, 60);
            this.stopButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.stopButton, "Stop");
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.btStop_Click);
            // 
            // addSongButton
            // 
            this.addSongButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addSongButton.BackgroundImage")));
            this.addSongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addSongButton.Location = new System.Drawing.Point(97, 461);
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(60, 60);
            this.addSongButton.TabIndex = 8;
            this.toolTip1.SetToolTip(this.addSongButton, "Add songs");
            this.addSongButton.UseVisualStyleBackColor = true;
            this.addSongButton.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playButton.BackgroundImage")));
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.Location = new System.Drawing.Point(227, 329);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(60, 60);
            this.playButton.TabIndex = 3;
            this.toolTip1.SetToolTip(this.playButton, "Play");
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // analyzerButton
            // 
            this.analyzerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("analyzerButton.BackgroundImage")));
            this.analyzerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.analyzerButton.Location = new System.Drawing.Point(227, 527);
            this.analyzerButton.Name = "analyzerButton";
            this.analyzerButton.Size = new System.Drawing.Size(60, 60);
            this.analyzerButton.TabIndex = 11;
            this.toolTip1.SetToolTip(this.analyzerButton, "Open Visualizer");
            this.analyzerButton.UseVisualStyleBackColor = true;
            this.analyzerButton.Click += new System.EventHandler(this.analyzerButton_Click);
            // 
            // volumeSlider
            // 
            this.volumeSlider.BackColor = System.Drawing.Color.Transparent;
            this.volumeSlider.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.volumeSlider.LargeChange = ((uint)(5u));
            this.volumeSlider.Location = new System.Drawing.Point(85, 278);
            this.volumeSlider.Name = "volumeSlider";
            this.volumeSlider.Size = new System.Drawing.Size(129, 30);
            this.volumeSlider.SmallChange = ((uint)(1u));
            this.volumeSlider.TabIndex = 2;
            this.volumeSlider.Text = "colorSlider1";
            this.volumeSlider.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.volumeSlider.Value = 100;
            this.volumeSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slVolume_Scroll);
            // 
            // timeSlider
            // 
            this.timeSlider.BackColor = System.Drawing.Color.Transparent;
            this.timeSlider.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.timeSlider.LargeChange = ((uint)(5u));
            this.timeSlider.Location = new System.Drawing.Point(12, 217);
            this.timeSlider.Name = "timeSlider";
            this.timeSlider.Size = new System.Drawing.Size(481, 30);
            this.timeSlider.SmallChange = ((uint)(1u));
            this.timeSlider.TabIndex = 1;
            this.timeSlider.Text = "colorSlider1";
            this.timeSlider.ThumbRoundRectSize = new System.Drawing.Size(8, 8);
            this.timeSlider.Value = 0;
            this.timeSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.slTime_Scroll);
            // 
            // playerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 596);
            this.Controls.Add(this.analyzerButton);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.switchModeButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.removeSongButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.volumeSlider);
            this.Controls.Add(this.lengthTimeLabel);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.timeSlider);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.addSongButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.playlistListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "playerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.playerForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.playerForm_FormClosed);
            this.Load += new System.EventHandler(this.playerForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.playerForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.playerForm_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playlistListBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button addSongButton;
        private System.Windows.Forms.Button stopButton;
        private MB.Controls.ColorSlider timeSlider;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Label lengthTimeLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private MB.Controls.ColorSlider volumeSlider;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button switchModeButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button removeSongButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Button analyzerButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

