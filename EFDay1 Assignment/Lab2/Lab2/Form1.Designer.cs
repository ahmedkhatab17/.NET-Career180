namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dGVEmployee = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtSalary = new TextBox();
            comboDept = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dGVEmployee).BeginInit();
            SuspendLayout();
            // 
            // dGVEmployee
            // 
            dGVEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVEmployee.Location = new Point(12, 270);
            dGVEmployee.Name = "dGVEmployee";
            dGVEmployee.Size = new Size(776, 168);
            dGVEmployee.TabIndex = 0;
            dGVEmployee.RowHeaderMouseDoubleClick += dGVEmployee_RowHeaderMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 83);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 127);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 174);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 4;
            label4.Text = "Department";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(150, 34);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(121, 23);
            txtFName.TabIndex = 5;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(150, 80);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(121, 23);
            txtLName.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(150, 124);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(121, 23);
            txtSalary.TabIndex = 7;
            // 
            // comboDept
            // 
            comboDept.FormattingEnabled = true;
            comboDept.Location = new Point(150, 171);
            comboDept.Name = "comboDept";
            comboDept.Size = new Size(121, 23);
            comboDept.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(38, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(119, 225);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(200, 225);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(comboDept);
            Controls.Add(txtSalary);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dGVEmployee);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dGVEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dGVEmployee;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtSalary;
        private ComboBox comboDept;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
