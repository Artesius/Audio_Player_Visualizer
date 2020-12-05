using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Un4seen.Bass;
using Un4seen.BassWasapi;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace Audio_Spectrum_Analyzer
{
    public partial class Form1 : Form
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool Beep(uint dwFreq, uint dwDuration);

        private WASAPIPROC process;        //callback function to obtain data
        private int devindex;               //used device index
        public float[] fft = new float[8192];
        private Random rnd = new Random();
        private int[] byt1 = new int[130];
        private int _lines = 65, a = 255, r = 0, g = 0, b = 0, diff = 0, rainb = 0, ba = 255, br = 255, bg = 255, bb = 255;
        private bool isChanging = false, isRainbow = false, isbImage = false, isRadial = false, isReflected = true;

        public Form1()
        {
            InitializeComponent();

            fft = new float[8192];
            process = new WASAPIPROC(Process);
            chart1.SendToBack();

            for (int i = 0; i < chart1.ChartAreas["ChartArea1"].AxisX.Maximum - 1; i++)
            {
                chart1.Series["wave"].Points.Add(0);
            }

            Init();
        }


        private void Init()
        {
            Bass.BASS_SetConfig(BASSConfig.BASS_CONFIG_UPDATETHREADS, false);
            if (!Bass.BASS_Init(0, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero)) throw new Exception("Init Error");
            for (int i = 0; i < BassWasapi.BASS_WASAPI_GetDeviceCount(); i++)
            {
                BASS_WASAPI_DEVICEINFO device = BassWasapi.BASS_WASAPI_GetDeviceInfo(i);
                if (device.IsEnabled && device.IsLoopback)
                {
                    devicelist.Items.Add(string.Format("{0} - {1}", i, device.name));
                }
            }
            devicelist.SelectedIndex = 0;
        }

        private int Process(IntPtr buffer, int length, IntPtr user)
        {
            return length;
        }

        private void deviceSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devicelist.Visible = true;
            lba.Visible = false;
            tba.Visible = false;
            lbr.Visible = false;
            tbr.Visible = false;
            lbg.Visible = false;
            tbg.Visible = false;
            lbb.Visible = false;
            tbb.Visible = false;
            lbba.Visible = false;
            tbba.Visible = false;
            lbbr.Visible = false;
            tbbr.Visible = false;
            lbbg.Visible = false;
            tbbg.Visible = false;
            lbbb.Visible = false;
            tbbb.Visible = false;
            lbln.Visible = false;
            tbln.Visible = false;
            lblRadial.Visible = false;
        }

        private void colorSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devicelist.Visible = false;
            lba.Visible = true;
            tba.Visible = true;
            lbr.Visible = true;
            tbr.Visible = true;
            lbg.Visible = true;
            tbg.Visible = true;
            lbb.Visible = true;
            tbb.Visible = true;
            lbba.Visible = false;
            tbba.Visible = false;
            lbbr.Visible = false;
            tbbr.Visible = false;
            lbbg.Visible = false;
            tbbg.Visible = false;
            lbbb.Visible = false;
            tbbb.Visible = false;
            lbln.Visible = false;
            tbln.Visible = false;
            lblRadial.Visible = false;
        }

        private void spectrumSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devicelist.Visible = false;
            lba.Visible = false;
            tba.Visible = false;
            lbr.Visible = false;
            tbr.Visible = false;
            lbg.Visible = false;
            tbg.Visible = false;
            lbb.Visible = false;
            tbb.Visible = false;
            lbba.Visible = false;
            tbba.Visible = false;
            lbbr.Visible = false;
            tbbr.Visible = false;
            lbbg.Visible = false;
            tbbg.Visible = false;
            lbbb.Visible = false;
            tbbb.Visible = false;
            lbln.Visible = true;
            tbln.Visible = true;
            if (isRadial)
                lblRadial.Visible = true;
            else
                lblRadial.Visible = false;
        }

        private void backgroundColorSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devicelist.Visible = false;
            lba.Visible = false;
            tba.Visible = false;
            lbr.Visible = false;
            tbr.Visible = false;
            lbg.Visible = false;
            tbg.Visible = false;
            lbb.Visible = false;
            tbb.Visible = false;
            lbba.Visible = true;
            tbba.Visible = true;
            lbbr.Visible = true;
            tbbr.Visible = true;
            lbbg.Visible = true;
            tbbg.Visible = true;
            lbbb.Visible = true;
            tbbb.Visible = true;
            lbln.Visible = false;
            tbln.Visible = false;
            lblRadial.Visible = false;
        }

        private void tba_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(tba.Text, out a);
        }

        private void tbr_TextChanged(object sender, EventArgs e)
        {
            if (!isChanging && !isRainbow)
            {
                int.TryParse(tbr.Text, out r);
            }
        }

        private void tbg_TextChanged(object sender, EventArgs e)
        {
            if (!isChanging && !isRainbow)
            {
                int.TryParse(tbg.Text, out g);
            }
        }

        private void tbb_TextChanged(object sender, EventArgs e)
        {
            if (!isChanging && !isRainbow)
            {
                int.TryParse(tbb.Text, out b);
            }
        }

        private void staticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isChanging = false;
            isRainbow = false;
            int.TryParse(tba.Text, out a);
            int.TryParse(tbr.Text, out r);
            int.TryParse(tbg.Text, out g);
            int.TryParse(tbb.Text, out b);
        }

        private void rainbowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r = 255; g = 0; b = 0; rainb = 0;
            isChanging = false;
            isRainbow = true;
        }

        private void slowChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            chart1.Series["wave"].Points.Clear();
            Thread.Sleep(20);
            diff = 5;
            isRainbow = false;
            isChanging = true;
            for (int i = 0; i < chart1.ChartAreas["ChartArea1"].AxisX.Maximum - 1; i++)
                chart1.Series["wave"].Points.Add(0);
            timer1.Start();
        }

        private void fastChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            chart1.Series["wave"].Points.Clear();
            Thread.Sleep(20);
            diff = 9;
            isRainbow = false;
            isChanging = true;
            for (int i = 0; i < chart1.ChartAreas["ChartArea1"].AxisX.Maximum - 1; i++)
                chart1.Series["wave"].Points.Add(0);
            timer1.Start();
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isRadial = false;
            tbln.Enabled = true;
            lblRadial.Visible = false;
            chart1.Series[0].ChartType = SeriesChartType.Spline;
            chart1.Top = 87;
            chart1.Left = 13;
            chart1.Width = Width - 46;
            chart1.Height = Height - 137;
        }

        private void columnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isRadial = false;
            tbln.Enabled = true;
            lblRadial.Visible = false;
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Top = 87;
            chart1.Left = 13;
            chart1.Width = Width - 46;
            chart1.Height = Height - 137;
        }

        private void radialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            tbln.Text = "64";
            tbln.Enabled = false;
            if (tbln.Visible)
                lblRadial.Visible = true;
            else
                lblRadial.Visible = false;
            isRadial = true;
            chart1.Series[0].ChartType = SeriesChartType.Radar;
            chart1.Height = 300 + int.Parse(tbln.Text) * 40;
            chart1.Width = 300 + int.Parse(tbln.Text) * 40;
            chart1.Top = 150 - int.Parse(tbln.Text) * 20;
            chart1.Left = 300 - int.Parse(tbln.Text) * 20;
            chart1.Series["wave"].Points.Add(0);
            Thread.Sleep(20);
            timer1.Start();
        }

        private void filledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbln.Enabled = true;
            isRadial = false;
            lblRadial.Visible = false;
            chart1.Series[0].ChartType = SeriesChartType.SplineRange;
            chart1.Top = 87;
            chart1.Left = 13;
            chart1.Width = Width - 46;
            chart1.Height = Height - 137;
        }

        private void withReflectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isReflected = true;
            timer1.Stop();
            chart1.Series["wave"].Points.Clear();
            _lines = int.Parse(tbln.Text) + 1;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = _lines * 2 - 1;
            if (isRadial)
            {
                chart1.Height = 300 + int.Parse(tbln.Text) * 40;
                chart1.Width = 300 + int.Parse(tbln.Text) * 40;
                chart1.Top = 150 - int.Parse(tbln.Text) * 20;
                chart1.Left = 300 - int.Parse(tbln.Text) * 20;
                chart1.Series["wave"].Points.Add(0);
            }
            timer1.Start();
            for (int i = 0; i < chart1.ChartAreas["ChartArea1"].AxisX.Maximum - 1; i++)
                chart1.Series["wave"].Points.Add(0);
        }

        private void withoutReflectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isReflected = false;
            timer1.Stop();
            chart1.Series["wave"].Points.Clear();
            _lines = int.Parse(tbln.Text) + 1;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = _lines;
            if (isRadial)
            {
                chart1.Height = 300 + int.Parse(tbln.Text) * 40;
                chart1.Width = 300 + int.Parse(tbln.Text) * 40;
                chart1.Top = 150 - int.Parse(tbln.Text) * 20;
                chart1.Left = 300 - int.Parse(tbln.Text) * 20;
                chart1.Series["wave"].Points.Add(0);
            }
            timer1.Start();
            for (int i = 0; i < chart1.ChartAreas["ChartArea1"].AxisX.Maximum - 1; i++)
                chart1.Series["wave"].Points.Add(0);
        }

        private void tbba_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(tbba.Text, out ba);
        }

        private void tbbr_TextChanged(object sender, EventArgs e)
        {
            if (!isbImage)
            {
                int.TryParse(tbbr.Text, out br);
            }
        }

        private void tbbg_TextChanged(object sender, EventArgs e)
        {
            if (!isbImage)
            {
                int.TryParse(tbbg.Text, out bg);
            }
        }

        private void tbbb_TextChanged(object sender, EventArgs e)
        {
            if (!isbImage)
            {
                int.TryParse(tbbb.Text, out bb);
            }
        }

        private void staticToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            isbImage = false;
            chart1.ChartAreas["ChartArea1"].BackImage = "";
            int.TryParse(tbba.Text, out ba);
            int.TryParse(tbbr.Text, out br);
            int.TryParse(tbbg.Text, out bg);
            int.TryParse(tbbb.Text, out bb);
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPG files|*.jpg|PNG files|*.png";
            open.FilterIndex = 1;
            if (open.ShowDialog() == DialogResult.OK)
            {
                chart1.ChartAreas["ChartArea1"].BackImage = open.FileName;
            }
        }

        private void tbln_TextChanged(object sender, EventArgs e)
        {
            int lines;
            if (int.TryParse(tbln.Text, out lines))
            {
                timer1.Stop();
                Thread.Sleep(100);
                chart1.Series["wave"].Points.Clear();
                if (lines > 64)
                {
                    tbln.Text = "64";
                    _lines = 65;
                }
                else
                {
                    _lines = lines + 1;
                }
                if (isReflected)
                {
                    chart1.ChartAreas["ChartArea1"].AxisX.Maximum = _lines * 2 - 1;
                }
                else
                {
                    chart1.ChartAreas["ChartArea1"].AxisX.Maximum = _lines;
                }
                timer1.Start();
                for (int i = 0; i < chart1.ChartAreas["ChartArea1"].AxisX.Maximum - 1; i++)
                {
                    chart1.Series["wave"].Points.Add(0);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BassWasapi.BASS_WASAPI_Stop(true);
            string[] array = (devicelist.Items[devicelist.SelectedIndex] as string).Split(' ');
            devindex = int.Parse(array[0]);
            if (!BassWasapi.BASS_WASAPI_Init(devindex, 0, 0, BASSWASAPIInit.BASS_WASAPI_BUFFER, 1f, 0.05f, process, IntPtr.Zero))
            {
                BASSError error = Bass.BASS_ErrorGetCode();
                if (error.ToString() != "BASS_ERROR_INIT")
                {
                    MessageBox.Show(error.ToString());
                }
            }
            BassWasapi.BASS_WASAPI_Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BassWasapi.BASS_WASAPI_GetData(fft, (int)BASSData.BASS_DATA_FFT8192) < -1) return;
            int num1 = 0;
            if (isChanging)
            {
                int colorToChange = rnd.Next(0, 3);
                if (colorToChange == 0)
                {
                    if (r < 10)
                        r += diff;
                    else if (r > 245 || rnd.Next(0, 2) == 1)
                        r -= diff;
                    else
                        r += diff;
                }
                if (colorToChange == 1)
                {
                    if (g < 10)
                        g += diff;
                    else if (g > 245 || rnd.Next(0, 2) == 1)
                        g -= diff;
                    else
                        g += diff;
                }
                if (colorToChange == 2)
                {
                    if (b < 10)
                        b += diff;
                    else if (b > 245 || rnd.Next(0, 2) == 1)
                        b -= diff;
                    else
                        b += diff;
                }
            }
            else if (isRainbow)
            {
                if (rainb == 306)
                    rainb = 0;
                if (rainb >= 0 && rainb < 51)
                    g += 5;
                else if (rainb < 102)
                    r -= 5;
                else if (rainb < 153)
                    b += 5;
                else if (rainb < 204)
                    g -= 5;
                else if (rainb < 255)
                    r += 5;
                else if (rainb < 306)
                    b -= 5;
                rainb++;
            }
            for (int i = 0; i < _lines; i++)
            {
                float max_val = 0;
                int value = (int)Math.Pow(2, i * 10.0 / (_lines - 1));
                if (value > 1023)
                    value = 1023;
                if (value <= num1)
                    value = num1 + 1;
                for (; num1 < value; ++num1)
                {
                    if (max_val < fft[1 + num1])
                        max_val = fft[1 + num1];
                }
                int num4 = (int)(Math.Sqrt(max_val) * 3 * 255 - 4.0);
                if (num4 < 0)
                    num4 = 0;
                if (num4 > 315)
                    num4 = 315; 
                byt1[i] = num4 * 6;
                byt1[_lines * 2 - i - 1] = num4 * 6;
            }
            int max;
            if (isReflected)
            {
                max = _lines * 2 - 1;
            }
            else
            {
                max = _lines;
            }
            for (int i = 0; i < max; i++)
            {
                try
                {
                    chart1.Series["wave"].Color = Color.FromArgb(a, r, g, b);
                    chart1.ChartAreas["ChartArea1"].BackColor = Color.FromArgb(ba, br, bg, bb);
                    chart1.Series["wave"].Points.Add(byt1[i]);
                    chart1.Series["wave"].Points.RemoveAt(0);
                }
                catch (Exception)
                {
                    if (a > 255 || a < 0) a = 255;
                    if (r > 255 || r < 0) r = 0;
                    if (g > 255 || g < 0) g = 0;
                    if (b > 255 || b < 0) b = 0;
                    if (ba > 255 || ba < 0) ba = 255;
                    if (br > 255 || br < 0) br = 255;
                    if (bg > 255 || bg < 0) bg = 255;
                    if (bb > 255 || bb < 0) bb = 255;
                }
            }
        }
    }
}
