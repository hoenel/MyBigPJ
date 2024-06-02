namespace MyBigProject
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
            dtgvTable = new DataGridView();
            panel1 = new Panel();
            panel4 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            txbName = new TextBox();
            txbID = new TextBox();
            lbDateofBirth = new Label();
            lblGender = new Label();
            lbName = new Label();
            lbID = new Label();
            panel3 = new Panel();
            txbPhone = new TextBox();
            txbEmail = new TextBox();
            lbEmail = new Label();
            lbPhone = new Label();
            panel5 = new Panel();
            btnAdd = new Button();
            btnUpdateTable = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Dock = DockStyle.Bottom;
            dtgvTable.Location = new Point(0, 344);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.Size = new Size(849, 329);
            dtgvTable.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 313);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(dateTimePicker1);
            panel4.Controls.Add(txbName);
            panel4.Controls.Add(txbID);
            panel4.Controls.Add(lbDateofBirth);
            panel4.Controls.Add(lblGender);
            panel4.Controls.Add(lbName);
            panel4.Controls.Add(lbID);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(425, 307);
            panel4.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = " \"MM dd,yyyy\"";
            dateTimePicker1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(126, 250);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 26);
            dateTimePicker1.TabIndex = 11;
            // 
            // txbName
            // 
            txbName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbName.Location = new Point(92, 103);
            txbName.Name = "txbName";
            txbName.Size = new Size(312, 26);
            txbName.TabIndex = 10;
            // 
            // txbID
            // 
            txbID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbID.Location = new Point(84, 32);
            txbID.Name = "txbID";
            txbID.Size = new Size(312, 26);
            txbID.TabIndex = 9;
            // 
            // lbDateofBirth
            // 
            lbDateofBirth.AutoSize = true;
            lbDateofBirth.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDateofBirth.Location = new Point(21, 250);
            lbDateofBirth.Name = "lbDateofBirth";
            lbDateofBirth.Size = new Size(87, 19);
            lbDateofBirth.TabIndex = 8;
            lbDateofBirth.Text = "Năm sinh:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(21, 181);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(73, 19);
            lblGender.TabIndex = 7;
            lblGender.Text = "Giới tính";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(21, 106);
            lbName.Name = "lbName";
            lbName.Size = new Size(65, 19);
            lbName.TabIndex = 6;
            lbName.Text = "Họ tên:";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.Location = new Point(21, 35);
            lbID.Name = "lbID";
            lbID.Size = new Size(57, 19);
            lbID.TabIndex = 5;
            lbID.Text = "Mã ID:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbPhone);
            panel3.Controls.Add(txbEmail);
            panel3.Controls.Add(lbEmail);
            panel3.Controls.Add(lbPhone);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(431, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(401, 307);
            panel3.TabIndex = 1;
            // 
            // txbPhone
            // 
            txbPhone.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbPhone.Location = new Point(102, 99);
            txbPhone.Name = "txbPhone";
            txbPhone.Size = new Size(293, 26);
            txbPhone.TabIndex = 12;
            // 
            // txbEmail
            // 
            txbEmail.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txbEmail.Location = new Point(94, 32);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(301, 26);
            txbEmail.TabIndex = 11;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(31, 35);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(57, 19);
            lbEmail.TabIndex = 10;
            lbEmail.Text = "Email:";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhone.Location = new Point(31, 106);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(65, 19);
            lbPhone.TabIndex = 9;
            lbPhone.Text = "Phone:";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnAdd);
            panel5.Controls.Add(btnUpdateTable);
            panel5.Controls.Add(btnUpdate);
            panel5.Controls.Add(btnDelete);
            panel5.Location = new Point(3, 203);
            panel5.Name = "panel5";
            panel5.Size = new Size(395, 100);
            panel5.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(14, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 80);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnUpdateTable.Location = new Point(302, 17);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(90, 80);
            btnUpdateTable.TabIndex = 3;
            btnUpdateTable.Text = "Cập nhật";
            btnUpdateTable.UseVisualStyleBackColor = true;
            btnUpdateTable.Click += btnUpdateTable_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnUpdate.Location = new Point(110, 16);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 80);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(206, 16);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 80);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 307);
            panel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(849, 673);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dtgvTable);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvTable;
        private Panel panel1;
        private Panel panel3;
        private Button btnUpdateTable;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel panel2;
        private Panel panel4;
        private TextBox txbID;
        private Label lbDateofBirth;
        private Label lblGender;
        private Label lbName;
        private Label lbID;
        private Label lbEmail;
        private Label lbPhone;
        private Panel panel5;
        private DateTimePicker dateTimePicker1;
        private TextBox txbName;
        private TextBox txbPhone;
        private TextBox txbEmail;
    }
}
