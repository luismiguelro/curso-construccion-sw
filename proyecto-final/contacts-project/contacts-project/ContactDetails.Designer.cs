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
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(70, 72);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            label2.Location = new Point(70, 147);
            label2.Name = "label2";
            label2.Size = new Size(107, 22);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 192, 0);
            label4.Location = new Point(70, 297);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(70, 230);
            label5.Name = "label5";
            label5.Size = new Size(69, 22);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(26, 32, 40);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(221, 366);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 42);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(26, 32, 40);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(353, 366);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(96, 42);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(239, 67);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(183, 32);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(239, 142);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(183, 32);
            txtLastName.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(239, 215);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(183, 32);
            txtPhone.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(239, 284);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(183, 32);
            txtAddress.TabIndex = 11;
            // 
            // ContactDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 91);
            ClientSize = new Size(486, 435);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnCancel);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
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