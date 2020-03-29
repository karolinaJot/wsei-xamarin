 using AirMonitor.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AirMonitor.ViewModels
{
	class HomeViewModel
	{
		private readonly INavigation navigation;

		public HomeViewModel(INavigation nav)
		{
			navigation = nav;
		}

		private ICommand goToDetailsCommand;
		public ICommand GoToDetailsCommand => goToDetailsCommand ?? (goToDetailsCommand = new Command(OnGoToDetails));

		private void OnGoToDetails()
		{
			navigation.PushAsync(new DetailsPage());
		}
	}
}
