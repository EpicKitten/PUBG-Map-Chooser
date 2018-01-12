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
            this.SuspendLayout();
            // 
            // setMaps
            // 
            this.setMaps.Location = new System.Drawing.Point(18, 425);
            this.setMaps.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.setMaps.Name = "setMaps";
            this.setMaps.Size = new System.Drawing.Size(565, 35);
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
            this.erangelMapCheck.Location = new System.Drawing.Point(18, 391);
            this.erangelMapCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.erangelMapCheck.Name = "erangelMapCheck";
            this.erangelMapCheck.Size = new System.Drawing.Size(90, 24);
            this.erangelMapCheck.TabIndex = 1;
            this.erangelMapCheck.Text = "Erangel";
            this.erangelMapCheck.UseVisualStyleBackColor = true;
            // 
            // miramarMapCheck
            // 
            this.miramarMapCheck.AutoSize = true;
            this.miramarMapCheck.Checked = true;
            this.miramarMapCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miramarMapCheck.Location = new System.Drawing.Point(491, 391);
            this.miramarMapCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.miramarMapCheck.Name = "miramarMapCheck";
            this.miramarMapCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.miramarMapCheck.Size = new System.Drawing.Size(92, 24);
            this.miramarMapCheck.TabIndex = 2;
            this.miramarMapCheck.Text = "Miramar";
            this.miramarMapCheck.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 18);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(565, 318);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 341);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select which maps you want to play below and click \"Set maps to use\"";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.miramarMapCheck);
            this.Controls.Add(this.erangelMapCheck);
            this.Controls.Add(this.setMaps);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}

