using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAudioTesting
{
    static class Program
    {
        public static AudioHandler audioHandler = new AudioHandler();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            audioHandler.startRecording();
            audioHandler.setUpMixer();
            Application.Run(new MainForm());
            
        }
    }
}
