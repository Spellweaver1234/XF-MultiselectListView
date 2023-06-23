using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MultiselectListViewXF
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			BindingContext = new MainPageVM();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			((MainPageVM)BindingContext).OnAppearing();
		}
	}
}
