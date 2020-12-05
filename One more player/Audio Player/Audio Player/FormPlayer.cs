using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Audio_Player
{
    public partial class playerForm : Form
    {

        int currentindex = -1;
        Random rnd = new Random();
        string current = "";
        int playerMode = 0;

        public playerForm()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string[] tmp = openFileDialog1.FileNames;
            for(int i = 0; i < tmp.Length; i++)
            {
                Variables.Files.Add(tmp[i]);
                playlistListBox.Items.Add(Variables.GetFileName(tmp[i]));
            }
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            if(playlistListBox.Items.Count == 0 || playlistListBox.SelectedIndex == -1)
            {
                return;
            }
            current = Variables.Files[playlistListBox.SelectedIndex];
            BassAudio.Play(current, BassAudio.Volume);
            currentTimeLabel.Text = TimeSpan.FromSeconds(BassAudio.GetPositionOfStream(BassAudio.Stream)).ToString();
            lengthTimeLabel.Text = TimeSpan.FromSeconds(BassAudio.GetTimeOfStream(BassAudio.Stream)).ToString();
            timeSlider.Maximum = BassAudio.GetTimeOfStream(BassAudio.Stream);
            timeSlider.Value = BassAudio.GetPositionOfStream(BassAudio.Stream);
            BassAudio.SetVolumeToStream(BassAudio.Stream, volumeSlider.Value);
            timer1.Enabled = true;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            BassAudio.Stop();
            timer1.Enabled = false;
            timeSlider.Value = 0;
            currentTimeLabel.Text = "00:00:00";
            lengthTimeLabel.Text = "00:00:00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = TimeSpan.FromSeconds(BassAudio.GetPositionOfStream(BassAudio.Stream)).ToString();
            timeSlider.Value = BassAudio.GetPositionOfStream(BassAudio.Stream);
            if (currentTimeLabel.Text == lengthTimeLabel.Text) btNext_Click(sender, e);
        }

        private void slTime_Scroll(object sender, ScrollEventArgs e) => BassAudio.SetPositionOfScroll(BassAudio.Stream, timeSlider.Value);

        private void slVolume_Scroll(object sender, ScrollEventArgs e) => BassAudio.SetVolumeToStream(BassAudio.Stream, volumeSlider.Value);

        private void btPause_Click(object sender, EventArgs e) => BassAudio.Pause();

        private void btNext_Click(object sender, EventArgs e)
        {
            if (playlistListBox.Items.Count == 0)
            {
                return;
            }
            if (playerMode == 2)
            {
                if (playlistListBox.Items.Count > 1)
                {
                    do
                    {
                        playlistListBox.SetSelected(rnd.Next(playlistListBox.Items.Count), true);
                    }
                    while (playlistListBox.SelectedIndex == currentindex);
                }
                currentindex = playlistListBox.SelectedIndex;
                current = playlistListBox.SelectedItem.ToString();
                btPlay_Click(sender, e);
            }
            else if (playerMode == 0)
            {
                if (playlistListBox.SelectedIndex != playlistListBox.Items.Count - 1)
                {
                    playlistListBox.SetSelected(playlistListBox.SelectedIndex + 1, true);
                    currentindex = playlistListBox.SelectedIndex;
                    current = playlistListBox.SelectedItem.ToString();
                    btPlay_Click(sender, e);
                }
                else
                {
                    playlistListBox.SetSelected(0, true);
                    currentindex = playlistListBox.SelectedIndex;
                    current = playlistListBox.SelectedItem.ToString();
                    btPlay_Click(sender, e);
                }
            }
            else
            {
                btPlay_Click(sender, e);
            }
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            if (playerMode == 2)
            {
                if (playlistListBox.Items.Count > 1)
                {
                   do
                   {
                        playlistListBox.SetSelected(rnd.Next(playlistListBox.Items.Count), true);

                   }
                   while (playlistListBox.SelectedIndex == currentindex);
                }
                currentindex = playlistListBox.SelectedIndex;
                current = playlistListBox.SelectedItem.ToString();
                btPlay_Click(sender, e);
            }
            else if(playerMode == 0)
            {
                if (playlistListBox.SelectedIndex == -1)
                {
                    return;
                }
                else if (playlistListBox.SelectedIndex != 0)
                {
                    playlistListBox.SetSelected(playlistListBox.SelectedIndex - 1, true);
                    currentindex = playlistListBox.SelectedIndex;
                    current = playlistListBox.SelectedItem.ToString();
                    btPlay_Click(sender, e);
                }
                else
                {
                    playlistListBox.SetSelected(playlistListBox.Items.Count - 1, true);
                    currentindex = playlistListBox.SelectedIndex;
                    current = playlistListBox.SelectedItem.ToString();
                    btPlay_Click(sender, e);
                }
            }
            else
            {
                btPlay_Click(sender, e);
            }
        }

        private void btRmv_Click(object sender, EventArgs e)
        {

            if (playlistListBox.SelectedIndex != -1)
            {
                if (current == Variables.Files[playlistListBox.SelectedIndex])
                {
                    int index = playlistListBox.SelectedIndex;
                    btNext_Click(sender, e);
                    Variables.Files.RemoveAt(index);
                    playlistListBox.Items.RemoveAt(index);
                    playlistListBox.SetSelected(index, true);
                }
                else
                {
                    Variables.Files.RemoveAt(playlistListBox.SelectedIndex);
                    playlistListBox.Items.RemoveAt(playlistListBox.SelectedIndex);
                }
            }
        }

        private void switchModeButton_Click(object sender, EventArgs e)
        {
            if (playerMode == 2) playerMode = 0;
            else playerMode++;
            switch (playerMode)
            {
                case 0:
                    toolTip1.SetToolTip(switchModeButton, "Circle all songs");
                    switchModeButton.BackgroundImage = Image.FromFile("icons/all.png");
                    break;
                case 1:
                    toolTip1.SetToolTip(switchModeButton, "Circle one song");
                    switchModeButton.BackgroundImage = Image.FromFile("icons/one.png");
                    break;
                case 2:
                    toolTip1.SetToolTip(switchModeButton, "Random songs");
                    switchModeButton.BackgroundImage = Image.FromFile("icons/random.png");
                    break;
            }
        }

        private void btSavepl_Click(object sender, EventArgs e)
        {
            string file_out = "Playlist.txt";
            saveFileDialog1.FileName = file_out;
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "все файлы |*.*|текстовые файлы|*.txt";
            saveFileDialog1.AddExtension = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                file_out = saveFileDialog1.FileName;
            StreamWriter sw = File.CreateText(file_out);
            for (int i = 0; i < playlistListBox.Items.Count; i++)
            {
                sw.WriteLine(playlistListBox.Items[i] + " / " + Variables.Files[i]);
            }
            sw.Close();
        }

        private void btOpenpl_Click(object sender, EventArgs e)
        {
            string file_in = "gifts.txt";
            openFileDialog1.Filter = "все файлы |*.*|текстовые файлы|*.txt;*.cs";
            openFileDialog1.FileName = file_in;
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_in = openFileDialog1.FileName;
                string[] ast = File.ReadAllLines(file_in);
                switchModeButton_Click(sender, e);
                foreach (string st in ast)
                {
                    string[] parts = st.Split('/');
                    playlistListBox.Items.Add(parts[0]);
                    Variables.Files.Add(parts[1]);
                }
            }
        }

        private void playerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void playerForm_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string file in (string[])e.Data.GetData(DataFormats.FileDrop, false))
            {
                Variables.Files.Add(file);
                playlistListBox.Items.Add(Variables.GetFileName(file));
            }
        }

        private void playerForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void playerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (playlistListBox.Items.Count == 0)
            {
                return;
            }
            DialogResult dr = MessageBox.Show("Would you like to open your playlist after returning?", "Exit", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else if (dr == DialogResult.Yes)
            {
                using (StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\playlistsaved.txt", true, Encoding.Default))
                {
                    for (int index = 0; index < playlistListBox.Items.Count; ++index)
                        streamWriter.WriteLine(playlistListBox.Items[index].ToString() + "%" + Variables.Files[index]);
                }
            }
        }

        private void playerForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\playlistsaved.txt"))
            {
                using (StreamReader streamReader = new StreamReader(Application.StartupPath + "\\playlistsaved.txt", Encoding.Default))
                {
                    string str;
                    while ((str = streamReader.ReadLine()) != null)
                    {
                        string[] strArray = str.Split('%');
                        playlistListBox.Items.Add(strArray[0]);
                        Variables.Files.Add(strArray[1]);
                    }
                }
                File.Delete(Application.StartupPath + "\\playlistsaved.txt");
            }
        }

        private void analyzerButton_Click(object sender, EventArgs e)
        {
            Process.Start("Analyzer\\Audio_Spectrum_Analyzer.exe");
        }
    }
}
