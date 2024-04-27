namespace _13L
{
    partial class OrderS
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
            this.saleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cafeDBDataSet = new _13L.CafeDBDataSet();
            this.dishSaleTableAdapter = new _13L.CafeDBDataSetTableAdapters.DishSaleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saleIDDataGridViewTextBoxColumn,
            this.dishIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dishSaleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // saleIDDataGridViewTextBoxColumn
            // 
            this.saleIDDataGridViewTextBoxColumn.DataPropertyName = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.HeaderText = "SaleID";
            this.saleIDDataGridViewTextBoxColumn.Name = "saleIDDataGridViewTextBoxColumn";
            // 
            // dishIDDataGridViewTextBoxColumn
            // 
            this.dishIDDataGridViewTextBoxColumn.DataPropertyName = "DishID";
            this.dishIDDataGridViewTextBoxColumn.HeaderText = "DishID";
            this.dishIDDataGridViewTextBoxColumn.Name = "dishIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // dishSaleBindingSource
            // 
            this.dishSaleBindingSource.DataMember = "DishSale";
            this.dishSaleBindingSource.DataSource = this.cafeDBDataSet;
            // 
            // cafeDBDataSet
            // 
            this.cafeDBDataSet.DataSetName = "CafeDBDataSet";
            this.cafeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dishSaleTableAdapter
            // 
            this.dishSaleTableAdapter.ClearBeforeFill = true;
            // 
            // OrderS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 332);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderS";
            this.Load += new System.EventHandler(this.OrderS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CafeDBDataSet cafeDBDataSet;
        private System.Windows.Forms.BindingSource dishSaleBindingSource;
        private CafeDBDataSetTableAdapters.DishSaleTableAdapter dishSaleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
    }
}