using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Android.Locations;

namespace AirMonitor.Models
{
	public class Installation
	{
		public int Id { get; set; }
		public Address Address { get; set; }

		public Location Location { get; set; }

		public double Elevation { get; set; }
		[JsonProperty(PropertyName = "airly")]

		public bool IsAirlyInstallation { get; set; }

	}
}
