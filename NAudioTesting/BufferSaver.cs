using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using System.IO;

namespace NAudioTesting
{
    public class BufferSaver : IWaveProvider
    {
        public IWaveProvider input;
        public byte[] savedBuffer;
        public float bufferLength = 5;
        int bufferLocation;
        public Action<byte[], int, int> newDataChunk;
        public Action<byte[], int, int> newData;
        public Action<byte[], int, int> sampleCompleted;
        //public RawSourceWaveStream buffer;

        public WaveFormat WaveFormat
        {
            get { return input.WaveFormat; }
        }
        public BufferSaver(IWaveProvider input)
        {
            this.input = input;
            savedBuffer = new byte[(int)(bufferLength * input.WaveFormat.AverageBytesPerSecond)];
        }
        //public BufferSaver(ISampleProvider input)
        //{
        //    this.input = input;
        //    int bufferLengthBytes = (int)(bufferLength * input.WaveFormat.AverageBytesPerSecond);
        //    savedBuffer = new byte[bufferLengthBytes];
        //    otherBufferTEMP = new float[bufferLengthBytes / 2];
        //}
        public int Read(byte[] buffer, int offset, int count)
        {
            //int bytesRead = 0;
            for (int i = 0; i < buffer.Length; i++)
            {
                //if(buffer[convertedBuffer[i]] != 0)
                //{
                //    int num = convertedBuffer[i];
                //}
                savedBuffer[bufferLocation] = buffer[i];//(int)buffer[i];
                bufferLocation++;
                bufferLocation %= savedBuffer.Length;
                //bytesRead += input.Read(buffer, bytesRead + offset, 2);
                //if (i > 0 && i % 2 == 0)
                //    newData?.Invoke(new byte[] { buffer[i -1], buffer[i] }, 0, 1);
            }
            newDataChunk?.Invoke(buffer, offset, count);
            return input.Read(buffer, offset, count);
           // return bytesRead;
        }

        public RawSourceWaveStream exportBuffer()
        {
            //return null;
            //byte[] tempBuffer = new byte[savedBuffer.Length];//change the buffer so that 0 is oldest part
            //for (int i = 0; i < tempBuffer.Length; i++)
            //{
            //    tempBuffer[i] = savedBuffer[(bufferLocation + i + 1) % tempBuffer.Length];
            //}
            byte[] tempBuffer = savedBuffer;
            //MemoryStream tempStream = new MemoryStream(tempBuffer);
            MemoryStream tempStream = new MemoryStream();
            tempStream.Write(tempBuffer, bufferLocation, tempBuffer.Length - bufferLocation);
            tempStream.Write(tempBuffer, 0, bufferLocation);
            RawSourceWaveStream returnStream = new RawSourceWaveStream(tempStream, WaveFormat);
            returnStream.Position = 0;
            return returnStream;
        }
    }
}
