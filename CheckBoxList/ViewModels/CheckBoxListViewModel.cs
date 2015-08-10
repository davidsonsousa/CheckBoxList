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
		public string[] SelectedValues { get; set; }
		public IEnumerable<CheckBoxItem> CheckBoxItems { get; set; }
	}

	public class CheckBoxItem
	{
		public string Value { get; set; }        // Value of a checkbox
		public string Text { get; set; }      // Text of a checkbox
		public object Tags { get; set; }      // Html tags to be applied to checkbox, e.g.: 'new { tagName = "tagValue" }'
		public bool IsSelected { get; set; }  // Value to select a checkbox on the list
	}
}
