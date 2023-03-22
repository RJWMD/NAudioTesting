using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnagFree.TrayApp.Core;

namespace NAudioTesting
{
    public partial class KeybindSetter : Form
    {
        //public Func<GlobalKeyboardHook> tester;
        public KeybindSetter()
        {
            InitializeComponent();
        }

        private void StartBind_Click(object sender, EventArgs e)
        {

        }

        private void SaveBind_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
