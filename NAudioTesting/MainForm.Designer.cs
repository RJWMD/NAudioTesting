
namespace NAudioTesting
{
    partial class MainForm
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
            this.PlayWave = new System.Windows.Forms.Button();
            this.ToolsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wavePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pitchShifterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakerCapturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordToggle = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.OutputDevice = new System.Windows.Forms.ComboBox();
            this.InputDeviceMic = new System.Windows.Forms.ComboBox();
            this.StopAllAudioButton = new System.Windows.Forms.Button();
            this.OpenFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clipCapturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelRightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayWave
            // 
            this.PlayWave.Location = new System.Drawing.Point(12, 12);
            this.PlayWave.Name = "PlayWave";
            this.PlayWave.Size = new System.Drawing.Size(141, 35);
            this.PlayWave.TabIndex = 0;
            this.PlayWave.Text = "Load files";
            this.PlayWave.UseVisualStyleBackColor = true;
            this.PlayWave.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ToolsContainer
            // 
            this.ToolsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolsContainer.AutoScroll = true;
            this.ToolsContainer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ToolsContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolsContainer.ContextMenuStrip = this.PanelRightClick;
            this.ToolsContainer.Location = new System.Drawing.Point(27, 57);
            this.ToolsContainer.Name = "ToolsContainer";
            this.ToolsContainer.Size = new System.Drawing.Size(760, 347);
            this.ToolsContainer.TabIndex = 0;
            this.ToolsContainer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel1_Scroll);
            this.ToolsContainer.DragDrop += new System.Windows.Forms.DragEventHandler(this.ToolsContainer_DragDrop);
            this.ToolsContainer.Resize += new System.EventHandler(this.flowLayoutPanel1_Resize);
            // 
            // PanelRightClick
            // 
            this.PanelRightClick.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.PanelRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem});
            this.PanelRightClick.Name = "PanelRightClick";
            this.PanelRightClick.Size = new System.Drawing.Size(156, 36);
            this.PanelRightClick.Opening += new System.ComponentModel.CancelEventHandler(this.PanelRightClick_Opening);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emptyToolStripMenuItem,
            this.wavePlayerToolStripMenuItem,
            this.filePlayerToolStripMenuItem,
            this.pitchShifterToolStripMenuItem,
            this.speakerCapturerToolStripMenuItem,
            this.clipCapturerToolStripMenuItem});
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(155, 32);
            this.addNewToolStripMenuItem.Text = "Add new";
            // 
            // emptyToolStripMenuItem
            // 
            this.emptyToolStripMenuItem.Name = "emptyToolStripMenuItem";
            this.emptyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.emptyToolStripMenuItem.Text = "Empty";
            this.emptyToolStripMenuItem.Click += new System.EventHandler(this.emptyToolStripMenuItem_Click);
            // 
            // wavePlayerToolStripMenuItem
            // 
            this.wavePlayerToolStripMenuItem.Name = "wavePlayerToolStripMenuItem";
            this.wavePlayerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.wavePlayerToolStripMenuItem.Text = "Wave Player";
            this.wavePlayerToolStripMenuItem.Click += new System.EventHandler(this.wavePlayerToolStripMenuItem_Click);
            // 
            // filePlayerToolStripMenuItem
            // 
            this.filePlayerToolStripMenuItem.Name = "filePlayerToolStripMenuItem";
            this.filePlayerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.filePlayerToolStripMenuItem.Text = "File Player";
            this.filePlayerToolStripMenuItem.Click += new System.EventHandler(this.filePlayerToolStripMenuItem_Click);
            // 
            // pitchShifterToolStripMenuItem
            // 
            this.pitchShifterToolStripMenuItem.Name = "pitchShifterToolStripMenuItem";
            this.pitchShifterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pitchShifterToolStripMenuItem.Text = "Pitch Shifter";
            this.pitchShifterToolStripMenuItem.Click += new System.EventHandler(this.pitchShifterToolStripMenuItem_Click);
            // 
            // speakerCapturerToolStripMenuItem
            // 
            this.speakerCapturerToolStripMenuItem.Name = "speakerCapturerToolStripMenuItem";
            this.speakerCapturerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.speakerCapturerToolStripMenuItem.Text = "Speaker Capturer";
            this.speakerCapturerToolStripMenuItem.Click += new System.EventHandler(this.speakerCapturerToolStripMenuItem_Click);
            // 
            // RecordToggle
            // 
            this.RecordToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordToggle.Location = new System.Drawing.Point(2769, 62);
            this.RecordToggle.Name = "RecordToggle";
            this.RecordToggle.Size = new System.Drawing.Size(99, 30);
            this.RecordToggle.TabIndex = 3;
            this.RecordToggle.Text = "record •";
            this.RecordToggle.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(2511, 386);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 326);
            this.vScrollBar1.TabIndex = 0;
            // 
            // OutputDevice
            // 
            this.OutputDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OutputDevice.FormattingEnabled = true;
            this.OutputDevice.Location = new System.Drawing.Point(671, 16);
            this.OutputDevice.Name = "OutputDevice";
            this.OutputDevice.Size = new System.Drawing.Size(116, 28);
            this.OutputDevice.TabIndex = 4;
            this.OutputDevice.SelectedIndexChanged += new System.EventHandler(this.OutputDevice_SelectedIndexChanged);
            this.OutputDevice.MouseEnter += new System.EventHandler(this.OutputDevice_MouseEnter);
            // 
            // InputDeviceMic
            // 
            this.InputDeviceMic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputDeviceMic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InputDeviceMic.FormattingEnabled = true;
            this.InputDeviceMic.Location = new System.Drawing.Point(549, 16);
            this.InputDeviceMic.Name = "InputDeviceMic";
            this.InputDeviceMic.Size = new System.Drawing.Size(116, 28);
            this.InputDeviceMic.TabIndex = 5;
            this.InputDeviceMic.SelectedIndexChanged += new System.EventHandler(this.InputDeviceMic_SelectedIndexChanged);
            this.InputDeviceMic.MouseEnter += new System.EventHandler(this.InputDeviceMic_MouseEnter);
            // 
            // StopAllAudioButton
            // 
            this.StopAllAudioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopAllAudioButton.Location = new System.Drawing.Point(454, 12);
            this.StopAllAudioButton.Name = "StopAllAudioButton";
            this.StopAllAudioButton.Size = new System.Drawing.Size(89, 35);
            this.StopAllAudioButton.TabIndex = 6;
            this.StopAllAudioButton.Text = "Stop All";
            this.StopAllAudioButton.UseVisualStyleBackColor = true;
            this.StopAllAudioButton.Click += new System.EventHandler(this.StopAllAudioButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clipCapturerToolStripMenuItem
            // 
            this.clipCapturerToolStripMenuItem.Name = "clipCapturerToolStripMenuItem";
            this.clipCapturerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clipCapturerToolStripMenuItem.Text = "Clip Capturer";
            this.clipCapturerToolStripMenuItem.Click += new System.EventHandler(this.clipCapturerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.StopAllAudioButton);
            this.Controls.Add(this.InputDeviceMic);
            this.Controls.Add(this.OutputDevice);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.RecordToggle);
            this.Controls.Add(this.ToolsContainer);
            this.Controls.Add(this.PlayWave);
            this.Name = "MainForm";
            this.Text = "Sound Board";
            this.TransparencyKey = System.Drawing.Color.Sienna;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.PanelRightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayWave;
        public System.Windows.Forms.FlowLayoutPanel ToolsContainer;
        private System.Windows.Forms.Button RecordToggle;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ContextMenuStrip PanelRightClick;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wavePlayerToolStripMenuItem;
        private System.Windows.Forms.ComboBox OutputDevice;
        private System.Windows.Forms.ComboBox InputDeviceMic;
        private System.Windows.Forms.ToolStripMenuItem filePlayerToolStripMenuItem;
        private System.Windows.Forms.Button StopAllAudioButton;
        private System.Windows.Forms.ToolStripMenuItem pitchShifterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speakerCapturerToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog OpenFolder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem clipCapturerToolStripMenuItem;
    }
}

