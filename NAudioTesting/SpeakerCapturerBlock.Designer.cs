
namespace NAudioTesting
{
    namespace GridElements
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
            this.SpeakerInputLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SpeakerInputDropdown
            // 
            this.SpeakerInputDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeakerInputDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.SpeakerInputDropdown.FormattingEnabled = true;
            this.SpeakerInputDropdown.Location = new System.Drawing.Point(19, 150);
            this.SpeakerInputDropdown.Name = "SpeakerInputDropdown";
            this.SpeakerInputDropdown.Size = new System.Drawing.Size(268, 28);
            this.SpeakerInputDropdown.TabIndex = 0;
            this.SpeakerInputDropdown.SelectedIndexChanged += new System.EventHandler(this.SpeakerInputDropdown_SelectedIndexChanged);
            this.SpeakerInputDropdown.MouseEnter += new System.EventHandler(this.SpeakerInputDropdown_MouseEnter);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(19, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 107);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SpeakerCapturerBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SpeakerInputLabel);
            this.Controls.Add(this.SpeakerInputDropdown);
            this.Name = "SpeakerCapturerBlock";
            this.Size = new System.Drawing.Size(305, 181);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.ComboBox SpeakerInputDropdown;
            private System.Windows.Forms.Label SpeakerInputLabel;
            private System.Windows.Forms.Panel panel1;
        }
    }
}
