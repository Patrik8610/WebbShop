using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adminwebbshop
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{

			AddProducts ss = new AddProducts();
			ss.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Categorys ss = new Categorys();
			ss.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Customers ss = new Customers();
			ss.Show();
		}
		private void button4_Click(object sender, EventArgs e)
		{
			Order ss = new Order();
			ss.Show();
		}
	}
}
