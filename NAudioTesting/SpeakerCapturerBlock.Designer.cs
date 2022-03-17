
namespace NAudioTesting
{
    partial class SpeakerCapturerBlock
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
            this.SpeakerInputDropdown = new System.Windows.Forms.ComboBox();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.SpeakerInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SpeakerInputDropdown
            // 
            this.SpeakerInputDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.SpeakerInputDropdown.FormattingEnabled = true;
            this.SpeakerInputDropdown.Location = new System.Drawing.Point(19, 153);
            this.SpeakerInputDropdown.Name = "SpeakerInputDropdown";
            this.SpeakerInputDropdown.Size = new System.Drawing.Size(158, 25);
            this.SpeakerInputDropdown.TabIndex = 0;
            this.SpeakerInputDropdown.Text = "Choose speaker";
            // 
            // waveViewer1
            // 
            this.waveViewer1.BackColor = System.Drawing.SystemColors.ControlText;
            this.waveViewer1.Location = new System.Drawing.Point(19, 37);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 128;
            this.waveViewer1.Size = new System.Drawing.Size(268, 110);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 1;
            this.waveViewer1.WaveStream = null;
            // 
            // SpeakerInputLabel
            // 
            this.SpeakerInputLabel.AutoSize = true;
            this.SpeakerInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SpeakerInputLabel.Location = new System.Drawing.Point(68, 9);
            this.SpeakerInputLabel.Name = "SpeakerInputLabel";
            this.SpeakerInputLabel.Size = new System.Drawing.Size(156, 25);
            this.SpeakerInputLabel.TabIndex = 2;
            this.SpeakerInputLabel.Text = "Speaker capture";
            // 
            // SpeakerCapturerBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.SpeakerInputLabel);
            this.Controls.Add(this.waveViewer1);
            this.Controls.Add(this.SpeakerInputDropdown);
            this.Name = "SpeakerCapturerBlock";
            this.Size = new System.Drawing.Size(305, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SpeakerInputDropdown;
        private NAudio.Gui.WaveViewer waveViewer1;
        private System.Windows.Forms.Label SpeakerInputLabel;
    }
}
