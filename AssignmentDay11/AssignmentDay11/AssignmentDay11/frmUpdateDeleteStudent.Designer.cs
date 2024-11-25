namespace AssignmentDay11
{
    partial class frmUpdateDeleteStudent
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
            comboStudent = new ComboBox();
            btnUpdate = new Button();
            txtAdress = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // comboStudent
            // 
            comboStudent.FormattingEnabled = true;
            comboStudent.Location = new Point(49, 61);
            comboStudent.Name = "comboStudent";
            comboStudent.Size = new Size(217, 23);
            comboStudent.TabIndex = 0;
            comboStudent.SelectedIndexChanged += comboStudent_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(49, 320);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 33);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(166, 266);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(100, 23);
            txtAdress.TabIndex = 16;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(166, 218);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(100, 23);
            txtLName.TabIndex = 15;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(166, 171);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(100, 23);
            txtFName.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(166, 126);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 269);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 12;
            label4.Text = "Adress";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 221);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 11;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 174);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 10;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 129);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 9;
            label1.Text = "Id";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(184, 320);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 33);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(143, 390);
            result.Name = "result";
            result.Size = new Size(0, 15);
            result.TabIndex = 19;
            // 
            // frmUpdateDeleteStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtAdress);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboStudent);
            Name = "frmUpdateDeleteStudent";
            Text = "frmUpdateDeleteStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboStudent;
        private Button btnUpdate;
        private TextBox txtAdress;
        private TextBox txtLName;
        private TextBox txtFName;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Label result;
    }
}