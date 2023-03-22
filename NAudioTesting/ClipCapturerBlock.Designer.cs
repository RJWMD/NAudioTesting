
namespace NAudioTesting
{
    namespace GridElements
    {
        partial class ClipCapturerBlock
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
            this.Capture = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.CaptureSave = new System.Windows.Forms.Button();
            this.ClipLength = new System.Windows.Forms.NumericUpDown();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.feedVisualizer1 = new NAudioTesting.FeedVisualizer();
            ((System.ComponentModel.ISupportInitialize)(this.ClipLength)).BeginInit();
            this.SuspendLayout();
            // 
            // Capture
            // 
            this.Capture.Location = new System.Drawing.Point(54, 59);
            this.Capture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Capture.Name = "Capture";
            this.Capture.Size = new System.Drawing.Size(117, 32);
            this.Capture.TabIndex = 0;
            this.Capture.Text = "Capture";
            this.Capture.UseVisualStyleBackColor = true;
            this.Capture.Click += new System.EventHandler(this.Capture_Click);
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(366, 82);
            this.Label.TabIndex = 4;
            this.Label.Text = "Clip capturer";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label.Paint += new System.Windows.Forms.PaintEventHandler(this.Label_Paint);
            // 
            // CaptureSave
            // 
            this.CaptureSave.Location = new System.Drawing.Point(195, 59);
            this.CaptureSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CaptureSave.Name = "CaptureSave";
            this.CaptureSave.Size = new System.Drawing.Size(119, 32);
            this.CaptureSave.TabIndex = 5;
            this.CaptureSave.Text = "Save Capture";
            this.CaptureSave.UseVisualStyleBackColor = true;
            this.CaptureSave.Click += new System.EventHandler(this.CaptureSave_Click);
            // 
            // ClipLength
            // 
            this.ClipLength.Location = new System.Drawing.Point(206, 95);
            this.ClipLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClipLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ClipLength.Name = "ClipLength";
            this.ClipLength.Size = new System.Drawing.Size(68, 26);
            this.ClipLength.TabIndex = 6;
            this.ClipLength.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.ClipLength.ValueChanged += new System.EventHandler(this.ClipLength_ValueChanged);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.BackColor = System.Drawing.Color.Transparent;
            this.LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LengthLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LengthLabel.Location = new System.Drawing.Point(88, 97);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(83, 20);
            this.LengthLabel.TabIndex = 7;
            this.LengthLabel.Text = "Clip length";
            // 
            // feedVisualizer1
            // 
            this.feedVisualizer1.BackColor = System.Drawing.SystemColors.Control;
            this.feedVisualizer1.Location = new System.Drawing.Point(54, 125);
            this.feedVisualizer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feedVisualizer1.Name = "feedVisualizer1";
            this.feedVisualizer1.Size = new System.Drawing.Size(260, 58);
            this.feedVisualizer1.TabIndex = 8;
            // 
            // ClipCapturerBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::NAudioTesting.Properties.Resources.SoundBoardToolSlotFilePlayer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.feedVisualizer1);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.ClipLength);
            this.Controls.Add(this.CaptureSave);
            this.Controls.Add(this.Capture);
            this.Controls.Add(this.Label);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClipCapturerBlock";
            this.Size = new System.Drawing.Size(366, 218);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ClipCapturerBlock_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ClipLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Button Capture;
            private System.Windows.Forms.Label Label;
            private System.Windows.Forms.Button CaptureSave;
            private System.Windows.Forms.NumericUpDown ClipLength;
            private System.Windows.Forms.Label LengthLabel;
            private FeedVisualizer feedVisualizer1;
        }
    }
}
