﻿namespace ListAndEditForm1
{
    partial class Print
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
            this.rButtonAll = new System.Windows.Forms.RadioButton();
            this.rButtonMale = new System.Windows.Forms.RadioButton();
            this.rButtonFemale = new System.Windows.Forms.RadioButton();
            this.rButtonYes = new System.Windows.Forms.RadioButton();
            this.rButtonNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonCheck = new System.Windows.Forms.Button();
            this.ButtonSaveFile = new System.Windows.Forms.Button();
            this.ButtonPrinter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rButtonAll
            // 
            this.rButtonAll.AutoSize = true;
            this.rButtonAll.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonAll.Location = new System.Drawing.Point(24, 34);
            this.rButtonAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rButtonAll.Name = "rButtonAll";
            this.rButtonAll.Size = new System.Drawing.Size(45, 28);
            this.rButtonAll.TabIndex = 0;
            this.rButtonAll.TabStop = true;
            this.rButtonAll.Text = "All";
            this.rButtonAll.UseVisualStyleBackColor = true;
            // 
            // rButtonMale
            // 
            this.rButtonMale.AutoSize = true;
            this.rButtonMale.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonMale.Location = new System.Drawing.Point(133, 34);
            this.rButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rButtonMale.Name = "rButtonMale";
            this.rButtonMale.Size = new System.Drawing.Size(59, 28);
            this.rButtonMale.TabIndex = 1;
            this.rButtonMale.TabStop = true;
            this.rButtonMale.Text = "Male";
            this.rButtonMale.UseVisualStyleBackColor = true;
            this.rButtonMale.CheckedChanged += new System.EventHandler(this.rButtonMale_CheckedChanged);
            // 
            // rButtonFemale
            // 
            this.rButtonFemale.AutoSize = true;
            this.rButtonFemale.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonFemale.Location = new System.Drawing.Point(243, 34);
            this.rButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rButtonFemale.Name = "rButtonFemale";
            this.rButtonFemale.Size = new System.Drawing.Size(72, 28);
            this.rButtonFemale.TabIndex = 2;
            this.rButtonFemale.TabStop = true;
            this.rButtonFemale.Text = "Female";
            this.rButtonFemale.UseVisualStyleBackColor = true;
            this.rButtonFemale.CheckedChanged += new System.EventHandler(this.rButtonFemale_CheckedChanged);
            // 
            // rButtonYes
            // 
            this.rButtonYes.AutoSize = true;
            this.rButtonYes.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonYes.Location = new System.Drawing.Point(533, 21);
            this.rButtonYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rButtonYes.Name = "rButtonYes";
            this.rButtonYes.Size = new System.Drawing.Size(53, 28);
            this.rButtonYes.TabIndex = 3;
            this.rButtonYes.TabStop = true;
            this.rButtonYes.Text = "Yes";
            this.rButtonYes.UseVisualStyleBackColor = true;
            this.rButtonYes.CheckedChanged += new System.EventHandler(this.rButtonYes_CheckedChanged);
            // 
            // rButtonNo
            // 
            this.rButtonNo.AutoSize = true;
            this.rButtonNo.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButtonNo.Location = new System.Drawing.Point(637, 21);
            this.rButtonNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rButtonNo.Name = "rButtonNo";
            this.rButtonNo.Size = new System.Drawing.Size(47, 28);
            this.rButtonNo.TabIndex = 4;
            this.rButtonNo.TabStop = true;
            this.rButtonNo.Text = "No";
            this.rButtonNo.UseVisualStyleBackColor = true;
            this.rButtonNo.CheckedChanged += new System.EventHandler(this.rButtonNo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Use Date Range:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birth Date Between:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "and";
            // 
            // ButtonCheck
            // 
            this.ButtonCheck.BackColor = System.Drawing.Color.Red;
            this.ButtonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCheck.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCheck.Location = new System.Drawing.Point(729, 17);
            this.ButtonCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCheck.Name = "ButtonCheck";
            this.ButtonCheck.Size = new System.Drawing.Size(107, 36);
            this.ButtonCheck.TabIndex = 8;
            this.ButtonCheck.Text = "Check";
            this.ButtonCheck.UseVisualStyleBackColor = false;
            this.ButtonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // ButtonSaveFile
            // 
            this.ButtonSaveFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSaveFile.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSaveFile.Location = new System.Drawing.Point(292, 510);
            this.ButtonSaveFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSaveFile.Name = "ButtonSaveFile";
            this.ButtonSaveFile.Size = new System.Drawing.Size(171, 52);
            this.ButtonSaveFile.TabIndex = 9;
            this.ButtonSaveFile.Text = "Save to text file ";
            this.ButtonSaveFile.UseVisualStyleBackColor = false;
            this.ButtonSaveFile.Click += new System.EventHandler(this.ButtonSaveFile_Click);
            // 
            // ButtonPrinter
            // 
            this.ButtonPrinter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrinter.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPrinter.Location = new System.Drawing.Point(671, 510);
            this.ButtonPrinter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonPrinter.Name = "ButtonPrinter";
            this.ButtonPrinter.Size = new System.Drawing.Size(176, 52);
            this.ButtonPrinter.TabIndex = 10;
            this.ButtonPrinter.Text = "To Printer";
            this.ButtonPrinter.UseVisualStyleBackColor = false;
            this.ButtonPrinter.Click += new System.EventHandler(this.ButtonPrinter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.ButtonCheck);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rButtonNo);
            this.groupBox1.Controls.Add(this.rButtonYes);
            this.groupBox1.Controls.Add(this.rButtonFemale);
            this.groupBox1.Controls.Add(this.rButtonMale);
            this.groupBox1.Controls.Add(this.rButtonAll);
            this.groupBox1.Location = new System.Drawing.Point(49, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1028, 103);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(683, 63);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 29);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 63);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 29);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 143);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1027, 348);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonPrinter);
            this.Controls.Add(this.ButtonSaveFile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rButtonAll;
        private System.Windows.Forms.RadioButton rButtonMale;
        private System.Windows.Forms.RadioButton rButtonFemale;
        private System.Windows.Forms.RadioButton rButtonYes;
        private System.Windows.Forms.RadioButton rButtonNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonCheck;
        private System.Windows.Forms.Button ButtonSaveFile;
        private System.Windows.Forms.Button ButtonPrinter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}