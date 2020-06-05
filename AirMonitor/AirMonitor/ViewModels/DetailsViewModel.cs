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

		private string caqiTitle = "Świetna jakość!";
		public string CaqiTitile
		{
			get => caqiTitle;
			set => SetProperty(ref caqiTitle, value);
		}

		private string caqiDescription = "Możesz bezpiecznie wyjść z domu bez swojej maski anty-smogowej i nie bać się o swoje zdrowie.";
		public string CaqiDescription
		{
			get => caqiDescription;
			set => SetProperty(ref caqiDescription, value);
		}

		private int pm25Value = 10;
		public int PM25Value 
		{
			get => pm25Value;
			set => SetProperty(ref caqiValue, value);
		}

		private int pm25Precent = 137;
		public int Pm25Precent
		{
			get => pm25Precent;
			set => SetProperty(ref pm25Precent, value);
		}

		private int pm10Value = 67;
		public int Pm10Value
		{
			get => pm10Value;
			set => SetProperty(ref pm10Value, value);
		}

		private int pm10Precent = 135;
		public int Pm10Precent
		{
			get => pm10Precent;
			set => SetProperty(ref pm10Precent, value);
		}

		private double humidityValue = 0.95;
		public double HumidityValue
		{
			get => humidityValue;
			set => SetProperty(ref humidityValue, value);
		}

		private int pressureValue = 1027;
		public int PresserValue
		{
			get => pressureValue;
			set => SetProperty(ref pressureValue, value);
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
