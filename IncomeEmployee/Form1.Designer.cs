
namespace IncomeEmployee
{
    partial class DataOutput
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.FiltergroupBox = new System.Windows.Forms.GroupBox();
            this.IsRuk = new System.Windows.Forms.CheckBox();
            this.ResetFilter = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new IncomeEmployee.DBDataSet();
            this.departmentTableAdapter = new IncomeEmployee.DBDataSetTableAdapters.departmentTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.EmpName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmpSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DepName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmpID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FiltergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalBox
            // 
            this.TotalBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.TotalBox.Enabled = false;
            this.TotalBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TotalBox.Location = new System.Drawing.Point(508, 485);
            this.TotalBox.Margin = new System.Windows.Forms.Padding(2);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalBox.Size = new System.Drawing.Size(152, 20);
            this.TotalBox.TabIndex = 3;
            // 
            // FiltergroupBox
            // 
            this.FiltergroupBox.Controls.Add(this.IsRuk);
            this.FiltergroupBox.Controls.Add(this.ResetFilter);
            this.FiltergroupBox.Controls.Add(this.checkBox2);
            this.FiltergroupBox.Controls.Add(this.checkBox1);
            this.FiltergroupBox.Controls.Add(this.label1);
            this.FiltergroupBox.Controls.Add(this.DepartmentComboBox);
            this.FiltergroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiltergroupBox.Location = new System.Drawing.Point(3, 3);
            this.FiltergroupBox.Name = "FiltergroupBox";
            this.FiltergroupBox.Size = new System.Drawing.Size(656, 101);
            this.FiltergroupBox.TabIndex = 5;
            this.FiltergroupBox.TabStop = false;
            this.FiltergroupBox.Text = "Фильтры";
            // 
            // IsRuk
            // 
            this.IsRuk.AutoSize = true;
            this.IsRuk.Enabled = false;
            this.IsRuk.Location = new System.Drawing.Point(8, 57);
            this.IsRuk.Margin = new System.Windows.Forms.Padding(2);
            this.IsRuk.Name = "IsRuk";
            this.IsRuk.Size = new System.Drawing.Size(189, 17);
            this.IsRuk.TabIndex = 7;
            this.IsRuk.Text = "С руководителем департамента";
            this.IsRuk.UseVisualStyleBackColor = true;
            this.IsRuk.CheckedChanged += new System.EventHandler(this.IsRuk_CheckedChanged);
            // 
            // ResetFilter
            // 
            this.ResetFilter.Location = new System.Drawing.Point(505, 17);
            this.ResetFilter.Name = "ResetFilter";
            this.ResetFilter.Size = new System.Drawing.Size(75, 23);
            this.ResetFilter.TabIndex = 6;
            this.ResetFilter.Text = "Сброс";
            this.ResetFilter.UseVisualStyleBackColor = true;
            this.ResetFilter.Click += new System.EventHandler(this.ResetFilter_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(252, 57);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(236, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Зарплаты руководителей департаментов";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(252, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(223, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Cотрудник с максимальной зарплатой";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Департамент";
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DepartmentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmentBindingSource, "id", true));
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(107, 19);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.DepartmentComboBox.TabIndex = 0;
            this.DepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentComboBox_SelectedIndexChanged);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "department";
            this.departmentBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TotalBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.FiltergroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 538);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmpName,
            this.EmpSalary,
            this.DepName,
            this.EmpID});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 110);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(656, 370);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // EmpName
            // 
            this.EmpName.Text = "Сотрудник";
            this.EmpName.Width = 196;
            // 
            // EmpSalary
            // 
            this.EmpSalary.Text = "Зарплата";
            this.EmpSalary.Width = 213;
            // 
            // DepName
            // 
            this.DepName.Text = "Департамент";
            this.DepName.Width = 240;
            // 
            // DataOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 538);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DataOutput";
            this.RightToLeftLayout = true;
            this.Text = "Вывод данных";
            this.Load += new System.EventHandler(this.DataOutput_Load);
            this.FiltergroupBox.ResumeLayout(false);
            this.FiltergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.GroupBox FiltergroupBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private DBDataSetTableAdapters.departmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.Button ResetFilter;
        private System.Windows.Forms.CheckBox IsRuk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader EmpName;
        private System.Windows.Forms.ColumnHeader EmpSalary;
        private System.Windows.Forms.ColumnHeader DepName;
        private System.Windows.Forms.ColumnHeader EmpID;
    }
}

