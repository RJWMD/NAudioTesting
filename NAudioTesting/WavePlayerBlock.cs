﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace NAudioTesting
{
    namespace GridElements
    {
        public partial class WavePlayerBlock : UserControl
        {
            WavePlayer wavePlayer;

            public WavePlayerBlock()
            {
                InitializeComponent();
                wavePlayer = new WavePlayer(Program.audioHandler);
            }

            private void button1_Click(object sender, EventArgs e)
            {
                wavePlayer.playWave();
            }

            private void numericUpDown1_ValueChanged(object sender, EventArgs e)
            {
                wavePlayer.pitch = (int)PitchController.Value;
            }

            private void WaveTypeController_SelectedIndexChanged(object sender, EventArgs e)
            {
                wavePlayer.soundType = WaveTypeController.SelectedIndex;
            }

            private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
            {
                wavePlayer.duration = (double)DurationController.Value;
            }

            private void DurationCheckbox_CheckedChanged(object sender, EventArgs e)
            {
                wavePlayer.limitedDuration = DurationCheckbox.Checked;
            }

            private void WavePlayerBlock_Paint(object sender, PaintEventArgs e)
            {
                using (Bitmap bitMap = new Bitmap(BackgroundImage))
                {
                    ColorMap colorMap = new ColorMap();
                    colorMap.OldColor = Color.FromArgb(255, 223, 113, 38);
                    colorMap.NewColor = Color.FromArgb(255, 99, 155, 255);
                    ImageAttributes img = new ImageAttributes();
                    ColorMap[] mapArray = { colorMap };

                    img.SetRemapTable(mapArray);
                    e.Graphics.DrawImage(bitMap, new Rectangle(0, 0, Width, Height), 0, 0, bitMap.Width, bitMap.Height, GraphicsUnit.Pixel, img);

                }
            }
        }
    }
}
