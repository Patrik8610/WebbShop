using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShopPage.Models;

namespace WebShopPage.Controllers
{
    public class ShoppingCartController : Controller
    {

		private webshopdbEntities2 web = new webshopdbEntities2();
		// GET: ShoppingCart
		public ActionResult Cart()
        {
            return View();
        }
		//kollar om det finns en session av typen cart

		private int isExisting(int id)
		{
			List<Item> cart = (List<Item>)Session["cart"];
			for (int i = 0; i < cart.Count; i++)
			
				if (cart[i].Product.id==id)
				
					return i;
			return -1;
				

			
		}
		// tar bort produkter från shoppincarten
		public ActionResult Delete(int id)
		{

			int index = isExisting(id);
			List<Item> cart = (List<Item>)Session["cart"];
			cart.RemoveAt(index);
			Session["cart"] = cart;

			return View("Cart");
		}


		public ActionResult OrderNow(int id)
		{
			//lägger till i cart och kollar om det redan finns en product isåfall lägg till e i den produkten itälllet för att skapa två enskilda produkter

			if (Session["cart"] == null)
			{
				List<Item> cart = new List<Item>();
				cart.Add(new Item(web.Products.Find(id),1));
				Session["cart"] = cart;

			}
			else
			{
				List<Item> cart = (List<Item>)Session["cart"];
				int index = isExisting(id);
				if (index == -1)
					cart.Add(new Item(web.Products.Find(id), 1));
				else
					cart[index].Quantity++;
				Session["cart"] = cart;
			}
			return View("Cart");
		}
		public ActionResult Checkout()
		{
			return View("Checkout");
			
		}
		public ActionResult saveOrder( FormCollection fc)
			//Sparar customer  och producterna i databsen
		{
			List<Item> cart = (List<Item>)Session["cart"];
			Customer customer = new Customer();
			//Save invoice
			customer.fname = fc["fname"];
			customer.lname = fc["lname"];
			customer.adress = fc["adress"];
			customer.postcode = fc["postcode"];
			customer.city = fc["city"];
			customer.country = fc["country"];
			customer.phonenumber = fc["phonenumber"];
			customer.email = fc["email"];

			web.Customer.Add(customer);
			web.SaveChanges();

			//Save invoice detail

			foreach (Item Item in cart)
			{
				Order order = new Order();
				order.cutomerid = customer.id;
				order.quantity = Item.Quantity;
				order.Price = Item.Product.price;
				order.status = "New Order";
				order.productid = Item.Product.id;
				web.Order.Add(order);
				web.SaveChanges();
			}
			//Clear all item in cart
			Session.Remove("cart");



			return View("saveOrder");

		}




		//public ActionResult Checkout(FormCollection fc)
		//{
		//	String[] quantities = fc.GetValues("quantity");
		//	List<Item> cart = (List<Item>)Session["cart"];
		//	for (int i = 0; i < cart.Count; i++)
		//		cart[i].Quantity = Convert.ToInt32(quantities[i]);
		//	Session["cart"] = cart;
		//	return View("cart");
	}
}