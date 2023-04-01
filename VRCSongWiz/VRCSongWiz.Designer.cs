namespace TTSVoiceWizard3._0
{
    partial class VRCSongWiz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VRCSongWiz));
            this.materialSwitchDisplaySong = new MaterialSkin.Controls.MaterialSwitch();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialSwitchChangeOnly = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // materialSwitchDisplaySong
            // 
            this.materialSwitchDisplaySong.AutoSize = true;
            this.materialSwitchDisplaySong.Checked = true;
            this.materialSwitchDisplaySong.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitchDisplaySong.Depth = 0;
            this.materialSwitchDisplaySong.Location = new System.Drawing.Point(3, 73);
            this.materialSwitchDisplaySong.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitchDisplaySong.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchDisplaySong.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchDisplaySong.Name = "materialSwitchDisplaySong";
            this.materialSwitchDisplaySong.Ripple = true;
            this.materialSwitchDisplaySong.Size = new System.Drawing.Size(152, 37);
            this.materialSwitchDisplaySong.TabIndex = 1;
            this.materialSwitchDisplaySong.Text = "Display Song";
            this.materialSwitchDisplaySong.UseVisualStyleBackColor = true;
            this.materialSwitchDisplaySong.CheckedChanged += new System.EventHandler(this.materialSwitchDisplaySong_CheckedChanged);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(19, 186);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(453, 50);
            this.materialTextBox1.TabIndex = 2;
            this.materialTextBox1.Text = "▶ {title} - {artist} 『{progressMinutes}/{durationMinutes}』";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialSwitchChangeOnly
            // 
            this.materialSwitchChangeOnly.AutoSize = true;
            this.materialSwitchChangeOnly.Checked = true;
            this.materialSwitchChangeOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitchChangeOnly.Depth = 0;
            this.materialSwitchChangeOnly.Location = new System.Drawing.Point(3, 110);
            this.materialSwitchChangeOnly.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitchChangeOnly.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchChangeOnly.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchChangeOnly.Name = "materialSwitchChangeOnly";
            this.materialSwitchChangeOnly.Ripple = true;
            this.materialSwitchChangeOnly.Size = new System.Drawing.Size(267, 37);
            this.materialSwitchChangeOnly.TabIndex = 3;
            this.materialSwitchChangeOnly.Text = "Only Appear On Song Change";
            this.materialSwitchChangeOnly.UseVisualStyleBackColor = true;
            this.materialSwitchChangeOnly.CheckedChanged += new System.EventHandler(this.materialSwitchChangeOnly_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(19, 164);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(152, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Customize Song Text";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(329, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "- Spotify Not Connected -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VRCSongWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 266);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialSwitchChangeOnly);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.materialSwitchDisplaySong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VRCSongWiz";
            this.Padding = new System.Windows.Forms.Padding(3, 48, 3, 2);
            this.Text = "VRC Song Wiz";
            this.Load += new System.EventHandler(this.VRCSongWiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        public MaterialSkin.Controls.MaterialSwitch materialSwitchDisplaySong;
        public MaterialSkin.Controls.MaterialSwitch materialSwitchChangeOnly;
        public Label label1;
    }
}