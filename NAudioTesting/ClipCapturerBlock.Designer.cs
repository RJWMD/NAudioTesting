
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.Capture.Location = new System.Drawing.Point(17, 34);
            this.Capture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Capture.Name = "Capture";
            this.Capture.Size = new System.Drawing.Size(104, 26);
            this.Capture.TabIndex = 0;
            this.Capture.Text = "Capture";
            this.Capture.UseVisualStyleBackColor = true;
            this.Capture.Click += new System.EventHandler(this.Capture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clip capturer";
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(271, 31);
            this.Label.TabIndex = 4;
            this.Label.Text = "Clip capturer";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CaptureSave
            // 
            this.CaptureSave.Location = new System.Drawing.Point(140, 33);
            this.CaptureSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CaptureSave.Name = "CaptureSave";
            this.CaptureSave.Size = new System.Drawing.Size(106, 26);
            this.CaptureSave.TabIndex = 5;
            this.CaptureSave.Text = "Save Capture";
            this.CaptureSave.UseVisualStyleBackColor = true;
            this.CaptureSave.Click += new System.EventHandler(this.CaptureSave_Click);
            // 
            // ClipLength
            // 
            this.ClipLength.Location = new System.Drawing.Point(140, 60);
            this.ClipLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClipLength.Name = "ClipLength";
            this.ClipLength.Size = new System.Drawing.Size(60, 22);
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
            this.LengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LengthLabel.Location = new System.Drawing.Point(61, 62);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(74, 17);
            this.LengthLabel.TabIndex = 7;
            this.LengthLabel.Text = "Clip length";
            // 
            // feedVisualizer1
            // 
            this.feedVisualizer1.BackColor = System.Drawing.SystemColors.Control;
            this.feedVisualizer1.Location = new System.Drawing.Point(15, 86);
            this.feedVisualizer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feedVisualizer1.Name = "feedVisualizer1";
            this.feedVisualizer1.Size = new System.Drawing.Size(231, 46);
            this.feedVisualizer1.TabIndex = 8;
            // 
            // ClipCapturerBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.feedVisualizer1);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.ClipLength);
            this.Controls.Add(this.CaptureSave);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Capture);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ClipCapturerBlock";
            this.Size = new System.Drawing.Size(271, 145);
            ((System.ComponentModel.ISupportInitialize)(this.ClipLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Button Capture;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Label Label;
            private System.Windows.Forms.Button CaptureSave;
            private System.Windows.Forms.NumericUpDown ClipLength;
            private System.Windows.Forms.Label LengthLabel;
            private FeedVisualizer feedVisualizer1;
        }
    }
}
