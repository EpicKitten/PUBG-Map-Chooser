namespace PUBG_MapChooser
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.setMaps = new System.Windows.Forms.Button();
            this.erangelMapCheck = new System.Windows.Forms.CheckBox();
            this.miramarMapCheck = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resetSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setMaps
            // 
            this.setMaps.Location = new System.Drawing.Point(12, 276);
            this.setMaps.Name = "setMaps";
            this.setMaps.Size = new System.Drawing.Size(377, 23);
            this.setMaps.TabIndex = 0;
            this.setMaps.Text = "Set maps to use";
            this.setMaps.UseVisualStyleBackColor = true;
            this.setMaps.Click += new System.EventHandler(this.setMaps_Click);
            // 
            // erangelMapCheck
            // 
            this.erangelMapCheck.AutoSize = true;
            this.erangelMapCheck.Checked = true;
            this.erangelMapCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.erangelMapCheck.Location = new System.Drawing.Point(12, 254);
            this.erangelMapCheck.Name = "erangelMapCheck";
            this.erangelMapCheck.Size = new System.Drawing.Size(62, 17);
            this.erangelMapCheck.TabIndex = 1;
            this.erangelMapCheck.Text = "Erangel";
            this.erangelMapCheck.UseVisualStyleBackColor = true;
            // 
            // miramarMapCheck
            // 
            this.miramarMapCheck.AutoSize = true;
            this.miramarMapCheck.Checked = true;
            this.miramarMapCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miramarMapCheck.Location = new System.Drawing.Point(327, 254);
            this.miramarMapCheck.Name = "miramarMapCheck";
            this.miramarMapCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.miramarMapCheck.Size = new System.Drawing.Size(63, 17);
            this.miramarMapCheck.TabIndex = 2;
            this.miramarMapCheck.Text = "Miramar";
            this.miramarMapCheck.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(378, 208);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select which maps you want to play below and click \"Set maps to use\"";
            // 
            // resetSettings
            // 
            this.resetSettings.Location = new System.Drawing.Point(81, 247);
            this.resetSettings.Name = "resetSettings";
            this.resetSettings.Size = new System.Drawing.Size(240, 23);
            this.resetSettings.TabIndex = 5;
            this.resetSettings.Text = "Reset Steam Location";
            this.resetSettings.UseVisualStyleBackColor = true;
            this.resetSettings.Click += new System.EventHandler(this.resetSettings_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 308);
            this.Controls.Add(this.resetSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.miramarMapCheck);
            this.Controls.Add(this.erangelMapCheck);
            this.Controls.Add(this.setMaps);
            this.Name = "Main";
            this.Text = "PUBG Map Chooser";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setMaps;
        private System.Windows.Forms.CheckBox erangelMapCheck;
        private System.Windows.Forms.CheckBox miramarMapCheck;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetSettings;
    }
}

