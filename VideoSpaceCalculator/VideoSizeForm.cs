using System;
using System.Windows.Forms;

namespace VideoSpaceCalculator
{
    public partial class Form1 : Form
    {
        public double videoSize;
        public double audioSize;
        public double totalVideoSize;
        public double totalAudioSize;
        public double totalMaterialSize;
        public double totalSeconds;
        public string sizeType = "";
        public double hertz;
        public double audioChannel;
        public double bit;
        public double totalBitRate;

        public Form1()
        {
            InitializeComponent();
            SelectedIndex();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public void SelectedIndex()
        {
            cmbAudioBitRate.SelectedIndex = 0;
            cmbAudioChannel.SelectedIndex = 1;
            cmbFrame.SelectedIndex = 0;
            cmbVideoType.SelectedIndex = 0;
            cmbHertz.SelectedIndex = 0;

        }

        private void cmbVideoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVideoType.SelectedIndex == 0)
            {
                cmbFrame.SelectedIndex = 0;
                cmbFrame.Enabled = false;

            }        
        }
        //Audio
        public double calculateAudioSize(double audioChannel, double hertz, double bit)
        {
            if (MB.Checked)
            {
                audioSize = (audioChannel * hertz * 1000 * bit) / 8;
                audioSize = audioSize / 1024;
                audioSize = audioSize / 1024;

            }
            else if (GB.Checked)
            {
                audioSize = (audioChannel * hertz * 1000 * bit) / 8;
                audioSize = audioSize / 1024;
                audioSize = audioSize / 1024;
                audioSize = audioSize / 1024;
            }
            else if (TB.Checked)
            {

                audioSize = (audioChannel * hertz * 1000 * bit) / 8;
                audioSize = audioSize / 1024;
                audioSize = audioSize / 1024;
                audioSize = audioSize / 1024;
                audioSize = audioSize / 1024;
            }
            else
            {
            }
            return audioSize;
        }

        //Second
        public double totalSecond()
        {
            totalSeconds = ((Convert.ToDouble(txtDay.Text)) * 86400) + (Convert.ToDouble(txtHour.Text) * 3600) + (Convert.ToDouble(txtMinute.Text) * 60) + (Convert.ToDouble(txtSec.Text) * 1);
            return totalSeconds;
        }

        //Video Calculate
        private double calculateVideoSize(double videoType)
        {
            if (MB.Checked)
            {

                videoSize = (totalSecond() * videoType) / 1024;
                videoSize = videoSize / 1024;
                sizeType = "MB";
            }
            else if (GB.Checked)
            {
                videoSize = (totalSecond() * videoType) / 1024;
                videoSize = videoSize / 1024;
                videoSize = videoSize / 1024;
                sizeType = "GB";
            }
            else if (TB.Checked)
            {
                videoSize = (totalSecond() * videoType) / 1024;
                videoSize = videoSize / 1024;
                videoSize = videoSize / 1024;
                videoSize = videoSize / 1024;
                sizeType = "TB";
            }

            else
            { }


            return videoSize;
        }
        private void calculatingTotalSize()
        {
            //VideoCalculating          

            if (cmbVideoType.SelectedIndex == 0)
            {
                totalVideoSize = calculateVideoSize(2250000);
            }
            else if (cmbVideoType.SelectedIndex == 1)
            {
                totalVideoSize = calculateVideoSize(3125000);

            }
            else if (cmbVideoType.SelectedIndex == 2)
            {
                totalVideoSize = calculateVideoSize(4375000);
            }
            else if (cmbVideoType.SelectedIndex == 3)
            {
                totalVideoSize = calculateVideoSize(6250000);

            }
            else if (cmbVideoType.SelectedIndex == 4)
            {
                totalVideoSize = calculateVideoSize(3750000);
            }
            else if (cmbVideoType.SelectedIndex == 5)
            {
                totalVideoSize = calculateVideoSize(5000000);
            }
            else if (cmbVideoType.SelectedIndex == 6)
            {
                totalVideoSize = calculateVideoSize(6250000);
            }
            else if (cmbVideoType.SelectedIndex == 7)
            {
                totalVideoSize = calculateVideoSize(3125000);
            }
            else
            { }

            //Audio Calculating

            //Hertz
            if (cmbHertz.SelectedIndex == 0)
                hertz = 32;
            else if (cmbHertz.SelectedIndex == 1)
                hertz = 48;
            else if (cmbHertz.SelectedIndex == 2)
                hertz = 96;
            else
            { }
            //bit
            if (cmbAudioBitRate.SelectedIndex == 0)
                bit = 16;
            else if (cmbAudioBitRate.SelectedIndex == 1)
                bit = 24;
            //Channel 
            if (cmbAudioChannel.SelectedIndex == 0)
            {
                totalAudioSize = 0;
            }
            else if (cmbAudioChannel.SelectedIndex == 1)
            {
                audioChannel = 2;
            }
            else if (cmbAudioChannel.SelectedIndex == 2)
            {
                audioChannel = 4;
            }
            else if (cmbAudioChannel.SelectedIndex == 3)
            {
                audioChannel = 6;
            }
            else if (cmbAudioChannel.SelectedIndex == 4)
            {
                audioChannel = 8;
            }
            else
            { }

            totalAudioSize = totalSecond() * calculateAudioSize(audioChannel, hertz, bit);
            totalMaterialSize = totalVideoSize + totalAudioSize;
            result.Text = totalMaterialSize.ToString() + " " + sizeType;
        }

