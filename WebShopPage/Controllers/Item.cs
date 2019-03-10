using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebShopPage.Models;

namespace WebShopPage.Controllers
{

	// simpel klass för att get och set products och quantity används sedan i ShoppingCartController.
	public class Item
	{
		private Products product = new Products();
		private int quantity;


		public Products Product
		{
			get{return product;}
			set { product = value; }
		}
		public int Quantity
		{
			get { return quantity; }
			set { quantity = value; }
		}
	

		public Item()
		{ }

		public Item(Products product, int quantity)
		{
			this.product = product;
			this.quantity = quantity;

		}

		
	}
}