
namespace NAudioTesting
{
    namespace GridElements
    {
        partial class WavePlayerBlock
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
            this.PlayWave = new System.Windows.Forms.Button();
            this.PitchController = new System.Windows.Forms.NumericUpDown();
            this.WaveTypeController = new System.Windows.Forms.ComboBox();
            this.PitchLabel = new System.Windows.Forms.Label();
            this.DurationCheckbox = new System.Windows.Forms.CheckBox();
            this.DurationController = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PitchController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationController)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayWave
            // 
            this.PlayWave.Location = new System.Drawing.Point(30, 33);
            this.PlayWave.Name = "PlayWave";
            this.PlayWave.Size = new System.Drawing.Size(101, 72);
            this.PlayWave.TabIndex = 0;
            this.PlayWave.Text = "Play Wave";
            this.PlayWave.UseVisualStyleBackColor = true;
            this.PlayWave.Click += new System.EventHandler(this.button1_Click);
            // 
            // PitchController
            // 
            this.PitchController.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PitchController.Location = new System.Drawing.Point(137, 45);
            this.PitchController.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PitchController.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.PitchController.Name = "PitchController";
            this.PitchController.Size = new System.Drawing.Size(120, 26);
            this.PitchController.TabIndex = 1;
            this.PitchController.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // WaveTypeController
            // 
            this.WaveTypeController.FormattingEnabled = true;
            this.WaveTypeController.Items.AddRange(new object[] {
            "Pink",
            "White",
            "Sweep",
            "Sin",
            "Square",
            "Triangle",
            "SawTooth"});
            this.WaveTypeController.Location = new System.Drawing.Point(137, 77);
            this.WaveTypeController.Name = "WaveTypeController";
            this.WaveTypeController.Size = new System.Drawing.Size(120, 28);
            this.WaveTypeController.TabIndex = 2;
            this.WaveTypeController.Text = "Type";
            this.WaveTypeController.SelectedIndexChanged += new System.EventHandler(this.WaveTypeController_SelectedIndexChanged);
            // 
            // PitchLabel
            // 
            this.PitchLabel.AutoSize = true;
            this.PitchLabel.BackColor = System.Drawing.Color.Transparent;
            this.PitchLabel.Location = new System.Drawing.Point(137, 22);
            this.PitchLabel.Name = "PitchLabel";
            this.PitchLabel.Size = new System.Drawing.Size(44, 20);
            this.PitchLabel.TabIndex = 3;
            this.PitchLabel.Text = "Pitch";
            // 
            // DurationCheckbox
            // 
            this.DurationCheckbox.AutoSize = true;
            this.DurationCheckbox.Location = new System.Drawing.Point(30, 121);
            this.DurationCheckbox.Name = "DurationCheckbox";
            this.DurationCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DurationCheckbox.Size = new System.Drawing.Size(96, 24);
            this.DurationCheckbox.TabIndex = 5;
            this.DurationCheckbox.Text = "Duration";
            this.DurationCheckbox.UseVisualStyleBackColor = true;
            this.DurationCheckbox.CheckedChanged += new System.EventHandler(this.DurationCheckbox_CheckedChanged);
            // 
            // DurationController
            // 
            this.DurationController.DecimalPlaces = 4;
            this.DurationController.Location = new System.Drawing.Point(137, 119);
            this.DurationController.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DurationController.Name = "DurationController";
            this.DurationController.Size = new System.Drawing.Size(120, 26);
            this.DurationController.TabIndex = 6;
            this.DurationController.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.DurationController.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // WavePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.DurationController);
            this.Controls.Add(this.DurationCheckbox);
            this.Controls.Add(this.PitchLabel);
            this.Controls.Add(this.WaveTypeController);
            this.Controls.Add(this.PitchController);
            this.Controls.Add(this.PlayWave);
            this.Name = "WavePlayer";
            this.Size = new System.Drawing.Size(305, 181);
            ((System.ComponentModel.ISupportInitialize)(this.PitchController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Button PlayWave;
            private System.Windows.Forms.NumericUpDown PitchController;
            private System.Windows.Forms.ComboBox WaveTypeController;
            private System.Windows.Forms.Label PitchLabel;
            private System.Windows.Forms.CheckBox DurationCheckbox;
            private System.Windows.Forms.NumericUpDown DurationController;
        }
    }
}
