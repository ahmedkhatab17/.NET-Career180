﻿namespace ADOConnectedMode
{
    partial class frmSelectV2
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
            comboAuthors = new ComboBox();
            label1 = new Label();
            gridTitles = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridTitles).BeginInit();
            SuspendLayout();
            // 
            // comboAuthors
            // 
            comboAuthors.FormattingEnabled = true;
            comboAuthors.Location = new Point(99, 22);
            comboAuthors.Name = "comboAuthors";
            comboAuthors.Size = new Size(171, 23);
            comboAuthors.TabIndex = 0;
            comboAuthors.SelectedIndexChanged += comboAuthors_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Authors";
            // 
            // gridTitles
            // 
            gridTitles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTitles.Location = new Point(12, 175);
            gridTitles.Name = "gridTitles";
            gridTitles.Size = new Size(776, 263);
            gridTitles.TabIndex = 2;
            // 
            // frmSelectV2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridTitles);
            Controls.Add(label1);
            Controls.Add(comboAuthors);
            Name = "frmSelectV2";
            Text = "frmSelectV2";
            ((System.ComponentModel.ISupportInitialize)gridTitles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboAuthors;
        private Label label1;
        private DataGridView gridTitles;
    }
}