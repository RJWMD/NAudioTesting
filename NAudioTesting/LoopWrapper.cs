using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.MediaFoundation;
using NAudio.Wave;


namespace NAudioTesting
{
    public class LoopWrapper : WaveStream
    {
        public WaveStream sourceStream;
        public bool looping = false;
        public override long Length
        {
            get { return sourceStream.Length; }
        }
        public override long Position
        {
            get{return sourceStream.Position;}
            set{sourceStream.Position = value;}
        }
        public float startPoint = 0;
        public float endPoint = 1;

        public LoopWrapper(WaveStream source)
        {
            sourceStream = source;
        }
        
        //Has significant delay before restarting loop (half a second-ish)
        public override int Read(byte[] buffer, int offset, int count)
        {

            //if (!looping)
            //    return sourceStream.Read(buffer, offset, count);
            int totalBytesRead = 0;
            while (totalBytesRead < count)
            {
                //Change the 2 to a 1 for some loud glitchy sounds on some loops
                int bytesRead = sourceStream.Read(buffer, offset + totalBytesRead,  2);
                if (Position > (endPoint * Length) || bytesRead == 0)
                {
                    if (looping)
                        Position = (long)(startPoint * Length);
                    else
                        break;
                }
                //if (!looping && bytesRead == 0)
                //{
                //    break;
                //}
                totalBytesRead += bytesRead;
            }
            return totalBytesRead;
            if (Position > (endPoint * Length))
            {
                Position = (long)(startPoint * Length);
                //Position = (long)((Position % ((endPoint - startPoint) * Length)) + (startPoint * Length));
                return sourceStream.Read(buffer, offset, count);
            }
            else
            {
                return sourceStream.Read(buffer, offset, count);
            }
            //int totalBytesRead = 0;

            //while (totalBytesRead < count)
            //{
            //    int bytesRead = sourceStream.Read(buffer, offset + totalBytesRead, count - totalBytesRead);
            //    if (bytesRead == 0 || (endPoint * Length) < Position)
            //    {
            //        if (sourceStream.Position == 0 || !looping)
            //        {
            //            // something wrong with the source stream
            //            break;
            //        }
            //        // loop
            //        sourceStream.Position = 0;
            //    }
            //    totalBytesRead += bytesRead;
            //}
            //return totalBytesRead;
        }
        public override WaveFormat WaveFormat
        {
            get { return sourceStream.WaveFormat; }
        }

    }
}
