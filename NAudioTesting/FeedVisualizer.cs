using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace NAudioTesting
{
    public partial class FeedVisualizer : UserControl
    {
        public WaveFormat format;

        public FeedVisualizer()
        {
            InitializeComponent();
            savedMap = new (float min, float max)[Width];
        }
        public float bufferTime = 5;

        public (float min, float max)[] savedMap;
        public int position = 0;
        int partialDataProgress = 0;
        public int samplesPerPixel;


        protected override void OnPaint(PaintEventArgs e)
        {
            (float min, float max)[] tempMap = new (float min, float max)[savedMap.Length];
            for(int i = 0; i < savedMap.Length; i++)
            {
                tempMap[i] = savedMap[(position + i) % savedMap.Length];
            }
            for (int x = e.ClipRectangle.X; x < e.ClipRectangle.Right; x++)
            {
                if (savedMap != null && x < tempMap.Length)
                {
                    e.Graphics.DrawLine(Pens.Black, x, Height * tempMap[x].min, x, Height * tempMap[x].max);
                }
            }
            base.OnPaint(e);
        }

        public void ClearDisplayMap()
        {
            savedMap = new (float min, float max)[Width];
        }

        List<byte> partialData = new List<byte>();
        int bytesPerPixel
        {
            get
            {
                return (int)(bufferTime / Width * format.AverageBytesPerSecond);
            }
        }
        public void newPartialData(byte[] data, int offset, int count)
        {
            partialData.AddRange(data);
            if(partialData.Count >= bytesPerPixel)
            {
                addNewData(partialData.GetRange(0, bytesPerPixel).ToArray(), 0, bytesPerPixel);
                partialData.RemoveRange(0, bytesPerPixel);
            }
        }
        //Changing output speaker breaks this
        public void addNewData(byte[] data, int offset, int count)
        {
            int bytesPerPixel = (int)(bufferTime / Width * format.AverageBytesPerSecond);
            int pixelsToProcess = data.Length / bytesPerPixel;
            for (int i = 0; i < pixelsToProcess; i++)
            {
                byte[] pixelData = new byte[bytesPerPixel];
                for(int j = bytesPerPixel * i; j < bytesPerPixel +1; j++)
                {
                    pixelData[i / bytesPerPixel] = data[j];
                }
                short low = 0;
                short high = 0;
                for (int n = 0; n < data.Length; n += 2)
                {
                    short sample = BitConverter.ToInt16(data, n);
                    if (sample < low) low = sample;
                    if (sample > high) high = sample;
                }
                float lowPercent = ((((float)low) - short.MinValue) / ushort.MaxValue);
                float highPercent = ((((float)high) - short.MinValue) / ushort.MaxValue);//Seems to pick up a lot of lound notes that arent there
                if(lowPercent < 0 || highPercent > 1)
                {

                }
                savedMap[position].min = lowPercent;
                savedMap[position].max = highPercent;
                position++;
                position %= savedMap.Length;
            }
            Invalidate();
        }
    }
}
