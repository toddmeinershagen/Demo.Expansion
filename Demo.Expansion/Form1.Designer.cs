namespace Demo.Expansion
{
    partial class Form1
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
            this.K1OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.cbSeparateFile = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HorizontalLine = new System.Windows.Forms.Label();
            this.OptionsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.K1OptionsGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // K1OptionsGroupBox
            // 
            this.K1OptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.K1OptionsGroupBox.AutoSize = true;
            this.K1OptionsGroupBox.Controls.Add(this.cbSeparateFile);
            this.K1OptionsGroupBox.Controls.Add(this.panel2);
            this.K1OptionsGroupBox.Controls.Add(this.OptionsLayoutPanel);
            this.K1OptionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K1OptionsGroupBox.Location = new System.Drawing.Point(13, 207);
            this.K1OptionsGroupBox.Name = "K1OptionsGroupBox";
            this.K1OptionsGroupBox.Size = new System.Drawing.Size(379, 369);
            this.K1OptionsGroupBox.TabIndex = 0;
            this.K1OptionsGroupBox.TabStop = false;
            this.K1OptionsGroupBox.Text = "K-1 Package Options:";
            // 
            // cbSeparateFile
            // 
            this.cbSeparateFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSeparateFile.AutoSize = true;
            this.cbSeparateFile.Checked = true;
            this.cbSeparateFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSeparateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeparateFile.Location = new System.Drawing.Point(7, 285);
            this.cbSeparateFile.Name = "cbSeparateFile";
            this.cbSeparateFile.Size = new System.Drawing.Size(222, 17);
            this.cbSeparateFile.TabIndex = 1;
            this.cbSeparateFile.Text = "Create a separate file for each beneficiary";
            this.cbSeparateFile.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.HorizontalLine);
            this.panel2.Location = new System.Drawing.Point(7, -96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 36);
            this.panel2.TabIndex = 2;
            // 
            // HorizontalLine
            // 
            this.HorizontalLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.HorizontalLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HorizontalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalLine.Location = new System.Drawing.Point(7, 180);
            this.HorizontalLine.Name = "HorizontalLine";
            this.HorizontalLine.Size = new System.Drawing.Size(366, 20);
            this.HorizontalLine.TabIndex = 1;
            this.HorizontalLine.Click += new System.EventHandler(this.HorizontalLine_Click);
            // 
            // OptionsLayoutPanel
            // 
            this.OptionsLayoutPanel.AutoSize = true;
            this.OptionsLayoutPanel.ColumnCount = 1;
            this.OptionsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsLayoutPanel.Location = new System.Drawing.Point(7, 19);
            this.OptionsLayoutPanel.Name = "OptionsLayoutPanel";
            this.OptionsLayoutPanel.RowCount = 1;
            this.OptionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OptionsLayoutPanel.Size = new System.Drawing.Size(366, 24);
            this.OptionsLayoutPanel.TabIndex = 0;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(193, 0);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(286, 0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.GenerateButton);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Location = new System.Drawing.Point(13, 526);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 26);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(404, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.K1OptionsGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.K1OptionsGroupBox.ResumeLayout(false);
            this.K1OptionsGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox K1OptionsGroupBox;
        private System.Windows.Forms.TableLayoutPanel OptionsLayoutPanel;
        private System.Windows.Forms.Label HorizontalLine;
        private System.Windows.Forms.CheckBox cbSeparateFile;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

