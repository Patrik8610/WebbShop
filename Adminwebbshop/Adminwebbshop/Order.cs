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
	public partial class Order : Form
	{
		public Order()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QLG3D80\\SQLEXPRESS;Initial Catalog=webshopdb;Integrated Security=True");
		private void Order_Load(object sender, EventArgs e)
		{
			FILLDGV();

		}

		public void FILLDGV()
		{

			SqlCommand command = new SqlCommand("SELECT * FROM Order", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();

			adapter.Fill(table);
			textBoxID.DataSource = table;
			textBoxID.RowTemplate.Height = 60;
			textBoxID.AllowUserToAddRows = false;

		}



		private void BTN_INSERT_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("INSERT INTO Order (quantity, status , orderdate, Price )VALUES(@quantity, @status, @orderdate, @price)", connection);


			command.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = textBoxQuantity.Text;
			command.Parameters.Add("@status", SqlDbType.NVarChar).Value = textBoxStatus.Text;
			command.Parameters.Add("@orderdate", SqlDbType.DateTime).Value = textBoxOrderDate.Text;
			command.Parameters.Add("@price", SqlDbType.Int).Value = textBoxPrice.Text;

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
			SqlCommand command = new SqlCommand("UPDATE Order SET  quantity=@quantity, status=@status, orderdate=@orderdate, Price=@price  WHERE id=@id", connection);

			command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBoxID.Text;
			command.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = textBoxQuantity.Text;
			command.Parameters.Add("@status", SqlDbType.NVarChar).Value = textBoxStatus.Text;
			command.Parameters.Add("@orderdate", SqlDbType.NVarChar).Value = textBoxOrderDate.Text;
			command.Parameters.Add("@price", SqlDbType.NVarChar).Value = textBoxPrice.Text;

			ExecMyQuery(command, "Data Updated");
		}

		private void BTN_DELETE_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("DELETE FROM Order WHERE id=@id", connection);

			command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBoxID.Text;


			ExecMyQuery(command, "Data Deleted");
		}


		private void textBoxID_Click(object sender, EventArgs e)
		{
			textBox2.Text = textBoxID.CurrentRow.Cells[0].Value.ToString();
			textBoxCustomerId.Text = textBoxID.CurrentRow.Cells[1].Value.ToString();
			textBoxProductId.Text = textBoxID.CurrentRow.Cells[2].Value.ToString();
			textBoxQuantity.Text = textBoxID.CurrentRow.Cells[3].Value.ToString();
			textBoxStatus.Text = textBoxID.CurrentRow.Cells[4].Value.ToString();
			textBoxOrderDate.Text = textBoxID.CurrentRow.Cells[5].Value.ToString();
			textBoxPrice.Text = textBoxID.CurrentRow.Cells[6].Value.ToString();
		}

		private void BTN_NEW_Click_1(object sender, EventArgs e)
		{
			ClearField();
		}
		public void ClearField()
		{
			textBox2.Text = "";
			textBoxCustomerId.Text = "";
			textBoxProductId.Text = "";
			textBoxQuantity.Text = "";
			textBoxStatus.Text = "";
			textBoxOrderDate.Text = "";
			textBoxPrice.Text = "";
			


		}

		
	}
}
