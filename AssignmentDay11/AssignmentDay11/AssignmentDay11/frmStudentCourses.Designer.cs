namespace AssignmentDay11
{
    partial class frmStudentCourses
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
            comboxStudent = new ComboBox();
            label1 = new Label();
            GVCourses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GVCourses).BeginInit();
            SuspendLayout();
            // 
            // comboxStudent
            // 
            comboxStudent.FormattingEnabled = true;
            comboxStudent.Location = new Point(165, 57);
            comboxStudent.Name = "comboxStudent";
            comboxStudent.Size = new Size(195, 23);
            comboxStudent.TabIndex = 0;
            comboxStudent.SelectedIndexChanged += comboxStudent_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 60);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Select Student";
            // 
            // GVCourses
            // 
            GVCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GVCourses.Location = new Point(0, 205);
            GVCourses.Name = "GVCourses";
            GVCourses.Size = new Size(800, 245);
            GVCourses.TabIndex = 2;
            // 
            // frmStudentCourses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GVCourses);
            Controls.Add(label1);
            Controls.Add(comboxStudent);
            Name = "frmStudentCourses";
            Text = "frmStudentCourses";
            ((System.ComponentModel.ISupportInitialize)GVCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboxStudent;
        private Label label1;
        private DataGridView GVCourses;
    }
}