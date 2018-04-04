using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Cake.Core;
using Cake.Core.IO;
using Cake.Core.Tooling;

namespace Cake.AndroidAdb
{
	/// <summary>
	/// Android Device
	/// </summary>
	public class AdbDeviceInfo
	{
		/// <summary>
		/// Gets or sets the serial.
		/// </summary>
		/// <value>The serial.</value>
		public string Serial { get; set; }

		/// <summary>
		/// Gets or sets the usb.
		/// </summary>
		/// <value>The usb.</value>
		public string Usb { get; set; }

		/// <summary>
		/// Gets or sets the product.
		/// </summary>
		/// <value>The product.</value>
		public string Product { get; set; }

		/// <summary>
		/// Gets or sets the model.
		/// </summary>
		/// <value>The model.</value>
		public string Model { get; set; }

		/// <summary>
		/// Gets or sets the device.
		/// </summary>
		/// <value>The device.</value>
		public string Device { get; set; }
	}
}
