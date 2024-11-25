namespace AssignmentDay11
{
    partial class frmSelectAllStudent
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
            grindAllStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grindAllStudents).BeginInit();
            SuspendLayout();
            // 
            // grindAllStudents
            // 
            grindAllStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grindAllStudents.Dock = DockStyle.Fill;
            grindAllStudents.Location = new Point(0, 0);
            grindAllStudents.Name = "grindAllStudents";
            grindAllStudents.Size = new Size(800, 450);
            grindAllStudents.TabIndex = 0;
            // 
            // frmSelectAllStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grindAllStudents);
            Name = "frmSelectAllStudent";
            Text = "frmSelectAllStudent";
            ((System.ComponentModel.ISupportInitialize)grindAllStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grindAllStudents;
    }
}