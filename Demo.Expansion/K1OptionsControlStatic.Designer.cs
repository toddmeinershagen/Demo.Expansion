namespace Demo.Expansion
{
    partial class K1OptionsControlStatic
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
            this.K1OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.SeparateFilePanel = new System.Windows.Forms.Panel();
            this.SeparateFileCheckBox = new System.Windows.Forms.CheckBox();
            this.HorizontalLine = new System.Windows.Forms.Label();
            this.K1OptionsGroupBox.SuspendLayout();
            this.SeparateFilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // K1OptionsGroupBox
            // 
            this.K1OptionsGroupBox.AutoSize = true;
            this.K1OptionsGroupBox.Controls.Add(this.SeparateFilePanel);
            this.K1OptionsGroupBox.Controls.Add(this.OptionsPanel);
            this.K1OptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.K1OptionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K1OptionsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.K1OptionsGroupBox.Name = "K1OptionsGroupBox";
            this.K1OptionsGroupBox.Size = new System.Drawing.Size(359, 59);
            this.K1OptionsGroupBox.TabIndex = 0;
            this.K1OptionsGroupBox.TabStop = false;
            this.K1OptionsGroupBox.Text = "K-1 Package Options:";
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OptionsPanel.Location = new System.Drawing.Point(6, 19);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(347, 2);
            this.OptionsPanel.TabIndex = 0;
            // 
            // SeparateFilePanel
            // 
            this.SeparateFilePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SeparateFilePanel.Controls.Add(this.SeparateFileCheckBox);
            this.SeparateFilePanel.Controls.Add(this.HorizontalLine);
            this.SeparateFilePanel.Location = new System.Drawing.Point(6, 24);
            this.SeparateFilePanel.Name = "SeparateFilePanel";
            this.SeparateFilePanel.Size = new System.Drawing.Size(347, 29);
            this.SeparateFilePanel.TabIndex = 4;
            // 
            // SeparateFileCheckBox
            // 
            this.SeparateFileCheckBox.AutoSize = true;
            this.SeparateFileCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparateFileCheckBox.Location = new System.Drawing.Point(3, 5);
            this.SeparateFileCheckBox.Name = "SeparateFileCheckBox";
            this.SeparateFileCheckBox.Size = new System.Drawing.Size(222, 17);
            this.SeparateFileCheckBox.TabIndex = 1;
            this.SeparateFileCheckBox.Text = "Create a separate file for each beneficiary";
            this.SeparateFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // HorizontalLine
            // 
            this.HorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.HorizontalLine.Location = new System.Drawing.Point(0, 0);
            this.HorizontalLine.Name = "HorizontalLine";
            this.HorizontalLine.Size = new System.Drawing.Size(347, 2);
            this.HorizontalLine.TabIndex = 0;
            // 
            // K1OptionsControlStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.K1OptionsGroupBox);
            this.Name = "K1OptionsControlStatic";
            this.Size = new System.Drawing.Size(359, 59);
            this.K1OptionsGroupBox.ResumeLayout(false);
            this.SeparateFilePanel.ResumeLayout(false);
            this.SeparateFilePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox K1OptionsGroupBox;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Panel SeparateFilePanel;
        private System.Windows.Forms.CheckBox SeparateFileCheckBox;
        private System.Windows.Forms.Label HorizontalLine;
    }
}
