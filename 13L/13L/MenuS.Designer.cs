namespace _13L
{
    partial class MenuS
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
            this.cafeDBDataSet = new _13L.CafeDBDataSet();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishesTableAdapter = new _13L.CafeDBDataSetTableAdapters.DishesTableAdapter();
            this.dishIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.compositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dishIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.menuPriceDataGridViewTextBoxColumn,
            this.outputAmountDataGridViewTextBoxColumn,
            this.unitsDataGridViewTextBoxColumn,
            this.availableDataGridViewCheckBoxColumn,
            this.compositionDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.dishesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(940, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // cafeDBDataSet
            // 
            this.cafeDBDataSet.DataSetName = "CafeDBDataSet";
            this.cafeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "Dishes";
            this.dishesBindingSource.DataSource = this.cafeDBDataSet;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // dishIDDataGridViewTextBoxColumn
            // 
            this.dishIDDataGridViewTextBoxColumn.DataPropertyName = "DishID";
            this.dishIDDataGridViewTextBoxColumn.HeaderText = "DishID";
            this.dishIDDataGridViewTextBoxColumn.Name = "dishIDDataGridViewTextBoxColumn";
            this.dishIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // menuPriceDataGridViewTextBoxColumn
            // 
            this.menuPriceDataGridViewTextBoxColumn.DataPropertyName = "MenuPrice";
            this.menuPriceDataGridViewTextBoxColumn.HeaderText = "MenuPrice";
            this.menuPriceDataGridViewTextBoxColumn.Name = "menuPriceDataGridViewTextBoxColumn";
            // 
            // outputAmountDataGridViewTextBoxColumn
            // 
            this.outputAmountDataGridViewTextBoxColumn.DataPropertyName = "OutputAmount";
            this.outputAmountDataGridViewTextBoxColumn.HeaderText = "OutputAmount";
            this.outputAmountDataGridViewTextBoxColumn.Name = "outputAmountDataGridViewTextBoxColumn";
            // 
            // unitsDataGridViewTextBoxColumn
            // 
            this.unitsDataGridViewTextBoxColumn.DataPropertyName = "Units";
            this.unitsDataGridViewTextBoxColumn.HeaderText = "Units";
            this.unitsDataGridViewTextBoxColumn.Name = "unitsDataGridViewTextBoxColumn";
            // 
            // availableDataGridViewCheckBoxColumn
            // 
            this.availableDataGridViewCheckBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewCheckBoxColumn.HeaderText = "Available";
            this.availableDataGridViewCheckBoxColumn.Name = "availableDataGridViewCheckBoxColumn";
            // 
            // compositionDataGridViewTextBoxColumn
            // 
            this.compositionDataGridViewTextBoxColumn.DataPropertyName = "Composition";
            this.compositionDataGridViewTextBoxColumn.HeaderText = "Composition";
            this.compositionDataGridViewTextBoxColumn.Name = "compositionDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            // 
            // MenuS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MenuS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuS";
            this.Load += new System.EventHandler(this.MenuS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CafeDBDataSet cafeDBDataSet;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private CafeDBDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outputAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
    }
}