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
            this.aboutBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.method_filemove = new System.Windows.Forms.RadioButton();
            this.method_extchange = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // setMaps
            // 
            this.setMaps.Location = new System.Drawing.Point(12, 318);
            this.setMaps.Name = "setMaps";
            this.setMaps.Size = new System.Drawing.Size(374, 23);
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
            this.erangelMapCheck.Location = new System.Drawing.Point(57, 18);
            this.erangelMapCheck.Name = "erangelMapCheck";
            this.erangelMapCheck.Size = new System.Drawing.Size(62, 17);
            this.erangelMapCheck.TabIndex = 1;
            this.erangelMapCheck.Text = "Erangel";
            this.erangelMapCheck.UseVisualStyleBackColor = true;
            // 
            // miramarMapCheck
            // 
            this.miramarMapCheck.AutoSize = true;
            this.miramarMapCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.miramarMapCheck.Checked = true;
            this.miramarMapCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miramarMapCheck.Location = new System.Drawing.Point(57, 48);
            this.miramarMapCheck.Name = "miramarMapCheck";
            this.miramarMapCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.miramarMapCheck.Size = new System.Drawing.Size(63, 17);
            this.miramarMapCheck.TabIndex = 2;
            this.miramarMapCheck.Text = "Miramar";
            this.miramarMapCheck.UseVisualStyleBackColor = true;
            // 
            // aboutBox
            // 
            this.aboutBox.Location = new System.Drawing.Point(12, 12);
            this.aboutBox.Name = "aboutBox";
            this.aboutBox.Size = new System.Drawing.Size(378, 209);
            this.aboutBox.TabIndex = 3;
            this.aboutBox.Text = resources.GetString("aboutBox.Text");
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.erangelMapCheck);
            this.groupBox1.Controls.Add(this.miramarMapCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 237);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(181, 76);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maps";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.method_filemove);
            this.groupBox2.Controls.Add(this.method_extchange);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(198, 237);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(188, 76);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Method";
            // 
            // method_filemove
            // 
            this.method_filemove.AutoSize = true;
            this.method_filemove.Enabled = false;
            this.method_filemove.Location = new System.Drawing.Point(42, 48);
            this.method_filemove.Margin = new System.Windows.Forms.Padding(2);
            this.method_filemove.Name = "method_filemove";
            this.method_filemove.Size = new System.Drawing.Size(73, 17);
            this.method_filemove.TabIndex = 4;
            this.method_filemove.Text = "Move files";
            this.method_filemove.UseVisualStyleBackColor = true;
            // 
            // method_extchange
            // 
            this.method_extchange.AutoSize = true;
            this.method_extchange.Checked = true;
            this.method_extchange.Enabled = false;
            this.method_extchange.Location = new System.Drawing.Point(32, 17);
            this.method_extchange.Margin = new System.Windows.Forms.Padding(2);
            this.method_extchange.Name = "method_extchange";
            this.method_extchange.Size = new System.Drawing.Size(111, 17);
            this.method_extchange.TabIndex = 3;
            this.method_extchange.TabStop = true;
            this.method_extchange.Text = "Extension Change";
            this.method_extchange.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 350);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutBox);
            this.Controls.Add(this.setMaps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "PUBG Map Chooser";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setMaps;
        private System.Windows.Forms.CheckBox erangelMapCheck;
        private System.Windows.Forms.CheckBox miramarMapCheck;
        private System.Windows.Forms.RichTextBox aboutBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton method_filemove;
        private System.Windows.Forms.RadioButton method_extchange;
    }
}

