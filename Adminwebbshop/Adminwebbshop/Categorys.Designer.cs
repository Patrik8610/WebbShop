namespace Adminwebbshop
{
	partial class Categorys
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
			this.BTN_NEW = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.BTN_UPDATE = new System.Windows.Forms.Button();
			this.BTN_DELETE = new System.Windows.Forms.Button();
			this.BTN_INSERT = new System.Windows.Forms.Button();
			this.textBoxCategory = new System.Windows.Forms.TextBox();
			this.textBoxID = new System.Windows.Forms.DataGridView();
			this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.webshopdbDataSet = new Adminwebbshop.webshopdbDataSet();
			this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.categoryTableAdapter = new Adminwebbshop.webshopdbDataSetTableAdapters.CategoryTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.textBoxID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.webshopdbDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// BTN_NEW
			// 
			this.BTN_NEW.Location = new System.Drawing.Point(392, 205);
			this.BTN_NEW.Name = "BTN_NEW";
			this.BTN_NEW.Size = new System.Drawing.Size(87, 33);
			this.BTN_NEW.TabIndex = 37;
			this.BTN_NEW.Text = "New";
			this.BTN_NEW.UseVisualStyleBackColor = true;
			this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click_1);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(33, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 29);
			this.label6.TabIndex = 36;
			this.label6.Text = "ID:";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(180, 92);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(47, 34);
			this.textBox2.TabIndex = 35;
			// 
			// BTN_UPDATE
			// 
			this.BTN_UPDATE.Location = new System.Drawing.Point(392, 88);
			this.BTN_UPDATE.Name = "BTN_UPDATE";
			this.BTN_UPDATE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.BTN_UPDATE.Size = new System.Drawing.Size(87, 33);
			this.BTN_UPDATE.TabIndex = 34;
			this.BTN_UPDATE.Text = "Update";
			this.BTN_UPDATE.UseVisualStyleBackColor = true;
			this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
			// 
			// BTN_DELETE
			// 
			this.BTN_DELETE.Location = new System.Drawing.Point(392, 144);
			this.BTN_DELETE.Name = "BTN_DELETE";
			this.BTN_DELETE.Size = new System.Drawing.Size(87, 33);
			this.BTN_DELETE.TabIndex = 33;
			this.BTN_DELETE.Text = "Delete";
			this.BTN_DELETE.UseVisualStyleBackColor = true;
			this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
			// 
			// BTN_INSERT
			// 
			this.BTN_INSERT.Location = new System.Drawing.Point(392, 30);
			this.BTN_INSERT.Name = "BTN_INSERT";
			this.BTN_INSERT.Size = new System.Drawing.Size(87, 33);
			this.BTN_INSERT.TabIndex = 29;
			this.BTN_INSERT.Text = "Save";
			this.BTN_INSERT.UseVisualStyleBackColor = true;
			this.BTN_INSERT.Click += new System.EventHandler(this.BTN_INSERT_Click);
			// 
			// textBoxCategory
			// 
			this.textBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCategory.Location = new System.Drawing.Point(180, 143);
			this.textBoxCategory.Name = "textBoxCategory";
			this.textBoxCategory.Size = new System.Drawing.Size(183, 34);
			this.textBoxCategory.TabIndex = 22;
			// 
			// textBoxID
			// 
			this.textBoxID.AutoGenerateColumns = false;
			this.textBoxID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.textBoxID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.textBoxID.DataSource = this.categoryBindingSource1;
			this.textBoxID.Location = new System.Drawing.Point(522, 10);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.RowTemplate.Height = 24;
			this.textBoxID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.textBoxID.Size = new System.Drawing.Size(400, 548);
			this.textBoxID.TabIndex = 21;
			this.textBoxID.Click += new System.EventHandler(this.textBoxID_Click);
			// 
			// categoryBindingSource
			// 
			this.categoryBindingSource.DataMember = "Category";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(33, 143);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 29);
			this.label1.TabIndex = 20;
			this.label1.Text = "Category:";
			// 
			// webshopdbDataSet
			// 
			this.webshopdbDataSet.DataSetName = "webshopdbDataSet";
			this.webshopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// categoryBindingSource1
			// 
			this.categoryBindingSource1.DataMember = "Category";
			this.categoryBindingSource1.DataSource = this.webshopdbDataSet;
			// 
			// categoryTableAdapter
			// 
			this.categoryTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn1.HeaderText = "id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "categoryname";
			this.dataGridViewTextBoxColumn2.HeaderText = "categoryname";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// Categorys
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1030, 596);
			this.Controls.Add(this.BTN_NEW);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.BTN_UPDATE);
			this.Controls.Add(this.BTN_DELETE);
			this.Controls.Add(this.BTN_INSERT);
			this.Controls.Add(this.textBoxCategory);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.label1);
			this.Name = "Categorys";
			this.Text = "Categorys";
			this.Load += new System.EventHandler(this.Categorys_Load);
			((System.ComponentModel.ISupportInitialize)(this.textBoxID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.webshopdbDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BTN_NEW;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button BTN_UPDATE;
		private System.Windows.Forms.Button BTN_DELETE;
		private System.Windows.Forms.Button BTN_INSERT;
		private System.Windows.Forms.TextBox textBoxCategory;
		private System.Windows.Forms.DataGridView textBoxID;
		private System.Windows.Forms.Label label1;
		
		private System.Windows.Forms.BindingSource categoryBindingSource;
	
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
		private webshopdbDataSet webshopdbDataSet;
		private System.Windows.Forms.BindingSource categoryBindingSource1;
		private webshopdbDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
	}
}