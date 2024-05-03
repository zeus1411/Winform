namespace ListAndEditForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxUserName = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.rbtStudent = new System.Windows.Forms.RadioButton();
            this.rbtHumanResource = new System.Windows.Forms.RadioButton();
            this.linklbNewUser = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // TextBoxUserName
            // 
            this.TextBoxUserName.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUserName.Location = new System.Drawing.Point(229, 238);
            this.TextBoxUserName.Name = "TextBoxUserName";
            this.TextBoxUserName.Size = new System.Drawing.Size(235, 29);
            this.TextBoxUserName.TabIndex = 3;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(229, 311);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(235, 29);
            this.TextBoxPassword.TabIndex = 4;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.BackColor = System.Drawing.Color.IndianRed;
            this.bt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cancel.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Cancel.Location = new System.Drawing.Point(164, 408);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(116, 46);
            this.bt_Cancel.TabIndex = 5;
            this.bt_Cancel.Text = "Cancel";
            this.bt_Cancel.UseVisualStyleBackColor = false;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Login.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.Location = new System.Drawing.Point(391, 408);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(116, 46);
            this.bt_Login.TabIndex = 6;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 44);
            this.label3.TabIndex = 7;
            this.label3.Text = "Account Login";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPass.Location = new System.Drawing.Point(485, 309);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(120, 32);
            this.checkBoxShowPass.TabIndex = 8;
            this.checkBoxShowPass.Text = "Show Pass";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // rbtStudent
            // 
            this.rbtStudent.AutoSize = true;
            this.rbtStudent.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtStudent.Location = new System.Drawing.Point(216, 364);
            this.rbtStudent.Name = "rbtStudent";
            this.rbtStudent.Size = new System.Drawing.Size(76, 28);
            this.rbtStudent.TabIndex = 9;
            this.rbtStudent.TabStop = true;
            this.rbtStudent.Text = "Student";
            this.rbtStudent.UseVisualStyleBackColor = true;
            // 
            // rbtHumanResource
            // 
            this.rbtHumanResource.AutoSize = true;
            this.rbtHumanResource.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtHumanResource.Location = new System.Drawing.Point(348, 364);
            this.rbtHumanResource.Name = "rbtHumanResource";
            this.rbtHumanResource.Size = new System.Drawing.Size(133, 28);
            this.rbtHumanResource.TabIndex = 10;
            this.rbtHumanResource.TabStop = true;
            this.rbtHumanResource.Text = "Human Resource";
            this.rbtHumanResource.UseVisualStyleBackColor = true;
            // 
            // linklbNewUser
            // 
            this.linklbNewUser.AutoSize = true;
            this.linklbNewUser.Location = new System.Drawing.Point(34, 482);
            this.linklbNewUser.Name = "linklbNewUser";
            this.linklbNewUser.Size = new System.Drawing.Size(70, 16);
            this.linklbNewUser.TabIndex = 11;
            this.linklbNewUser.TabStop = true;
            this.linklbNewUser.Text = "NewUser?";
            this.linklbNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbNewUser_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ListAndEditForm1.Properties.Resources._416369933_1418127692473809_2069977026900754887_n;
            this.pictureBox1.Location = new System.Drawing.Point(59, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(632, 519);
            this.Controls.Add(this.linklbNewUser);
            this.Controls.Add(this.rbtHumanResource);
            this.Controls.Add(this.rbtStudent);
            this.Controls.Add(this.checkBoxShowPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.bt_Cancel);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxUserName;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.RadioButton rbtStudent;
        private System.Windows.Forms.RadioButton rbtHumanResource;
        private System.Windows.Forms.LinkLabel linklbNewUser;
    }
}

