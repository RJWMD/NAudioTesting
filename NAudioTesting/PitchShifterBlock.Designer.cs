
namespace NAudioTesting
{
    namespace GridElements
    {
        partial class PitchShifterBlock
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
            this.PitchShifterLabel = new System.Windows.Forms.Label();
            this.PitchShiftNum = new System.Windows.Forms.NumericUpDown();
            this.PitchAmountScroll = new System.Windows.Forms.TrackBar();
            this.ActiveCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PitchShiftNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PitchAmountScroll)).BeginInit();
            this.SuspendLayout();
            // 
            // PitchShifterLabel
            // 
            this.PitchShifterLabel.AutoSize = true;
            this.PitchShifterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PitchShifterLabel.Location = new System.Drawing.Point(78, 8);
            this.PitchShifterLabel.Name = "PitchShifterLabel";
            this.PitchShifterLabel.Size = new System.Drawing.Size(101, 20);
            this.PitchShifterLabel.TabIndex = 0;
            this.PitchShifterLabel.Text = "Pitch Shifter";
            // 
            // PitchShiftNum
            // 
            this.PitchShiftNum.DecimalPlaces = 4;
            this.PitchShiftNum.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.PitchShiftNum.Location = new System.Drawing.Point(20, 70);
            this.PitchShiftNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PitchShiftNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.PitchShiftNum.Name = "PitchShiftNum";
            this.PitchShiftNum.Size = new System.Drawing.Size(76, 22);
            this.PitchShiftNum.TabIndex = 1;
            this.PitchShiftNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PitchShiftNum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // PitchAmountScroll
            // 
            this.PitchAmountScroll.Location = new System.Drawing.Point(102, 70);
            this.PitchAmountScroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PitchAmountScroll.Maximum = 1000;
            this.PitchAmountScroll.Minimum = -1000;
            this.PitchAmountScroll.Name = "PitchAmountScroll";
            this.PitchAmountScroll.Size = new System.Drawing.Size(152, 56);
            this.PitchAmountScroll.TabIndex = 2;
            this.PitchAmountScroll.Value = 1;
            this.PitchAmountScroll.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ActiveCheckbox
            // 
            this.ActiveCheckbox.AutoSize = true;
            this.ActiveCheckbox.Location = new System.Drawing.Point(20, 107);
            this.ActiveCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActiveCheckbox.Name = "ActiveCheckbox";
            this.ActiveCheckbox.Size = new System.Drawing.Size(68, 21);
            this.ActiveCheckbox.TabIndex = 3;
            this.ActiveCheckbox.Text = "Active";
            this.ActiveCheckbox.UseVisualStyleBackColor = true;
            this.ActiveCheckbox.CheckedChanged += new System.EventHandler(this.ActiveCheckbox_CheckedChanged);
            // 
            // PitchShifterBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.ActiveCheckbox);
            this.Controls.Add(this.PitchAmountScroll);
            this.Controls.Add(this.PitchShiftNum);
            this.Controls.Add(this.PitchShifterLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PitchShifterBlock";
            this.Size = new System.Drawing.Size(271, 145);
            ((System.ComponentModel.ISupportInitialize)(this.PitchShiftNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PitchAmountScroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label PitchShifterLabel;
            private System.Windows.Forms.NumericUpDown PitchShiftNum;
            private System.Windows.Forms.TrackBar PitchAmountScroll;
            private System.Windows.Forms.CheckBox ActiveCheckbox;
        }
    }
}
