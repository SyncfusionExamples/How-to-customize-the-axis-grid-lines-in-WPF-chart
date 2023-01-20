using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customize_AxisGridLines_WPF_Chart
{
	public class ViewModel
	{
		public ViewModel()
		{
			this.Data = new ObservableCollection<Model>();

			Data.Add(new Model() { XValue = "Jan", YValue1 = 37, YValue2 = 41 });
			Data.Add(new Model() { XValue = "Feb", YValue1 = 37, YValue2 = 45 });
			Data.Add(new Model() { XValue = "Mar", YValue1 = 39, YValue2 = 48 });
			Data.Add(new Model() { XValue = "Apr", YValue1 = 43, YValue2 = 52 });
			Data.Add(new Model() { XValue = "May", YValue1 = 48, YValue2 = 57 });
			Data.Add(new Model() { XValue = "Jun", YValue1 = 54, YValue2 = 61 });
			Data.Add(new Model() { XValue = "Jul", YValue1 = 57, YValue2 = 66 });
			Data.Add(new Model() { XValue = "Aug", YValue1 = 57, YValue2 = 66 });
			Data.Add(new Model() { XValue = "Sep", YValue1 = 54, YValue2 = 63 });
			Data.Add(new Model() { XValue = "Oct", YValue1 = 48, YValue2 = 55 });
			Data.Add(new Model() { XValue = "Nov", YValue1 = 43, YValue2 = 50 });
			Data.Add(new Model() { XValue = "Dec", YValue1 = 37, YValue2 = 45 });
		}

		public ObservableCollection<Model> Data
		{
			get;
			set;
		}
	}

	public class Model
	{
		public string XValue { get; set; }
		public double YValue1 { get; set; }
		public double YValue2 { get; set; }
	}
}
