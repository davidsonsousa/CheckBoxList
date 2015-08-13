using CheckBoxList.Models;
using CheckBoxList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckBoxList.Controllers
{
	public class HomeController : Controller
	{
		private CheckBoxListViewModel AllTypeItems()
		{
			var cbList = new CheckBoxListViewModel();

			// Add the values to be used in the checkbox list
			// The values can come from anywhere
			cbList.CheckBoxItems = new List<CheckBoxItem>
									{
										 new CheckBoxItem { Text = "Computer", Value = "Computer" },
										 new CheckBoxItem { Text = "Mobile", Value = "Mobile" },
										 new CheckBoxItem { Text = "Electronic", Value = "Electronic" }
									 };
			return cbList;
		}


		// GET: Home
		public ActionResult Index()
		{
			// Setup product
			var product = new Product();

			// Setup the checkbox list
			product.Type = AllTypeItems();

			// If we want to set a value, we need to do it manually
			// But we can improve the logic here
			// product.Type.SelectedValues = new string[] { "Computer" };

			return View(product);
		}

		[HttpPost]
		public ActionResult Index(Product product)
		{
			// Show the values we selected
			Response.Write(string.Join(", ", product.Type.SelectedValues));

			// Set the items again as they are null
			product.Type = AllTypeItems();

			return View(product);
		}
	}
}