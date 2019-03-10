namespace Adminwebbshop
{
	partial class Order
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
			this.textBoxID = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cutomeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.webshopdbDataSet = new Adminwebbshop.webshopdbDataSet();
			this.orderTableAdapter = new Adminwebbshop.webshopdbDataSetTableAdapters.OrderTableAdapter();
			this.BTN_NEW = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.BTN_UPDATE = new System.Windows.Forms.Button();
			this.BTN_DELETE = new System.Windows.Forms.Button();
			this.BTN_INSERT = new System.Windows.Forms.Button();
			this.textBoxCustomerId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxProductId = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxQuantity = new System.Windows.Forms.TextBox();
			this.textBoxStatus = new System.Windows.Forms.TextBox();
			this.textBoxOrderDate = new System.Windows.Forms.TextBox();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.textBoxID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.webshopdbDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxID
			// 
			this.textBoxID.AutoGenerateColumns = false;
			this.textBoxID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.textBoxID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cutomeridDataGridViewTextBoxColumn,
            this.productidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
			this.textBoxID.DataSource = this.orderBindingSource;
			this.textBoxID.Location = new System.Drawing.Point(448, 12);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.RowTemplate.Height = 24;
			this.textBoxID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.textBoxID.Size = new System.Drawing.Size(751, 388);
			this.textBoxID.TabIndex = 2;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// cutomeridDataGridViewTextBoxColumn
			// 
			this.cutomeridDataGridViewTextBoxColumn.DataPropertyName = "cutomerid";
			this.cutomeridDataGridViewTextBoxColumn.HeaderText = "cutomerid";
			this.cutomeridDataGridViewTextBoxColumn.Name = "cutomeridDataGridViewTextBoxColumn";
			// 
			// productidDataGridViewTextBoxColumn
			// 
			this.productidDataGridViewTextBoxColumn.DataPropertyName = "productid";
			this.productidDataGridViewTextBoxColumn.HeaderText = "productid";
			this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "status";
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			// 
			// orderdateDataGridViewTextBoxColumn
			// 
			this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "orderdate";
			this.orderdateDataGridViewTextBoxColumn.HeaderText = "orderdate";
			this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.DataMember = "Order";
			this.orderBindingSource.DataSource = this.webshopdbDataSet;
			// 
			// webshopdbDataSet
			// 
			this.webshopdbDataSet.DataSetName = "webshopdbDataSet";
			this.webshopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// orderTableAdapter
			// 
			this.orderTableAdapter.ClearBeforeFill = true;
			// 
			// BTN_NEW
			// 
			this.BTN_NEW.Location = new System.Drawing.Point(345, 248);
			this.BTN_NEW.Name = "BTN_NEW";
			this.BTN_NEW.Size = new System.Drawing.Size(87, 33);
			this.BTN_NEW.TabIndex = 45;
			this.BTN_NEW.Text = "New";
			this.BTN_NEW.UseVisualStyleBackColor = true;
			this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click_1);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(10, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 29);
			this.label6.TabIndex = 44;
			this.label6.Text = "ID:";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(173, 50);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(47, 34);
			this.textBox2.TabIndex = 43;
			// 
			// BTN_UPDATE
			// 
			this.BTN_UPDATE.Location = new System.Drawing.Point(345, 143);
			this.BTN_UPDATE.Name = "BTN_UPDATE";
			this.BTN_UPDATE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.BTN_UPDATE.Size = new System.Drawing.Size(87, 33);
			this.BTN_UPDATE.TabIndex = 42;
			this.BTN_UPDATE.Text = "Update";
			this.BTN_UPDATE.UseVisualStyleBackColor = true;
			this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
			// 
			// BTN_DELETE
			// 
			this.BTN_DELETE.Location = new System.Drawing.Point(345, 197);
			this.BTN_DELETE.Name = "BTN_DELETE";
			this.BTN_DELETE.Size = new System.Drawing.Size(87, 33);
			this.BTN_DELETE.TabIndex = 41;
			this.BTN_DELETE.Text = "Delete";
			this.BTN_DELETE.UseVisualStyleBackColor = true;
			this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
			// 
			// BTN_INSERT
			// 
			this.BTN_INSERT.Location = new System.Drawing.Point(346, 97);
			this.BTN_INSERT.Name = "BTN_INSERT";
			this.BTN_INSERT.Size = new System.Drawing.Size(87, 33);
			this.BTN_INSERT.TabIndex = 40;
			this.BTN_INSERT.Text = "Save";
			this.BTN_INSERT.UseVisualStyleBackColor = true;
			this.BTN_INSERT.Click += new System.EventHandler(this.BTN_INSERT_Click);
			// 
			// textBoxCustomerId
			// 
			this.textBoxCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCustomerId.Location = new System.Drawing.Point(173, 101);
			this.textBoxCustomerId.Name = "textBoxCustomerId";
			this.textBoxCustomerId.ReadOnly = true;
			this.textBoxCustomerId.Size = new System.Drawing.Size(52, 34);
			this.textBoxCustomerId.TabIndex = 39;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 29);
			this.label1.TabIndex = 38;
			this.label1.Text = "CustomerId:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(10, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 29);
			this.label2.TabIndex = 46;
			this.label2.Text = "ProductId:";
			// 
			// textBoxProductId
			// 
			this.textBoxProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxProductId.Location = new System.Drawing.Point(173, 155);
			this.textBoxProductId.Name = "textBoxProductId";
			this.textBoxProductId.ReadOnly = true;
			this.textBoxProductId.Size = new System.Drawing.Size(52, 34);
			this.textBoxProductId.TabIndex = 47;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 213);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 29);
			this.label3.TabIndex = 48;
			this.label3.Text = "Quantity:";
			// 
			// textBoxQuantity
			// 
			this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxQuantity.Location = new System.Drawing.Point(173, 213);
			this.textBoxQuantity.Name = "textBoxQuantity";
			this.textBoxQuantity.Size = new System.Drawing.Size(136, 34);
			this.textBoxQuantity.TabIndex = 49;
			// 
			// textBoxStatus
			// 
			this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxStatus.Location = new System.Drawing.Point(173, 265);
			this.textBoxStatus.Name = "textBoxStatus";
			this.textBoxStatus.Size = new System.Drawing.Size(136, 34);
			this.textBoxStatus.TabIndex = 50;
			// 
			// textBoxOrderDate
			// 
			this.textBoxOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxOrderDate.Location = new System.Drawing.Point(173, 326);
			this.textBoxOrderDate.Name = "textBoxOrderDate";
			this.textBoxOrderDate.Size = new System.Drawing.Size(136, 34);
			this.textBoxOrderDate.TabIndex = 51;
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPrice.Location = new System.Drawing.Point(173, 384);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(136, 34);
			this.textBoxPrice.TabIndex = 52;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 270);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 29);
			this.label4.TabIndex = 54;
			this.label4.Text = "Status:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 326);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(142, 29);
			this.label5.TabIndex = 55;
			this.label5.Text = "OrderDate:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(10, 387);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 29);
			this.label7.TabIndex = 56;
			this.label7.Text = "Price:";
			// 
			// orderBindingSource1
			// 
			this.orderBindingSource1.DataMember = "Order";
			this.orderBindingSource1.DataSource = this.webshopdbDataSet;
			// 
			// orderBindingSource2
			// 
			this.orderBindingSource2.DataMember = "Order";
			this.orderBindingSource2.DataSource = this.webshopdbDataSet;
			// 
			// Order
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1239, 722);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.textBoxOrderDate);
			this.Controls.Add(this.textBoxStatus);
			this.Controls.Add(this.textBoxQuantity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxProductId);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BTN_NEW);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.BTN_UPDATE);
			this.Controls.Add(this.BTN_DELETE);
			this.Controls.Add(this.BTN_INSERT);
			this.Controls.Add(this.textBoxCustomerId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxID);
			this.Name = "Order";
			this.Text = "Order";
			((System.ComponentModel.ISupportInitialize)(this.textBoxID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.webshopdbDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView textBoxID;
		private webshopdbDataSet webshopdbDataSet;
		private System.Windows.Forms.BindingSource orderBindingSource;
		private webshopdbDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cutomeridDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button BTN_NEW;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button BTN_UPDATE;
		private System.Windows.Forms.Button BTN_DELETE;
		private System.Windows.Forms.Button BTN_INSERT;
		private System.Windows.Forms.TextBox textBoxCustomerId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxProductId;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxQuantity;
		private System.Windows.Forms.TextBox textBoxStatus;
		private System.Windows.Forms.TextBox textBoxOrderDate;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.BindingSource orderBindingSource1;
		private System.Windows.Forms.BindingSource orderBindingSource2;
	}
}