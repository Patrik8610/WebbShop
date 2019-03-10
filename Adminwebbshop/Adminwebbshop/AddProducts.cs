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
using System.Drawing.Imaging;

namespace Adminwebbshop
{
	public partial class AddProducts : Form
	{
		public AddProducts()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QLG3D80\\SQLEXPRESS;Initial Catalog=webshopdb;Integrated Security=True");
	

	


		public void FILLDGV()
		{
			SqlCommand command = new SqlCommand("SELECT * FROM products", connection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();

			adapter.Fill(table);
			textBoxID.DataSource = table;
			textBoxID.RowTemplate.Height = 60;
			textBoxID.AllowUserToAddRows = false;
		

		}

		private void BTN_CHOOSE_IMAGE_Click(object sender, EventArgs e)
		{
			OpenFileDialog opf = new OpenFileDialog();

			opf.Filter = "choose Image (*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif";

			if (opf.ShowDialog() == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(opf.FileName);

			}
		}

		private void dataGridView1_Click(object sender, EventArgs e)
		{
			
			byte[] img = (byte[])textBoxID.CurrentRow.Cells[4].Value;

			MemoryStream ms = new MemoryStream(img);

			pictureBox1.Image = Image.FromStream(ms);

			textBox2.Text = textBoxID.CurrentRow.Cells[0].Value.ToString();
			textBoxName.Text = textBoxID.CurrentRow.Cells[1].Value.ToString();
			textBoxPrice.Text = textBoxID.CurrentRow.Cells[2].Value.ToString();
			textBoxInstock.Text = textBoxID.CurrentRow.Cells[3].Value.ToString();
			textBoxDescription.Text = textBoxID.CurrentRow.Cells[5].Value.ToString();
			textBoxCategory.Text = textBoxID.CurrentRow.Cells[6].Value.ToString();

		}

		private void BTN_INSERT_Click(object sender, EventArgs e)
		{
			MemoryStream ms = new MemoryStream();
			pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
			byte[] img = ms.ToArray();

			SqlCommand command = new SqlCommand("INSERT INTO Products (productname, price, instock, picture, description, categoryid)VALUES(@product,@price,@stock,@picture,@desc,@categoryid)", connection);


		
			command.Parameters.Add("@product", SqlDbType.NVarChar).Value = textBoxName.Text;
			command.Parameters.Add("@price", SqlDbType.NVarChar).Value = textBoxPrice.Text;
			command.Parameters.Add("@picture", SqlDbType.Binary).Value = img;
			command.Parameters.Add("@desc", SqlDbType.Text).Value = textBoxDescription.Text;
			command.Parameters.Add("@stock", SqlDbType.NVarChar).Value = textBoxInstock.Text;
			command.Parameters.Add("@categoryid", SqlDbType.NVarChar).Value = textBoxCategory.Text;

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
			MemoryStream ms = new MemoryStream();
			pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
			byte[] img = ms.ToArray();

			SqlCommand command = new SqlCommand("UPDATE Products SET productname=@product, price=@price, instock=@stock, picture=@picture, description=@desc, categoryid=@categoryid WHERE id=@id ", connection);

			command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBox2.Text;
			command.Parameters.Add("@product", SqlDbType.NVarChar).Value = textBoxName.Text;
			command.Parameters.Add("@price", SqlDbType.NVarChar).Value = textBoxPrice.Text;
			command.Parameters.Add("@picture", SqlDbType.Binary).Value = img;
			command.Parameters.Add("@desc", SqlDbType.Text).Value = textBoxDescription.Text;
			command.Parameters.Add("@stock", SqlDbType.NVarChar).Value = textBoxInstock.Text;
			command.Parameters.Add("@categoryid", SqlDbType.NVarChar).Value = textBoxCategory.Text;

			ExecMyQuery(command, "Data Updated");
		}

		private void BTN_DELETE_Click(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("DELETE FROM Products WHERE id=@id", connection);

			command.Parameters.Add("@id", SqlDbType.NVarChar).Value = textBox2.Text;
			

			ExecMyQuery(command, "Data Deleted");

		}

		private void BTN_NEW_Click(object sender, EventArgs e)
		{
			ClearField();
		}

		public void ClearField()
		{
			
			textBox2.Text = "";
			textBoxName.Text = "";
			textBoxPrice.Text = "";
			textBoxInstock.Text = "";
			textBoxDescription.Text = "";
			textBoxCategory.Text = "";
			pictureBox1.Image = null;


		}

		private void AddProducts_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'webshopdbDataSet.Products' table. You can move, or remove it, as needed.
			this.productsTableAdapter.Fill(this.webshopdbDataSet.Products);

		}
	}
}
