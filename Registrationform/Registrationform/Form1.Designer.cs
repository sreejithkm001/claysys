namespace Registrationform
{
    partial class Form1
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
            this.Studentname = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.Studentrecord = new System.Windows.Forms.DataGridView();
            this.Insert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Fathersname = new System.Windows.Forms.Label();
            this.Mobile = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Rollno = new System.Windows.Forms.Label();
            this.txtFathersname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtRollno = new System.Windows.Forms.TextBox();
            this.txtStudentname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Studentrecord)).BeginInit();
            this.SuspendLayout();
            // 
            // Studentname
            // 
            this.Studentname.AutoSize = true;
            this.Studentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentname.Location = new System.Drawing.Point(17, 47);
            this.Studentname.Name = "Studentname";
            this.Studentname.Size = new System.Drawing.Size(124, 20);
            this.Studentname.TabIndex = 0;
            this.Studentname.Text = "Student name";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(634, 114);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(199, 22);
            this.txtMobile.TabIndex = 1;
            // 
            // Studentrecord
            // 
            this.Studentrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Studentrecord.Location = new System.Drawing.Point(12, 407);
            this.Studentrecord.Name = "Studentrecord";
            this.Studentrecord.RowHeadersWidth = 51;
            this.Studentrecord.RowTemplate.Height = 24;
            this.Studentrecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Studentrecord.Size = new System.Drawing.Size(915, 150);
            this.Studentrecord.TabIndex = 2;
            this.Studentrecord.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Studentrecord_CellClick);
            this.Studentrecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Studentrecord_CellContentClick);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(47, 354);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(93, 47);
            this.Insert.TabIndex = 3;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(722, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(497, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(272, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 47);
            this.button4.TabIndex = 6;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Fathersname
            // 
            this.Fathersname.AutoSize = true;
            this.Fathersname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fathersname.Location = new System.Drawing.Point(486, 47);
            this.Fathersname.Name = "Fathersname";
            this.Fathersname.Size = new System.Drawing.Size(124, 20);
            this.Fathersname.TabIndex = 7;
            this.Fathersname.Text = "Fathers name";
            // 
            // Mobile
            // 
            this.Mobile.AutoSize = true;
            this.Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobile.Location = new System.Drawing.Point(546, 116);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(64, 20);
            this.Mobile.TabIndex = 8;
            this.Mobile.Text = "Mobile";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(63, 181);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(63, 20);
            this.Address.TabIndex = 9;
            this.Address.Text = "E-Mail";
            this.Address.Click += new System.EventHandler(this.txtAddress_Click);
            // 
            // Rollno
            // 
            this.Rollno.AutoSize = true;
            this.Rollno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rollno.Location = new System.Drawing.Point(76, 114);
            this.Rollno.Name = "Rollno";
            this.Rollno.Size = new System.Drawing.Size(65, 20);
            this.Rollno.TabIndex = 10;
            this.Rollno.Text = "RollNo";
            this.Rollno.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtFathersname
            // 
            this.txtFathersname.Location = new System.Drawing.Point(634, 45);
            this.txtFathersname.Name = "txtFathersname";
            this.txtFathersname.Size = new System.Drawing.Size(199, 22);
            this.txtFathersname.TabIndex = 12;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(163, 179);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(229, 22);
            this.txtemail.TabIndex = 13;
            // 
            // txtRollno
            // 
            this.txtRollno.Location = new System.Drawing.Point(163, 112);
            this.txtRollno.Name = "txtRollno";
            this.txtRollno.Size = new System.Drawing.Size(229, 22);
            this.txtRollno.TabIndex = 14;
            // 
            // txtStudentname
            // 
            this.txtStudentname.Location = new System.Drawing.Point(163, 45);
            this.txtStudentname.Name = "txtStudentname";
            this.txtStudentname.Size = new System.Drawing.Size(229, 22);
            this.txtStudentname.TabIndex = 15;
            this.txtStudentname.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(635, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(199, 22);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmpassword
            // 
            this.txtConfirmpassword.Location = new System.Drawing.Point(634, 252);
            this.txtConfirmpassword.Name = "txtConfirmpassword";
            this.txtConfirmpassword.Size = new System.Drawing.Size(199, 22);
            this.txtConfirmpassword.TabIndex = 17;
            this.txtConfirmpassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Confirm password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Gender";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(164, 246);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 24);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.Location = new System.Drawing.Point(839, 252);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 20);
            this.msg.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 583);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmpassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtStudentname);
            this.Controls.Add(this.txtRollno);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtFathersname);
            this.Controls.Add(this.Rollno);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.Fathersname);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Studentrecord);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.Studentname);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Studentrecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Studentname;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.DataGridView Studentrecord;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Fathersname;
        private System.Windows.Forms.Label Mobile;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Rollno;
        private System.Windows.Forms.TextBox txtFathersname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtRollno;
        private System.Windows.Forms.TextBox txtStudentname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label msg;
    }
}

