namespace ListAndEditForm1.Score
{
    partial class RemoveScore
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
            this.components = new System.ComponentModel.Container();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSVDBDataSet2 = new ListAndEditForm1.QLSVDBDataSet2();
            this.btn_remove = new System.Windows.Forms.Button();
            this.scoreTableAdapter = new ListAndEditForm1.QLSVDBDataSet2TableAdapters.scoreTableAdapter();
            this.btRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreBindingSource
            // 
            this.scoreBindingSource.DataMember = "score";
            this.scoreBindingSource.DataSource = this.qLSVDBDataSet2;
            // 
            // qLSVDBDataSet2
            // 
            this.qLSVDBDataSet2.DataSetName = "QLSVDBDataSet2";
            this.qLSVDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(24, 491);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(187, 47);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "Remove Score";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // btRefresh
            // 
            this.btRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefresh.Location = new System.Drawing.Point(259, 491);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(187, 47);
            this.btRefresh.TabIndex = 3;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = false;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1061, 449);
            this.dataGridView1.TabIndex = 4;
            // 
            // RemoveScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 643);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btn_remove);
            this.Name = "RemoveScore";
            this.Text = "RemoveScore";
            this.Load += new System.EventHandler(this.RemoveScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSVDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_remove;
        private QLSVDBDataSet2 qLSVDBDataSet2;
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private QLSVDBDataSet2TableAdapters.scoreTableAdapter scoreTableAdapter;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}