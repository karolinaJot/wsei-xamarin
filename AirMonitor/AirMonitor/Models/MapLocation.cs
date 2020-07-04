using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace AirMonitor.Models
{
	public class MapLocation
	{
		public Position Position { get; set; }
		public string Address { get; set; }
		public string Description { get; set; }
	}
}
