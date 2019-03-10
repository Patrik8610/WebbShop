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
	public partial class Customers : Form
	{
		public Customers()
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
			SqlCommand command = new SqlCommand("SELECT * FROM Customer", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();

			adapter.Fill(table);
			textBoxID.DataSource = table;
			textBoxID.RowTemplate.Height = 60;
			textBoxID.AllowUserToAddRows = false;

		}



		private void BTN_INSERT_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("INSERT INTO Customer (fname, lname,adress, postcode, city, country, phonenumber, email )VALUES(@fname, @lname, @adress, @postcode,@city, @country, @phonenumber, @email)", connection);


			command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = textBoxFname.Text;
			command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = textBoxLname.Text;
			command.Parameters.Add("@adress", SqlDbType.NVarChar).Value = textBoxQAdress.Text;
			command.Parameters.Add("@poscode", SqlDbType.NVarChar).Value = textBoxPostcode.Text;
			command.Parameters.Add("@city", SqlDbType.NVarChar).Value = textBoxCity.Text;
			command.Parameters.Add("@country", SqlDbType.NVarChar).Value = textBoxCountry.Text;
			command.Parameters.Add("@phonenumber", SqlDbType.NVarChar).Value = textBoxPhone.Text;
			command.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBoxEmail.Text;

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
			SqlCommand command = new SqlCommand("UPDATE Order SET categoryname=@category,quantity=@quantity, status=@status, orderdate=@orderdate, Price=@price WHERE id=@id ", connection);

			command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBox2.Text;
			command.Parameters.Add("@fname", SqlDbType.NVarChar).Value = textBoxFname.Text;
			command.Parameters.Add("@lname", SqlDbType.NVarChar).Value = textBoxLname.Text;
			command.Parameters.Add("@adress", SqlDbType.NVarChar).Value = textBoxQAdress.Text;
			command.Parameters.Add("@poscode", SqlDbType.NVarChar).Value = textBoxPostcode.Text;
			command.Parameters.Add("@city", SqlDbType.NVarChar).Value = textBoxCity.Text;
			command.Parameters.Add("@country", SqlDbType.NVarChar).Value = textBoxCountry.Text;
			command.Parameters.Add("@phonenumber", SqlDbType.NVarChar).Value = textBoxPhone.Text;
			command.Parameters.Add("@email", SqlDbType.NVarChar).Value = textBoxEmail.Text;

			ExecMyQuery(command, "Data Updated");
		}

		private void BTN_DELETE_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("DELETE FROM Customer WHERE id=@id", connection);

			command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBox2.Text;


			ExecMyQuery(command, "Data Deleted");
		}


		private void textBoxID_Click(object sender, EventArgs e)
		{
			textBox2.Text = textBoxID.CurrentRow.Cells[0].Value.ToString();
			textBoxFname.Text = textBoxID.CurrentRow.Cells[1].Value.ToString();
			textBoxLname.Text = textBoxID.CurrentRow.Cells[2].Value.ToString();
			textBoxQAdress.Text = textBoxID.CurrentRow.Cells[3].Value.ToString();
			textBoxPostcode.Text = textBoxID.CurrentRow.Cells[4].Value.ToString();
			textBoxCity.Text = textBoxID.CurrentRow.Cells[5].Value.ToString();
			textBoxCountry.Text = textBoxID.CurrentRow.Cells[6].Value.ToString();
			textBoxPhone.Text = textBoxID.CurrentRow.Cells[7].Value.ToString();
			textBoxEmail.Text = textBoxID.CurrentRow.Cells[8].Value.ToString();
		}

		private void BTN_NEW_Click_1(object sender, EventArgs e)
		{
			ClearField();
		}
		public void ClearField()
		{
			textBox2.Text = "";
			textBoxFname.Text = "";
			textBoxLname.Text = "";
			textBoxQAdress.Text = "";
			textBoxPostcode.Text = "";
			textBoxCity.Text = "";
			textBoxCountry.Text = "";
			textBoxPhone.Text = "";
			textBoxEmail.Text = "";



		}

		private void Customers_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'webshopdbDataSet.Customer' table. You can move, or remove it, as needed.
			this.customerTableAdapter.Fill(this.webshopdbDataSet.Customer);

		}
	}
}

