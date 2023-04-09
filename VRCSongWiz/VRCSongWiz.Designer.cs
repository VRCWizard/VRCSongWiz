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
            this.materialSwitchChangeOnly = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox2();
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
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(427, 72);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(65, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "Reset";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.HideSelection = true;
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(19, 194);
            this.materialTextBox1.MaxLength = 32767;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.PasswordChar = '\0';
            this.materialTextBox1.PrefixSuffixText = null;
            this.materialTextBox1.ReadOnly = false;
            this.materialTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBox1.SelectedText = "";
            this.materialTextBox1.SelectionLength = 0;
            this.materialTextBox1.SelectionStart = 0;
            this.materialTextBox1.ShortcutsEnabled = true;
            this.materialTextBox1.Size = new System.Drawing.Size(434, 48);
            this.materialTextBox1.TabIndex = 7;
            this.materialTextBox1.TabStop = false;
            this.materialTextBox1.Text = "▶ {title} - {artist}";
            this.materialTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseSystemPasswordChar = false;
            // 
            // VRCSongWiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 289);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialSwitchChangeOnly);
            this.Controls.Add(this.materialSwitchDisplaySong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VRCSongWiz";
            this.Padding = new System.Windows.Forms.Padding(3, 48, 3, 2);
            this.Text = "VRC Song Wiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VRCSongWiz_FormClosing);
            this.Load += new System.EventHandler(this.VRCSongWiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialSwitch materialSwitchDisplaySong;
        public MaterialSkin.Controls.MaterialSwitch materialSwitchChangeOnly;
        public Label label1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox1;
    }
}