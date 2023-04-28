namespace YHW0323CMSFormApp
{
    partial class WorkerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblWorkerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._c_DataSet = new YHW0323CMSFormApp._c_DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelbtu = new System.Windows.Forms.Button();
            this.exitbtu = new System.Windows.Forms.Button();
            this.editbtu = new System.Windows.Forms.Button();
            this.savebtu = new System.Windows.Forms.Button();
            this.tblWorkerTableAdapter = new YHW0323CMSFormApp._c_DataSetTableAdapters.tblWorkerTableAdapter();
            this._c_DataSet1 = new YHW0323CMSFormApp._c_DataSet();
            this.tableAdapterManager1 = new YHW0323CMSFormApp._c_DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWorkerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._c_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._c_DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblWorkerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(84, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(657, 168);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // workerIDDataGridViewTextBoxColumn
            // 
            this.workerIDDataGridViewTextBoxColumn.DataPropertyName = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.HeaderText = "WorkerID";
            this.workerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workerIDDataGridViewTextBoxColumn.Name = "workerIDDataGridViewTextBoxColumn";
            this.workerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblWorkerBindingSource
            // 
            this.tblWorkerBindingSource.DataMember = "tblWorker";
            this.tblWorkerBindingSource.DataSource = this._c_DataSet;
            this.tblWorkerBindingSource.CurrentChanged += new System.EventHandler(this.tblWorkerBindingSource_CurrentChanged);
            // 
            // _c_DataSet
            // 
            this._c_DataSet.DataSetName = "_c_DataSet";
            this._c_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(645, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cilck on the Edit button to Load the Records";
            // 
            // cancelbtu
            // 
            this.cancelbtu.Location = new System.Drawing.Point(459, 334);
            this.cancelbtu.Name = "cancelbtu";
            this.cancelbtu.Size = new System.Drawing.Size(75, 23);
            this.cancelbtu.TabIndex = 2;
            this.cancelbtu.Text = "Cancel";
            this.cancelbtu.UseVisualStyleBackColor = true;
            // 
            // exitbtu
            // 
            this.exitbtu.Location = new System.Drawing.Point(617, 334);
            this.exitbtu.Name = "exitbtu";
            this.exitbtu.Size = new System.Drawing.Size(75, 23);
            this.exitbtu.TabIndex = 3;
            this.exitbtu.Text = "Exit";
            this.exitbtu.UseVisualStyleBackColor = true;
            this.exitbtu.Click += new System.EventHandler(this.exitbtu_Click);
            // 
            // editbtu
            // 
            this.editbtu.Location = new System.Drawing.Point(290, 334);
            this.editbtu.Name = "editbtu";
            this.editbtu.Size = new System.Drawing.Size(75, 23);
            this.editbtu.TabIndex = 4;
            this.editbtu.Text = "Edit";
            this.editbtu.UseVisualStyleBackColor = true;
            this.editbtu.Click += new System.EventHandler(this.editbtu_Click);
            // 
            // savebtu
            // 
            this.savebtu.Location = new System.Drawing.Point(131, 334);
            this.savebtu.Name = "savebtu";
            this.savebtu.Size = new System.Drawing.Size(75, 23);
            this.savebtu.TabIndex = 5;
            this.savebtu.Text = "Save";
            this.savebtu.UseVisualStyleBackColor = true;
            this.savebtu.Click += new System.EventHandler(this.savebtu_Click);
            // 
            // tblWorkerTableAdapter
            // 
            this.tblWorkerTableAdapter.ClearBeforeFill = true;
            // 
            // _c_DataSet1
            // 
            this._c_DataSet1.DataSetName = "_c_DataSet";
            this._c_DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tblCustomerTableAdapter = null;
            this.tableAdapterManager1.tblJobDetailsTableAdapter = null;
            this.tableAdapterManager1.tblWorkerTableAdapter = this.tblWorkerTableAdapter;
            this.tableAdapterManager1.UpdateOrder = YHW0323CMSFormApp._c_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savebtu);
            this.Controls.Add(this.editbtu);
            this.Controls.Add(this.exitbtu);
            this.Controls.Add(this.cancelbtu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.Load += new System.EventHandler(this.WorkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblWorkerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._c_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._c_DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelbtu;
        private System.Windows.Forms.Button exitbtu;
        private System.Windows.Forms.Button editbtu;
        private System.Windows.Forms.Button savebtu;
        private _c_DataSet _c_DataSet;
        private System.Windows.Forms.BindingSource tblWorkerBindingSource;
        private _c_DataSetTableAdapters.tblWorkerTableAdapter tblWorkerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private _c_DataSet _c_DataSet1;
        private _c_DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}