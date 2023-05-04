namespace contacts_project
{
    partial class ContactDetails
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 78);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(68, 144);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 215);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(68, 276);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(68, 211);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(236, 330);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(77, 37);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(342, 330);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(77, 37);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(236, 78);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(183, 32);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(236, 144);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(183, 32);
            txtLastName.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(236, 208);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(183, 32);
            txtPhone.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(236, 269);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(183, 32);
            txtAddress.TabIndex = 11;
            // 
            // ContactDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 450);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ContactDetails";
            Text = "ContacDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Label label3;
        private Button button4;
        private Label label4;
        private Label label5;
        private Button btnSave;
        private Button btnCancel;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhone;
        private TextBox txtAddress;
    }
}