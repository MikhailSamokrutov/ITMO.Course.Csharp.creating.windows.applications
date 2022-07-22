
namespace ITMO.CsharpWindowsForms.ExamApp
{
    partial class Connect
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
            this.AddButton = new System.Windows.Forms.Button();
            this.Refreshbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_blockDataSet = new ITMO.CsharpWindowsForms.ExamApp.test_blockDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t1TableAdapter = new ITMO.CsharpWindowsForms.ExamApp.test_blockDataSetTableAdapters.t1TableAdapter();
            this.test_blockDataSet2 = new ITMO.CsharpWindowsForms.ExamApp.test_blockDataSet2();
            this.testblockDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorks2019DataSet = new ITMO.CsharpWindowsForms.ExamApp.AdventureWorks2019DataSet();
            this.adventureWorks2019DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_blockDataSet3 = new ITMO.CsharpWindowsForms.ExamApp.test_blockDataSet3();
            this.testblockDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.t1TableAdapter1 = new ITMO.CsharpWindowsForms.ExamApp.test_blockDataSet3TableAdapters.t1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_blockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_blockDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testblockDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2019DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2019DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_blockDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testblockDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AddButton.Location = new System.Drawing.Point(44, 162);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(183, 38);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "INSERT";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Refreshbutton.Location = new System.Drawing.Point(44, 107);
            this.Refreshbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(183, 37);
            this.Refreshbutton.TabIndex = 1;
            this.Refreshbutton.Text = "REFRESH";
            this.Refreshbutton.UseVisualStyleBackColor = false;
            this.Refreshbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 246);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 303);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 366);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.t1BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(292, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(568, 337);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // t1BindingSource
            // 
            this.t1BindingSource.DataSource = this.test_blockDataSet;
            this.t1BindingSource.Position = 0;
            // 
            // test_blockDataSet
            // 
            this.test_blockDataSet.DataSetName = "test_blockDataSet";
            this.test_blockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(51, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(42, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(57, 369);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // t1TableAdapter
            // 
            this.t1TableAdapter.ClearBeforeFill = true;
            // 
            // test_blockDataSet2
            // 
            this.test_blockDataSet2.DataSetName = "test_blockDataSet2";
            this.test_blockDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testblockDataSet2BindingSource
            // 
            this.testblockDataSet2BindingSource.DataSource = this.test_blockDataSet2;
            this.testblockDataSet2BindingSource.Position = 0;
            // 
            // adventureWorks2019DataSet
            // 
            this.adventureWorks2019DataSet.DataSetName = "AdventureWorks2019DataSet";
            this.adventureWorks2019DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adventureWorks2019DataSetBindingSource
            // 
            this.adventureWorks2019DataSetBindingSource.DataSource = this.adventureWorks2019DataSet;
            this.adventureWorks2019DataSetBindingSource.Position = 0;
            // 
            // test_blockDataSet3
            // 
            this.test_blockDataSet3.DataSetName = "test_blockDataSet3";
            this.test_blockDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testblockDataSet3BindingSource
            // 
            this.testblockDataSet3BindingSource.DataSource = this.test_blockDataSet3;
            this.testblockDataSet3BindingSource.Position = 0;
            // 
            // t1BindingSource1
            // 
            this.t1BindingSource1.DataMember = "t1";
            this.t1BindingSource1.DataSource = this.t1BindingSource;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // t1BindingSource2
            // 
            this.t1BindingSource2.DataMember = "t1";
            this.t1BindingSource2.DataSource = this.testblockDataSet3BindingSource;
            // 
            // t1TableAdapter1
            // 
            this.t1TableAdapter1.ClearBeforeFill = true;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(873, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.AddButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Connect";
            this.Text = "InsertDataForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_blockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_blockDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testblockDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2019DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2019DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.test_blockDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testblockDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Refreshbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private test_blockDataSet test_blockDataSet;
        private System.Windows.Forms.BindingSource t1BindingSource;
        private test_blockDataSetTableAdapters.t1TableAdapter t1TableAdapter;
        private System.Windows.Forms.BindingSource testblockDataSet2BindingSource;
        private test_blockDataSet2 test_blockDataSet2;
        private System.Windows.Forms.BindingSource adventureWorks2019DataSetBindingSource;
        private AdventureWorks2019DataSet adventureWorks2019DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource t1BindingSource1;
        private System.Windows.Forms.BindingSource testblockDataSet3BindingSource;
        private test_blockDataSet3 test_blockDataSet3;
        private System.Windows.Forms.BindingSource t1BindingSource2;
        private test_blockDataSet3TableAdapters.t1TableAdapter t1TableAdapter1;
    }
}

