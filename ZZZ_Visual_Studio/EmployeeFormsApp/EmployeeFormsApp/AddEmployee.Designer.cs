namespace EmployeeFormsApp
{
    partial class AddEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvEmpData = new System.Windows.Forms.DataGridView();
            this.employee_dbDataSet = new EmployeeFormsApp.employee_dbDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new EmployeeFormsApp.employee_dbDataSetTableAdapters.employeeTableAdapter();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Naming System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Employee Name:";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(236, 158);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(278, 20);
            this.txtEmpName.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(236, 219);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvEmpData
            // 
            this.dgvEmpData.AutoGenerateColumns = false;
            this.dgvEmpData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn});
            this.dgvEmpData.DataSource = this.employeeBindingSource;
            this.dgvEmpData.Location = new System.Drawing.Point(367, 235);
            this.dgvEmpData.Name = "dgvEmpData";
            this.dgvEmpData.Size = new System.Drawing.Size(240, 150);
            this.dgvEmpData.TabIndex = 4;
            // 
            // employee_dbDataSet
            // 
            this.employee_dbDataSet.DataSetName = "employee_dbDataSet";
            this.employee_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.employee_dbDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "empid";
            this.empidDataGridViewTextBoxColumn.HeaderText = "empid";
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "empname";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "empname";
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmpData);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployee";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvEmpData;
        private employee_dbDataSet employee_dbDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private employee_dbDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
    }
}

