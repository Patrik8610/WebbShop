namespace Adminwebbshop
{
	partial class Customers
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
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.textBoxPostcode = new System.Windows.Forms.TextBox();
			this.textBoxQAdress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxLname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BTN_NEW = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.BTN_UPDATE = new System.Windows.Forms.Button();
			this.BTN_DELETE = new System.Windows.Forms.Button();
			this.BTN_INSERT = new System.Windows.Forms.Button();
			this.textBoxFname = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.postcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.webshopdbDataSet = new Adminwebbshop.webshopdbDataSet();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.textBoxCountry = new System.Windows.Forms.TextBox();
			this.customerTableAdapter = new Adminwebbshop.webshopdbDataSetTableAdapters.CustomerTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.textBoxID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.webshopdbDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(50, 409);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(109, 29);
			this.label7.TabIndex = 75;
			this.label7.Text = "Country:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(50, 357);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 29);
			this.label5.TabIndex = 74;
			this.label5.Text = "City:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(50, 296);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 29);
			this.label4.TabIndex = 73;
			this.label4.Text = "Postcode:";
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxEmail.Location = new System.Drawing.Point(266, 523);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(219, 34);
			this.textBoxEmail.TabIndex = 72;
			// 
			// textBoxPhone
			// 
			this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPhone.Location = new System.Drawing.Point(266, 465);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(219, 34);
			this.textBoxPhone.TabIndex = 71;
			// 
			// textBoxPostcode
			// 
			this.textBoxPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPostcode.Location = new System.Drawing.Point(266, 293);
			this.textBoxPostcode.Name = "textBoxPostcode";
			this.textBoxPostcode.Size = new System.Drawing.Size(219, 34);
			this.textBoxPostcode.TabIndex = 70;
			// 
			// textBoxQAdress
			// 
			this.textBoxQAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxQAdress.Location = new System.Drawing.Point(266, 240);
			this.textBoxQAdress.Name = "textBoxQAdress";
			this.textBoxQAdress.Size = new System.Drawing.Size(219, 34);
			this.textBoxQAdress.TabIndex = 69;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(50, 240);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 29);
			this.label3.TabIndex = 68;
			this.label3.Text = "Adress:";
			// 
			// textBoxLname
			// 
			this.textBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxLname.Location = new System.Drawing.Point(266, 184);
			this.textBoxLname.Name = "textBoxLname";
			this.textBoxLname.Size = new System.Drawing.Size(219, 34);
			this.textBoxLname.TabIndex = 67;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(50, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 29);
			this.label2.TabIndex = 66;
			this.label2.Text = "Lastname:";
			// 
			// BTN_NEW
			// 
			this.BTN_NEW.Location = new System.Drawing.Point(534, 385);
			this.BTN_NEW.Name = "BTN_NEW";
			this.BTN_NEW.Size = new System.Drawing.Size(87, 33);
			this.BTN_NEW.TabIndex = 65;
			this.BTN_NEW.Text = "New";
			this.BTN_NEW.UseVisualStyleBackColor = true;
			this.BTN_NEW.Click += new System.EventHandler(this.BTN_NEW_Click_1);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(50, 62);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 29);
			this.label6.TabIndex = 64;
			this.label6.Text = "ID:";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(266, 62);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(47, 34);
			this.textBox2.TabIndex = 63;
			// 
			// BTN_UPDATE
			// 
			this.BTN_UPDATE.Location = new System.Drawing.Point(534, 272);
			this.BTN_UPDATE.Name = "BTN_UPDATE";
			this.BTN_UPDATE.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.BTN_UPDATE.Size = new System.Drawing.Size(87, 33);
			this.BTN_UPDATE.TabIndex = 62;
			this.BTN_UPDATE.Text = "Update";
			this.BTN_UPDATE.UseVisualStyleBackColor = true;
			this.BTN_UPDATE.Click += new System.EventHandler(this.BTN_UPDATE_Click);
			// 
			// BTN_DELETE
			// 
			this.BTN_DELETE.Location = new System.Drawing.Point(534, 330);
			this.BTN_DELETE.Name = "BTN_DELETE";
			this.BTN_DELETE.Size = new System.Drawing.Size(87, 33);
			this.BTN_DELETE.TabIndex = 61;
			this.BTN_DELETE.Text = "Delete";
			this.BTN_DELETE.UseVisualStyleBackColor = true;
			this.BTN_DELETE.Click += new System.EventHandler(this.BTN_DELETE_Click);
			// 
			// BTN_INSERT
			// 
			this.BTN_INSERT.Location = new System.Drawing.Point(534, 219);
			this.BTN_INSERT.Name = "BTN_INSERT";
			this.BTN_INSERT.Size = new System.Drawing.Size(87, 33);
			this.BTN_INSERT.TabIndex = 60;
			this.BTN_INSERT.Text = "Save";
			this.BTN_INSERT.UseVisualStyleBackColor = true;
			this.BTN_INSERT.Click += new System.EventHandler(this.BTN_INSERT_Click);
			// 
			// textBoxFname
			// 
			this.textBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxFname.Location = new System.Drawing.Point(266, 116);
			this.textBoxFname.Name = "textBoxFname";
			this.textBoxFname.Size = new System.Drawing.Size(219, 34);
			this.textBoxFname.TabIndex = 59;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(50, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 29);
			this.label1.TabIndex = 58;
			this.label1.Text = "Firstname:";
			// 
			// textBoxID
			// 
			this.textBoxID.AutoGenerateColumns = false;
			this.textBoxID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.textBoxID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.postcodeDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
			this.textBoxID.DataSource = this.customerBindingSource;
			this.textBoxID.Location = new System.Drawing.Point(651, 149);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.RowTemplate.Height = 24;
			this.textBoxID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.textBoxID.Size = new System.Drawing.Size(751, 388);
			this.textBoxID.TabIndex = 57;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// fnameDataGridViewTextBoxColumn
			// 
			this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
			this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
			this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
			// 
			// lnameDataGridViewTextBoxColumn
			// 
			this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
			this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
			this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
			// 
			// adressDataGridViewTextBoxColumn
			// 
			this.adressDataGridViewTextBoxColumn.DataPropertyName = "adress";
			this.adressDataGridViewTextBoxColumn.HeaderText = "adress";
			this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
			// 
			// postcodeDataGridViewTextBoxColumn
			// 
			this.postcodeDataGridViewTextBoxColumn.DataPropertyName = "postcode";
			this.postcodeDataGridViewTextBoxColumn.HeaderText = "postcode";
			this.postcodeDataGridViewTextBoxColumn.Name = "postcodeDataGridViewTextBoxColumn";
			// 
			// cityDataGridViewTextBoxColumn
			// 
			this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
			this.cityDataGridViewTextBoxColumn.HeaderText = "city";
			this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
			// 
			// countryDataGridViewTextBoxColumn
			// 
			this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
			this.countryDataGridViewTextBoxColumn.HeaderText = "country";
			this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
			// 
			// phonenumberDataGridViewTextBoxColumn
			// 
			this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phonenumber";
			this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phonenumber";
			this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			// 
			// customerBindingSource
			// 
			this.customerBindingSource.DataMember = "Customer";
			this.customerBindingSource.DataSource = this.webshopdbDataSet;
			// 
			// webshopdbDataSet
			// 
			this.webshopdbDataSet.DataSetName = "webshopdbDataSet";
			this.webshopdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(50, 465);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(183, 29);
			this.label8.TabIndex = 76;
			this.label8.Text = "Phonenumber:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(50, 523);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(86, 29);
			this.label9.TabIndex = 77;
			this.label9.Text = "Email:";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCity.Location = new System.Drawing.Point(266, 352);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(219, 34);
			this.textBoxCity.TabIndex = 78;
			// 
			// textBoxCountry
			// 
			this.textBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCountry.Location = new System.Drawing.Point(266, 404);
			this.textBoxCountry.Name = "textBoxCountry";
			this.textBoxCountry.Size = new System.Drawing.Size(219, 34);
			this.textBoxCountry.TabIndex = 79;
			// 
			// customerTableAdapter
			// 
			this.customerTableAdapter.ClearBeforeFill = true;
			// 
			// Customers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1414, 708);
			this.Controls.Add(this.textBoxCountry);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.textBoxPostcode);
			this.Controls.Add(this.textBoxQAdress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxLname);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BTN_NEW);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.BTN_UPDATE);
			this.Controls.Add(this.BTN_DELETE);
			this.Controls.Add(this.BTN_INSERT);
			this.Controls.Add(this.textBoxFname);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxID);
			this.Name = "Customers";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Customers_Load);
			((System.ComponentModel.ISupportInitialize)(this.textBoxID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.webshopdbDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.TextBox textBoxPostcode;
		private System.Windows.Forms.TextBox textBoxQAdress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxLname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button BTN_NEW;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button BTN_UPDATE;
		private System.Windows.Forms.Button BTN_DELETE;
		private System.Windows.Forms.Button BTN_INSERT;
		private System.Windows.Forms.TextBox textBoxFname;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView textBoxID;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.TextBox textBoxCountry;
		private webshopdbDataSet webshopdbDataSet;
		private System.Windows.Forms.BindingSource customerBindingSource;
		private webshopdbDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn postcodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
	}
}