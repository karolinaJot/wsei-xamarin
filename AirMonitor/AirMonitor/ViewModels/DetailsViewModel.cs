using AirMonitor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;

namespace AirMonitor.ViewModels
{
	public class DetailsViewModel : BaseViewModel
	{

		
		public DetailsViewModel()
		{ 
		
		}

		private Measurement _item;
		public Measurement Item
		{
			get => _item;
			set
			{
				SetProperty(ref _item, value);

				UpdateProperties();
			}
		}

		private void UpdateProperties()
		{
			if (Item?.Current == null) return;
			var current = Item?.Current;
			var index = current.Indexes?.FirstOrDefault(c => c.Name == "AIRLY_CAQI");
			var values = current.Values;
			var standards = current.Standards;

			CaqiValue = (int)Math.Round(index?.Value ?? 0);
			CaqiTitle = index.Description;
			CaqiDescription = index.Advice;
			Pm25Value = (int)Math.Round(values?.FirstOrDefault(s => s.Name == "PM25")?.Value ?? 0);
			Pm10Value = (int)Math.Round(values?.FirstOrDefault(s => s.Name == "PM10")?.Value ?? 0);
			HumidityPercent = (int)Math.Round(values?.FirstOrDefault(s => s.Name == "HUMIDITY")?.Value ?? 0);
			PressureValue = (int)Math.Round(values?.FirstOrDefault(s => s.Name == "PRESSURE")?.Value ?? 0);
			Pm25Percent = (int)Math.Round(standards?.FirstOrDefault(s => s.Pollutant == "PM25")?.Percent ?? 0);
			Pm10Percent = (int)Math.Round(standards?.FirstOrDefault(s => s.Pollutant == "PM10")?.Percent ?? 0);
		}

		private int caqiValue = 77;
		public int CaqiValue
		{
			get => caqiValue;
			set => SetProperty(ref caqiValue, value);
		
		}

		private string caqiTitle = "Świetna jakość!";
		public string CaqiTitle
		{
			get => caqiTitle;
			set => SetProperty(ref caqiTitle, value);
		}

		private string caqiDescription = "Przewietrz mieszkanie. Wyjdź z domu. Idź na spacer, pobiegaj, wyprowadź psa sąsiadki. Powietrze jest przyjemne.";
		public string CaqiDescription
		{
			get => caqiDescription;
			set => SetProperty(ref caqiDescription, value);
		}

		private int pm25Value = 10;
		public int Pm25Value 
		{
			get => pm25Value;
			set => SetProperty(ref caqiValue, value);
		}

		private int pm25Percent = 137;
		public int Pm25Percent
		{
			get => pm25Percent;
			set => SetProperty(ref pm25Percent, value);
		}

		private int pm10Value = 67;
		public int Pm10Value
		{
			get => pm10Value;
			set => SetProperty(ref pm10Value, value);
		}

		private int pm10Percent = 135;
		public int Pm10Percent
		{
			get => pm10Percent;
			set => SetProperty(ref pm10Percent, value);
		}

		private double humidityPercent = 0.95;
		public double HumidityPercent
		{
			get => humidityPercent;
			set => SetProperty(ref humidityPercent, value);
		}

		private int pressureValue = 1027;
		public int PressureValue
		{
			get => pressureValue;
			set => SetProperty(ref pressureValue, value);
		}


		
	}
}
