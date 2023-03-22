using System;
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
        public partial class PitchShifterBlock : UserControl
        {
            PitchShifter pitchShifter;

            public PitchShifterBlock()
            {
                InitializeComponent();
                pitchShifter = new PitchShifter(Program.audioHandler);
            }

            private void trackBar1_Scroll(object sender, EventArgs e)
            {
                if (PitchAmountScroll.Value >= 100 && false)
                    pitchShifter.setPitchShift(PitchAmountScroll.Value / 100.0f);
                else
                {
                    if (PitchAmountScroll.Value > 0)
                    {
                        pitchShifter.setPitchShift((PitchAmountScroll.Value + 100) / 100.0f);
                    }
                    else
                        pitchShifter.setPitchShift((1 - (Math.Abs(PitchAmountScroll.Value) / 1000.0f)));
                }
                if (pitchShifter.amount > 0)
                    PitchShiftNum.Value = (decimal)pitchShifter.amount;
                else
                    PitchShiftNum.Value = PitchShiftNum.Minimum;
                if (ActiveCheckbox.Checked)
                    pitchShifter.updatePitchShift();
            }

            private void numericUpDown1_ValueChanged(object sender, EventArgs e)
            {
                pitchShifter.setPitchShift((float)PitchShiftNum.Value);
                int targetValue = 1;
                if (pitchShifter.amount >= 1)
                    targetValue = (int)((pitchShifter.amount - 1) * 100);
                else
                    targetValue = (int)(-Math.Abs(1000 - pitchShifter.amount * 1000)) + 1;
                if (targetValue < PitchAmountScroll.Minimum)
                    targetValue = PitchAmountScroll.Minimum;
                if (targetValue > PitchAmountScroll.Maximum)
                    targetValue = PitchAmountScroll.Maximum;
                PitchAmountScroll.Value = targetValue;
                if(ActiveCheckbox.Checked)
                    pitchShifter.updatePitchShift();
            }

            private void ActiveCheckbox_CheckedChanged(object sender, EventArgs e)
            {
                if(ActiveCheckbox.Checked)
                {
                    pitchShifter.applyPitchShift();
                }
                else
                {
                    pitchShifter.removePitchShift();
                }
            }

            private void PitchShifterBlock_Load(object sender, EventArgs e)
            {

            }

            private void PitchShifterBlock_Paint(object sender, PaintEventArgs e)
            {
                using (Bitmap bitMap = new Bitmap(BackgroundImage))
                {
                    ColorMap colorMap = new ColorMap();
                    colorMap.OldColor = Color.FromArgb(255, 223, 113, 38);
                    colorMap.NewColor = Color.FromArgb(255, 106, 190, 48);
                    ImageAttributes img = new ImageAttributes();
                    ColorMap[] mapArray = { colorMap };

                    img.SetRemapTable(mapArray);
                    e.Graphics.DrawImage(bitMap, new Rectangle(0, 0, Width, Height), 0, 0, bitMap.Width, bitMap.Height, GraphicsUnit.Pixel, img);

                }
            }
        }
    }
}
