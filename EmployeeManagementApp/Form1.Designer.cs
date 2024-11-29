namespace EmployeeManagementApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            txtUserAge = new TextBox();
            btnCreate = new Button();
            txtResults = new TextBox();
            btnRead = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label4 = new Label();
            txtID = new TextBox();
            dgvUserList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(164, 18);
            label1.Name = "label1";
            label1.Size = new Size(169, 44);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 122);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 1;
            label2.Text = "User's Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 157);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "User's Age:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(95, 119);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(195, 23);
            txtUserName.TabIndex = 3;
            // 
            // txtUserAge
            // 
            txtUserAge.Location = new Point(95, 154);
            txtUserAge.Name = "txtUserAge";
            txtUserAge.Size = new Size(195, 23);
            txtUserAge.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(310, 102);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(13, 183);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.Size = new Size(453, 103);
            txtResults.TabIndex = 6;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(310, 140);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 7;
            btnRead.Text = "READ";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(393, 101);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(393, 140);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 85);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 10;
            label4.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(95, 84);
            txtID.Name = "txtID";
            txtID.Size = new Size(195, 23);
            txtID.TabIndex = 11;
            // 
            // dgvUserList
            // 
            dgvUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Location = new Point(12, 296);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.Size = new Size(454, 150);
            dgvUserList.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 458);
            Controls.Add(dgvUserList);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnRead);
            Controls.Add(txtResults);
            Controls.Add(btnCreate);
            Controls.Add(txtUserAge);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Employee Management App";
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox txtUserAge;
        private Button btnCreate;
        private TextBox txtResults;
        private Button btnRead;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label4;
        private TextBox txtID;
        private DataGridView dgvUserList;
    }
}
