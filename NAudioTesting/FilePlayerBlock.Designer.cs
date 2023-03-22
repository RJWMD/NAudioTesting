
namespace NAudioTesting
{
    namespace GridElements
    {
        partial class FilePlayerBlock
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
            this.ChooseFile = new System.Windows.Forms.OpenFileDialog();
            this.PlayAudio = new System.Windows.Forms.Button();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.StackCheckBox = new System.Windows.Forms.CheckBox();
            this.LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.FileVisualizer = new NAudioTesting.FileVisualizer();
            this.SuspendLayout();
            // 
            // ChooseFile
            // 
            this.ChooseFile.FileName = "ChooseFile";
            this.ChooseFile.Title = "Choose a file";
            this.ChooseFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // PlayAudio
            // 
            this.PlayAudio.Location = new System.Drawing.Point(17, 32);
            this.PlayAudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayAudio.Name = "PlayAudio";
            this.PlayAudio.Size = new System.Drawing.Size(83, 26);
            this.PlayAudio.TabIndex = 0;
            this.PlayAudio.Text = "Play file";
            this.PlayAudio.UseVisualStyleBackColor = true;
            this.PlayAudio.Click += new System.EventHandler(this.PlayAudio_Click);
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FileNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FileNameLabel.Location = new System.Drawing.Point(0, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(271, 31);
            this.FileNameLabel.TabIndex = 3;
            this.FileNameLabel.Text = "File Name";
            this.FileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FileNameLabel.DoubleClick += new System.EventHandler(this.FileNameLabel_DoubleClick);
            // 
            // StackCheckBox
            // 
            this.StackCheckBox.AutoSize = true;
            this.StackCheckBox.Location = new System.Drawing.Point(105, 36);
            this.StackCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StackCheckBox.Name = "StackCheckBox";
            this.StackCheckBox.Size = new System.Drawing.Size(65, 21);
            this.StackCheckBox.TabIndex = 4;
            this.StackCheckBox.Text = "Stack";
            this.StackCheckBox.UseVisualStyleBackColor = true;
            this.StackCheckBox.Click += new System.EventHandler(this.StackCheckBox_Click);
            // 
            // LoopCheckBox
            // 
            this.LoopCheckBox.AutoSize = true;
            this.LoopCheckBox.Location = new System.Drawing.Point(192, 36);
            this.LoopCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoopCheckBox.Name = "LoopCheckBox";
            this.LoopCheckBox.Size = new System.Drawing.Size(62, 21);
            this.LoopCheckBox.TabIndex = 5;
            this.LoopCheckBox.Text = "Loop";
            this.LoopCheckBox.UseVisualStyleBackColor = true;
            this.LoopCheckBox.Click += new System.EventHandler(this.LoopCheckBox_Click);
            // 
            // FileVisualizer
            // 
            this.FileVisualizer.BackColor = System.Drawing.SystemColors.Control;
            this.FileVisualizer.endPosition = 1F;
            this.FileVisualizer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FileVisualizer.Location = new System.Drawing.Point(17, 90);
            this.FileVisualizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileVisualizer.Name = "FileVisualizer";
            this.FileVisualizer.Size = new System.Drawing.Size(238, 44);
            this.FileVisualizer.startPosition = 0F;
            this.FileVisualizer.TabIndex = 2;
            this.FileVisualizer.WaveStream = null;
            // 
            // FilePlayerBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.LoopCheckBox);
            this.Controls.Add(this.StackCheckBox);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.PlayAudio);
            this.Controls.Add(this.FileVisualizer);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FilePlayerBlock";
            this.Size = new System.Drawing.Size(271, 145);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FilePlayerBlock_DragDrop);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.OpenFileDialog ChooseFile;
            private System.Windows.Forms.Button PlayAudio;
            //private NAudio.Gui.WaveViewer FileVisualiser;
            public NAudioTesting.FileVisualizer FileVisualizer;
            public System.Windows.Forms.Label FileNameLabel;
            private System.Windows.Forms.CheckBox StackCheckBox;
            private System.Windows.Forms.CheckBox LoopCheckBox;
        }
    }
}
