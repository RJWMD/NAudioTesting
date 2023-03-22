
namespace NAudioTesting
{
    namespace GridElements
    {
        partial class TempFilePlayerBlock
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                this.components = new System.ComponentModel.Container();
                this.saveDialog = new System.Windows.Forms.SaveFileDialog();
                this.saveDialog.FileOk += saveFile;
                this.saveDialog.Filter = "wav files (*.wav)|*.wav";
            }

            #endregion

            private System.Windows.Forms.SaveFileDialog saveDialog;
        }
    }
}
