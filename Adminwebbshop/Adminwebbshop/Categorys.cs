using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Adminwebbshop
{
	public partial class Categorys : Form
	{
		public Categorys()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QLG3D80\\SQLEXPRESS;Initial Catalog=webshopdb;Integrated Security=True");



		private void AddProducts_Load(object sender, EventArgs e)
		{
			FILLDGV();
		}


		public void FILLDGV()
		{
			SqlCommand command = new SqlCommand("SELECT * FROM category", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();

			adapter.Fill(table);
			textBoxID.DataSource = table;
			textBoxID.RowTemplate.Height = 60;
			textBoxID.AllowUserToAddRows = false;

		}

	

		private void BTN_INSERT_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("INSERT INTO Category (categoryname )VALUES(@category)", connection);

			
			command.Parameters.Add("@category", SqlDbType.NVarChar).Value = textBoxCategory.Text;

			ExecMyQuery(command, "Data inserted");
		}
		public void ExecMyQuery(SqlCommand mcomb, string myMsg)
		{
			connection.Open();
			if (mcomb.ExecuteNonQuery() == 1)
			{
				MessageBox.Show(myMsg);
			}
			else
			{
				MessageBox.Show("Query not executed");
			}

			connection.Close();
			FILLDGV();

		}






		private void BTN_UPDATE_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("UPDATE Category SET categoryname=@category WHERE id=@id ", connection);

			command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBox2.Text;
			command.Parameters.Add("@category", SqlDbType.NVarChar).Value = textBoxCategory.Text;

			ExecMyQuery(command, "Data Updated");
		}

		private void BTN_DELETE_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("DELETE FROM Category WHERE id=@id", connection);

			command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBox2.Text;


			ExecMyQuery(command, "Data Deleted");
		}
		

		private void textBoxID_Click(object sender, EventArgs e)
		{
			textBox2.Text = textBoxID.CurrentRow.Cells[0].Value.ToString();
			textBoxCategory.Text = textBoxID.CurrentRow.Cells[1].Value.ToString();
		}

		private void BTN_NEW_Click_1(object sender, EventArgs e)
		{
			ClearField();
		}
		public void ClearField()
		{

			textBox2.Text = "";
			textBoxCategory.Text = "";



		}

		private void Categorys_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'webshopdbDataSet.Category' table. You can move, or remove it, as needed.
			this.categoryTableAdapter.Fill(this.webshopdbDataSet.Category);

		}
	}
}
