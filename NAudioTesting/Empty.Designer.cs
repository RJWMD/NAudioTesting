
namespace NAudioTesting
{
    namespace GridElements
    {
        partial class Empty
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

            #region Component Designer generated code

            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                this.SuspendLayout();
                // 
                // GridElement
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.SystemColors.ControlDark;
                this.Name = "GridElement";
                this.Size = new System.Drawing.Size(305, 181);
                this.Click += new System.EventHandler(this.GridElement_Click);
                this.ResumeLayout(false);

            }

            #endregion
        }
    }
}
