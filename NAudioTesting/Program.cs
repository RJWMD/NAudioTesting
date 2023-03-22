using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace NAudioTesting
{
    static class Program
    {
        public static AudioHandler audioHandler = new AudioHandler();
        public static List<LoopRequest> loops = new List<LoopRequest>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            audioHandler.setUpMixer();
            Application.Run(new MainForm());
        }
    }
}
