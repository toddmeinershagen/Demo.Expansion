namespace Demo.Expansion
{
    partial class K1OptionsForm
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
            this.SeparateFilePanel = new System.Windows.Forms.Panel();
            this.SeparateFileCheckBox = new System.Windows.Forms.CheckBox();
            this.HorizontalLine = new System.Windows.Forms.Label();
            this.K1OptionsPanel = new System.Windows.Forms.Panel();
            this.OptionsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.K1OptionsGroupBox.SuspendLayout();
            this.SeparateFilePanel.SuspendLayout();
            this.K1OptionsPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // K1OptionsGroupBox
            // 
            this.K1OptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.K1OptionsGroupBox.Controls.Add(this.SeparateFilePanel);
            this.K1OptionsGroupBox.Controls.Add(this.K1OptionsPanel);
            this.K1OptionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.K1OptionsGroupBox.Location = new System.Drawing.Point(13, 5);
            this.K1OptionsGroupBox.Name = "K1OptionsGroupBox";
            this.K1OptionsGroupBox.Size = new System.Drawing.Size(450, 88);
            this.K1OptionsGroupBox.TabIndex = 0;
            this.K1OptionsGroupBox.TabStop = false;
            this.K1OptionsGroupBox.Text = "K-1 Package Options:";
            // 
            // SeparateFilePanel
            // 
            this.SeparateFilePanel.Controls.Add(this.SeparateFileCheckBox);
            this.SeparateFilePanel.Controls.Add(this.HorizontalLine);
            this.SeparateFilePanel.Location = new System.Drawing.Point(7, 53);
            this.SeparateFilePanel.Name = "SeparateFilePanel";
            this.SeparateFilePanel.Size = new System.Drawing.Size(437, 29);
            this.SeparateFilePanel.TabIndex = 1;
            // 
            // SeparateFileCheckBox
            // 
            this.SeparateFileCheckBox.AutoSize = true;
            this.SeparateFileCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparateFileCheckBox.Location = new System.Drawing.Point(4, 6);
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
            this.HorizontalLine.Size = new System.Drawing.Size(437, 2);
            this.HorizontalLine.TabIndex = 0;
            // 
            // K1OptionsPanel
            // 
            this.K1OptionsPanel.Controls.Add(this.OptionsTableLayout);
            this.K1OptionsPanel.Location = new System.Drawing.Point(7, 20);
            this.K1OptionsPanel.Name = "K1OptionsPanel";
            this.K1OptionsPanel.Size = new System.Drawing.Size(437, 27);
            this.K1OptionsPanel.TabIndex = 0;
            // 
            // OptionsTableLayout
            // 
            this.OptionsTableLayout.ColumnCount = 1;
            this.OptionsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionsTableLayout.Location = new System.Drawing.Point(4, 4);
            this.OptionsTableLayout.Name = "OptionsTableLayout";
            this.OptionsTableLayout.RowCount = 1;
            this.OptionsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OptionsTableLayout.Size = new System.Drawing.Size(430, 23);
            this.OptionsTableLayout.TabIndex = 0;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.Controls.Add(this.CancelButton);
            this.ButtonPanel.Controls.Add(this.GenerateButton);
            this.ButtonPanel.Location = new System.Drawing.Point(13, 97);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(450, 34);
            this.ButtonPanel.TabIndex = 1;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(363, 8);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.Location = new System.Drawing.Point(284, 8);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 0;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // K1OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 136);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.K1OptionsGroupBox);
            this.Name = "K1OptionsForm";
            this.Text = "K1OptionsForm";
            this.K1OptionsGroupBox.ResumeLayout(false);
            this.SeparateFilePanel.ResumeLayout(false);
            this.SeparateFilePanel.PerformLayout();
            this.K1OptionsPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox K1OptionsGroupBox;
        private System.Windows.Forms.Panel SeparateFilePanel;
        private System.Windows.Forms.CheckBox SeparateFileCheckBox;
        private System.Windows.Forms.Label HorizontalLine;
        private System.Windows.Forms.Panel K1OptionsPanel;
        private System.Windows.Forms.TableLayoutPanel OptionsTableLayout;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button GenerateButton;
    }
}