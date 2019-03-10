namespace Adminwebbshop
{
	partial class AddProducts
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
			this.textBoxID = new System.Windows.Forms.DataGridView();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxInstock = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BTN_CHOOSE_IMAGE = new System.Windows.Forms.Button();
			this.BTN_INSERT = new System.Windows.Forms.Button();
			this.textBoxCategory = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.BTN_DELETE = new System.Windows.Forms.Button();
			this.BTN_UPDATE = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.BTN_NEW = new System.Windows.Forms.Button();
			this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet1 = new Adminwebbshop.DataSet1();
			this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.webshopdbDataSet = new Adminwebbshop.webshopdbDataSet();
			this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productsTableAdapter = new Adminwebbshop.webshopdbDataSetTableAdapters.ProductsTableAdapter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.instockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.textBoxID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.webshopdbDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(186, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Product Name:";
			// 
			// textBoxID
			// 
			this.textBoxID.AutoGenerateColumns = false;
			this.textBoxID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.textBoxID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productnameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.instockDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn});
			this.textBoxID.DataSource = this.productsBindingSource;
			this.textBoxID.Location = new System.Drawing.Point(656, 24);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.RowTemplate.Height = 24;
			this.textBoxID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.textBoxID.Size = new System.Drawing.Size(730, 682);
			this.textBoxID.TabIndex = 1;
			this.textBoxID.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxName.Location = new System.Drawing.Point(204, 55);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(100, 34);
			this.textBoxName.TabIndex = 2;
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPrice.Location = new System.Drawing.Point(204, 107);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(100, 34);
			this.textBoxPrice.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 29);
			this.label2.TabIndex = 3;
			this.label2.Text = "Price:";
			// 
			// textBoxInstock
			// 
			this.textBoxInstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxInstock.Location = new System.Drawing.Point(204, 163);
			this.textBoxInstock.Name = "textBoxInstock";
			this.textBoxInstock.Size = new System.Drawing.Size(100, 34);
			this.textBoxInstock.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 29);
			this.label3.TabIndex = 5;
			this.label3.Text = "Instock:";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxDescription.Location = new System.Drawing.Point(167, 309);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(195, 140);
			this.textBoxDescription.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 309);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 29);
			this.label4.TabIndex = 7;
			this.label4.Text = "Description:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pictureBox1.Location = new System.Drawing.Point(167, 455);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(256, 181);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// BTN_CHOOSE_IMAGE
			// 
			this.BTN_CHOOSE_IMAGE.Location = new System.Drawing.Point(167, 642);
			this.BTN_CHOOSE_IMAGE.Name = "BTN_CHOOSE_IMAGE";
			this.BTN_CHOOSE_IMAGE.Size = new System.Drawing.Size(113, 29);
			this.BTN_CHOOSE_IMAGE.TabIndex = 10;
			this.BTN_CHOOSE_IMAGE.Text = "Upload Image";
			this.BTN_CHOOSE_IMAGE.UseVisualStyleBackColor = true;
			this.BTN_CHOOSE_IMAGE.Click += new System.EventHandler(this.BTN_CHOOSE_IMAGE_Click);
			// 
			// BTN_INSERT
			// 
			this.BTN_INSERT.Location = new System.Drawing.Point(353, 24);
			this.BTN_INSERT.Name = "BTN_INSERT";
			this.BTN_INSERT.Size = new System.Drawing.Size(87, 33);
			this.BTN_INSERT.TabIndex = 11;
			this.BTN_INSERT.Text = "Save";
			this.BTN_INSERT.UseVisualStyleBackColor = true;
			this.BTN_INSERT.Click += new System.EventHandler(this.BTN_INSERT_Click);
			// 
			// textBoxCategory
			// 
			this.textBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCategory.Location = new System.Drawing.Point(204, 219);
			this.textBoxCategory.Name = "textBoxCategory";
			this.textBoxCategory.Size = new System.Drawing.Size(100, 34);
			this.textBoxCategory.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 219);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 29);
			this.label5.TabIndex = 14;
			this.label5.Text = "CategoryId:";
			// 
			// BTN_DELETE
			// 
			this.BTN_DELETE.Location = new System.Drawing.Point(353, 121);
			this.BTN_DELETE.Name = "BTN_DELETE";
			this.BTN_DELETE.Size = new System.Drawing.Size(87, 33);
			this.BTN_DELETE.TabIndex = 15;
			this.BTN_DELETE.Text = "Delete";
			this.BTN_DELETE.UseVisualStyleBackColor = true;
			this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
			// 
			// BTN_UPDATE
			// 
			this.BTN_UPDATE.Location = new System.Drawing.Point(353, 72);
			this.BTN_UPDATE.Name = "BTN_UPDATE";
			this.BTN_UPDATE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.BTN_UPDATE.Size = new System.Drawing.Size(87, 33);
			this.BTN_UPDATE.TabIndex = 16;
			this.BTN_UPDATE.Text = "Update";
			this.BTN_UPDATE.UseVisualStyleBackColor = true;
			this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(204, 12);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(37, 34);
			this.textBox2.TabIndex = 17;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(12, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 29);
			this.label6.TabIndex = 18;
			this.label6.Text = "ID:";
			// 
			// BTN_NEW
			// 
			this.BTN_NEW.Location = new System.Drawing.Point(353, 168);
			this.BTN_NEW.Name = "BTN_NEW";
			this.BTN_NEW.Size = new System.Drawing.Size(87, 33);
			this.BTN_NEW.TabIndex = 19;
			this.BTN_NEW.Text = "New";
			this.BTN_NEW.UseVisualStyleBackColor = true;
			this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click);
			// 
			// categoryBindingSource
			// 
			this.categoryBindingSource.DataMember = "Category";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.DataSource = this.categoryBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(368, 207);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(282, 171);
			this.dataGridView1.TabIndex = 20;
			// 
			// categoryBindingSource1
			// 
			this.categoryBindingSource1.DataMember = "Category";
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "DataSet1";
			this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataSet1BindingSource
			// 
			this.dataSet1BindingSource.DataSource = this.dataSet1;
			this.dataSet1BindingSource.Position = 0;
			// 
			// webshopdbDataSet
			// 
			this.webshopdbDataSet.DataSetName = "webshopdbDataSet";
			this.webshopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// productsBindingSource
			// 
			this.productsBindingSource.DataMember = "Products";
			this.productsBindingSource.DataSource = this.webshopdbDataSet;
			// 
			// productsTableAdapter
			// 
			this.productsTableAdapter.ClearBeforeFill = true;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productnameDataGridViewTextBoxColumn
			// 
			this.productnameDataGridViewTextBoxColumn.DataPropertyName = "productname";
			this.productnameDataGridViewTextBoxColumn.HeaderText = "productname";
			this.productnameDataGridViewTextBoxColumn.Name = "productnameDataGridViewTextBoxColumn";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// instockDataGridViewTextBoxColumn
			// 
			this.instockDataGridViewTextBoxColumn.DataPropertyName = "instock";
			this.instockDataGridViewTextBoxColumn.HeaderText = "instock";
			this.instockDataGridViewTextBoxColumn.Name = "instockDataGridViewTextBoxColumn";
			// 
			// pictureDataGridViewImageColumn
			// 
			this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
			this.pictureDataGridViewImageColumn.HeaderText = "picture";
			this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			// 
			// categoryidDataGridViewTextBoxColumn
			// 
			this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "categoryid";
			this.categoryidDataGridViewTextBoxColumn.HeaderText = "categoryid";
			this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
			// 
			// AddProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1398, 718);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.BTN_NEW);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.BTN_UPDATE);
			this.Controls.Add(this.BTN_DELETE);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxCategory);
			this.Controls.Add(this.BTN_INSERT);
			this.Controls.Add(this.BTN_CHOOSE_IMAGE);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxInstock);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxPrice);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.label1);
			this.Name = "AddProducts";
			this.Text = "AddProducts";
			this.Load += new System.EventHandler(this.AddProducts_Load);
			((System.ComponentModel.ISupportInitialize)(this.textBoxID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.webshopdbDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView textBoxID;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxInstock;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button BTN_CHOOSE_IMAGE;
		private System.Windows.Forms.Button BTN_INSERT;
		private System.Windows.Forms.TextBox textBoxCategory;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button BTN_DELETE;
		private System.Windows.Forms.Button BTN_UPDATE;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button BTN_NEW;
	
		private System.Windows.Forms.BindingSource categoryBindingSource;
	
		private System.Windows.Forms.DataGridView dataGridView1;
		
		private System.Windows.Forms.BindingSource categoryBindingSource1;
		private DataSet1 dataSet1;
		private System.Windows.Forms.BindingSource dataSet1BindingSource;
		private webshopdbDataSet webshopdbDataSet;
		private System.Windows.Forms.BindingSource productsBindingSource;
		private webshopdbDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn instockDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
	}
}