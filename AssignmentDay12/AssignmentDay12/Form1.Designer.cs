namespace AssignmentDay12
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
            gridStudent = new DataGridView();
            btnInsert = new Button();
            txtAddress = new TextBox();
            txtLName = new TextBox();
            txtFName = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtAge = new TextBox();
            t = new Label();
            btnSync = new Button();
            ((System.ComponentModel.ISupportInitialize)gridStudent).BeginInit();
            SuspendLayout();
            // 
            // gridStudent
            // 
            gridStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStudent.Location = new Point(2, 1);
            gridStudent.Name = "gridStudent";
            gridStudent.Size = new Size(561, 192);
            gridStudent.TabIndex = 0;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(372, 352);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 27;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(123, 349);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(173, 23);
            txtAddress.TabIndex = 26;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(123, 303);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(173, 23);
            txtLName.TabIndex = 25;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(123, 267);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(173, 23);
            txtFName.TabIndex = 24;
            // 
            // txtId
            // 
            txtId.Location = new Point(123, 229);
            txtId.Name = "txtId";
            txtId.Size = new Size(173, 23);
            txtId.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 352);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 22;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 306);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 21;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 270);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 20;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 232);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 19;
            label1.Text = "Id";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(123, 397);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(173, 23);
            txtAge.TabIndex = 29;
            // 
            // t
            // 
            t.AutoSize = true;
            t.Location = new Point(57, 400);
            t.Name = "t";
            t.Size = new Size(28, 15);
            t.TabIndex = 28;
            t.Text = "Age";
            // 
            // btnSync
            // 
            btnSync.Location = new Point(372, 392);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(75, 23);
            btnSync.TabIndex = 30;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Click += btnSync_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSync);
            Controls.Add(txtAge);
            Controls.Add(t);
            Controls.Add(btnInsert);
            Controls.Add(txtAddress);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridStudent);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridStudent;
        private TextBox txtAddress;
        private TextBox txtLName;
        private TextBox txtFName;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAge;
        private Label t;
        private Button btnSync;
        private Button btnInsert;
    }
}