        //Manual Fps Video Calculate
        private double calculateManualVideoSize(double xLines, double yLines, double fps)
        {
            if (MB.Checked)
            {

                videoSize = (totalSecond() * xLines * yLines * fps) / (8 * 1024);
                videoSize = videoSize / 1024;
                sizeType = "MB";
            }
            else if (GB.Checked)
            {
                videoSize = (totalSecond() * xLines * yLines * fps) / (8 * 1024);
                videoSize = videoSize / 1024;
                videoSize = videoSize / 1024;
                sizeType = "GB";
            }
            else if (TB.Checked)
            {
                videoSize = (totalSecond() * xLines * yLines * fps) / (8 * 1024);
                videoSize = videoSize / 1024;
                videoSize = videoSize / 1024;
                videoSize = videoSize / 1024;
                sizeType = "TB";
            }

            else
            { }
            return videoSize;
        }

        private void calculatingManualBitRateTotalSize()
        {          
            //VideoCalculating  
            double fps = 0;
            double xLines = 0;
            double yLines = 0;
            if (cmbFrame.SelectedIndex == 0)
            {
                fps = 0;
            }
            else if (cmbFrame.SelectedIndex == 1)
            {
                fps = 23.98;
            }
            else if (cmbFrame.SelectedIndex == 2)
            {
                fps = 24;
            }
            else if (cmbFrame.SelectedIndex == 3)
            {
                fps = 25;
            }
            else if (cmbFrame.SelectedIndex == 4)
            {
                fps = 29.97;
            }
            else if (cmbFrame.SelectedIndex == 5)
            {
                fps = 30;
            }
            else if (cmbFrame.SelectedIndex == 6)
            {
                fps = 50;
            }
            else if (cmbFrame.SelectedIndex == 7)
            {
                fps = 59.94;
            }
            else if (cmbFrame.SelectedIndex == 6)
            {
                fps = 59.94;
            }
            else
            { }



            if (cmbVideoType.SelectedIndex == 0)
            {
                xLines = 1920;
                yLines = 1080;
            }
            else if (cmbVideoType.SelectedIndex == 1)
            {
                xLines = 1920;
                yLines = 1080;
            }
            else if (cmbVideoType.SelectedIndex == 2)
            {
                xLines = 1920;
                yLines = 1080;
            }
            else if (cmbVideoType.SelectedIndex == 3)
            {
                totalVideoSize = calculateVideoSize(6250000);

            }
            else if (cmbVideoType.SelectedIndex == 4)
            {
                totalVideoSize = calculateVideoSize(3750000);
            }
            else if (cmbVideoType.SelectedIndex == 5)
            {
                totalVideoSize = calculateVideoSize(5000000);
            }
            else if (cmbVideoType.SelectedIndex == 6)
            {
                totalVideoSize = calculateVideoSize(6250000);
            }
            else if (cmbVideoType.SelectedIndex == 7)
            {
                totalVideoSize = calculateVideoSize(3125000);
            }
            else
            { }
            totalVideoSize = calculateManualVideoSize(xLines, yLines, fps);

            //Audio Calculating

            //Hertz
            if (cmbHertz.SelectedIndex == 0)
                hertz = 32;
            else if (cmbHertz.SelectedIndex == 1)
                hertz = 48;
            else if (cmbHertz.SelectedIndex == 2)
                hertz = 96;
            else
            { }
            //bit
            if (cmbAudioBitRate.SelectedIndex == 0)
                bit = 16;
            else if (cmbAudioBitRate.SelectedIndex == 1)
                bit = 24;
            //Channel 
            if (cmbAudioChannel.SelectedIndex == 0)
            {
                totalAudioSize = 0;
            }
            else if (cmbAudioChannel.SelectedIndex == 1)
            {
                audioChannel = 2;
            }
            else if (cmbAudioChannel.SelectedIndex == 2)
            {
                audioChannel = 4;
            }
            else if (cmbAudioChannel.SelectedIndex == 3)
            {
                audioChannel = 6;
            }
            else if (cmbAudioChannel.SelectedIndex == 4)
            {
                audioChannel = 8;
            }
            else
            { }

            totalAudioSize = totalSecond() * calculateAudioSize(audioChannel, hertz, bit);
            totalMaterialSize = totalVideoSize + totalAudioSize;
            result.Text = totalMaterialSize.ToString() + sizeType;

        }

        //Calculate Button
        private void button1_Click(object sender, EventArgs e)
        {
      
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cmbFrame.Enabled = true;

            }
            else
            {
                cmbFrame.Enabled = false;
            }
        }

    

        private void cmbAudioChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAudioChannel.SelectedIndex == 0)
            {
                cmbHertz.Enabled = false;
                cmbAudioBitRate.Enabled = false;
            }
            else
            {
                cmbHertz.Enabled = true;
                cmbAudioBitRate.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                calculatingManualBitRateTotalSize();
            }
            else
            {
                calculatingTotalSize();
            }
        }
    }
}
