
namespace NAudioTesting
{
    partial class KeybindListing
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
            this.SetKeys = new System.Windows.Forms.Button();
            this.Key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SetKeys
            // 
            this.SetKeys.Location = new System.Drawing.Point(19, 14);
            this.SetKeys.Name = "SetKeys";
            this.SetKeys.Size = new System.Drawing.Size(81, 41);
            this.SetKeys.TabIndex = 0;
            this.SetKeys.Text = "Set Keys";
            this.SetKeys.UseVisualStyleBackColor = true;
            // 
            // Key
            // 
            this.Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Key.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Key.Location = new System.Drawing.Point(118, 17);
            this.Key.Name = "Key";
            this.Key.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Key.Size = new System.Drawing.Size(201, 38);
            this.Key.TabIndex = 1;
            this.Key.Text = "Key";
            // 
            // KeybindListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.Key);
            this.Controls.Add(this.SetKeys);
            this.Name = "KeybindListing";
            this.Size = new System.Drawing.Size(322, 68);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetKeys;
        private System.Windows.Forms.Label Key;
    }
}
