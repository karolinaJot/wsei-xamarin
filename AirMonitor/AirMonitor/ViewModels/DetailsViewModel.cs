using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AirMonitor.ViewModels
{
	class DetailsViewModel
	{

		public event PropertyChangedEventHandler PropertyChanged;
		public DetailsViewModel()
		{ 
		
		}

		private int caqiValue = 77;
		public int CaqiValue
		{
			get => caqiValue;
			set => SetProperty(ref caqiValue, value);
		
		}

		private int pm25Value = 10;
		public int PM25Value 
		{
			get => pm25Value;
			set => SetProperty(ref caqiValue, value);
		}
		private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		private bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
		{
			if (EqualityComparer<T>.Default.Equals(field, value)) return false;
			field = value;

			RaisePropertyChanged(propertyName);
			return true;
		}
	}
}
