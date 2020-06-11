
using AirMonitor.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AirMonitor.Models;

namespace AirMonitor.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		private HomeViewModel _viewModel => BindingContext as HomeViewModel;
		public HomePage()
		{
			InitializeComponent();
			BindingContext = new HomeViewModel(Navigation);
		}

		void ListView_ItemTapped(Object sender, ItemTappedEventArgs e)
		{
			_viewModel.GoToDetailsCommand.Execute(e.Item as Measurement);
		}
	}
}