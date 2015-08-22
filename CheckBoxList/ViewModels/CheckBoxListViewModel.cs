using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CheckBoxList.ViewModels
{
	public class CheckBoxListViewModel
	{
		public string[] SelectedValues { get; set; } // I'd put "private set" here but the Model Binder wouldn't work
		public IEnumerable<CheckBoxItem> CheckBoxItems { get; set; }
	}

	public class CheckBoxItem
	{
		public string Value { get; set; }  // Value of a checkbox
		public string Text { get; set; }   // Text of a checkbox
	}
}
