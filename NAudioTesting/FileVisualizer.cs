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
using NAudio.Dsp;
using System.Drawing.Drawing2D;

namespace NAudioTesting
{
    public partial class FileVisualizer : UserControl
    {
        public Action<MouseEventArgs> clicked;
        private int bytesPerSample;
        public WaveStream waveStream;
        public WaveStream WaveStream
        {
            get { return waveStream; }
            set 
            {
                waveStream = value; 
                if(WaveStream != null)
                {
                    bytesPerSample = (WaveStream.WaveFormat.BitsPerSample / 8) * WaveStream.WaveFormat.Channels;
                }
            }
        }
        int samplesPerPixel = 128;
        public LoopWrapper stream;
        Graphics g;

        public FileVisualizer()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void waveViewer1_Click(object sender, EventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e;
            clicked?.Invoke(args);
        }
        public DateTime startTime = DateTime.Now;
        public bool looping = false;
        //Add a way for more than 1 tracker to exist at once
        public bool updateTracker()
        {
            if (stream == null || stream.TotalTime.TotalMilliseconds == 0)
                return true;
            int xPosition = (int)((((((DateTime.Now - startTime).TotalMilliseconds) / (stream.TotalTime.TotalMilliseconds)) 
                                    % (1 * (endPosition - startPosition))) + startPosition) * Width);
            fillArea = new Rectangle(xPosition, 0, 10, Height);
            Invalidate(repaintRectangle);
            lastBarUpdate = DateTime.Now;
            return (stream.TotalTime.TotalMilliseconds * (endPosition - startPosition)) - (DateTime.Now - startTime).TotalMilliseconds < 12 && !looping;
        }
        //Make it so that there can be multiple track bars for when stacking is enabled, and that clicking adds a new one
        Rectangle repaintRectangle;
        Rectangle fillArea;
        DateTime lastBarUpdate = DateTime.Now;
        (float min, float max)[] savedMap;

        public void generateMap()
        {
            if (WaveStream == null)
                return;
            savedMap = new (float min, float max)[Width];
            int bytesRead;
            byte[] waveData = new byte[samplesPerPixel * bytesPerSample];
            for (int x = 0; x < savedMap.Length; x++)
            {
                float progress = x * 1f / Width;
                WaveStream.Position = (int)(WaveStream.Length * progress);
                bytesRead = WaveStream.Read(waveData, 0, samplesPerPixel * bytesPerSample);
                if (bytesRead == 0)
                    break;
                short low = 0;
                short high = 0;
                for (int n = 0; n < bytesRead; n += 2)
                {
                    short sample = BitConverter.ToInt16(waveData, n);
                    if (sample < low) low = sample;
                    if (sample > high) high = sample;
                }
                float lowPercent = ((((float)low) - short.MinValue) / ushort.MaxValue);
                float highPercent = ((((float)high) - short.MinValue) / ushort.MaxValue);
                savedMap[x].min = lowPercent;
                savedMap[x].max = highPercent;
            }
        }

        //GraphicsState savedState;
        //Resizing causes major lag
        ///TODO: change this to read from a saved image, as running this takes up substantial cpu usage.
        ///Maybe even make it just read and write to an array of length width and have each part be the mins and max.

        protected override void OnPaint(PaintEventArgs e)
        {
            if (WaveStream != null)
            {
                for(int x = e.ClipRectangle.X; x < e.ClipRectangle.Right; x++)
                {
                    if(savedMap == null && WaveStream != null)
                    {
                        generateMap();
                    }
                    if(x < savedMap.Length)
                    {
                        e.Graphics.DrawLine(Pens.Black, x, Height * savedMap[x].min, x, Height * savedMap[x].max);
                    }
                }
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(150, 0, 255, 0)), fillArea);
                repaintRectangle = fillArea;
                repaintTrimSection = new Rectangle((int)(startPosition * Width), 0, (int)((endPosition - startPosition) * Width), Height);
                if(startPosition != 0 && endPosition != 1)
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(75, 0, 0, 0)), repaintTrimSection);
            }
            base.OnPaint(e);
        }
        public float startPosition
        {
            get 
            { 
                return stream != null ? stream.startPoint : 0; 
            }
            set 
            { 
                if(stream != null)
                    stream.startPoint = value; 
            }
        }
        public float endPosition
        {
            get 
            {
                return stream != null ? stream.endPoint : 1; 
            }
            set 
            { 
                if(stream != null)
                    stream.endPoint = value; 
            }
        }
        Rectangle repaintTrimSection;
        private void FileVisualizer_MouseDown(object sender, MouseEventArgs e)
        {
            startPosition = e.X * 1f / Width;
            if(startPosition == endPosition)
            {
                endPosition = startPosition + 1;
            }
            Invalidate(repaintTrimSection);
        }
        private void FileVisualizer_MouseUp(object sender, MouseEventArgs e)
        {
            //endPosition = e.X * 1f / Width;
        }
        private void FileVisualizer_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left && WaveStream != null && (int)(e.X * 1f/Width * WaveStream.Length) > (int)(startPosition * WaveStream.Length))
            {
                endPosition = e.X * 1f / Width;
                Invalidate(repaintTrimSection);
            }
        }
        private void FileVisualizer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            startPosition = 0;
            endPosition = 1;
        }
        private void FileVisualizer_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e;
            clicked?.Invoke(args);
        }

        public void DeleteData()
        {
            waveStream.Dispose();
            stream?.Dispose();
            stream?.Close();
            savedMap = null;
            stream = null;
            waveStream = null;
        }
        
    }
}
