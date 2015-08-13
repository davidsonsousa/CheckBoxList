using CheckBoxList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxList.Models
{
	public class Product
	{
		public string Name { get; set; }
		public CheckBoxListViewModel Type { get; set; }
	}
}
