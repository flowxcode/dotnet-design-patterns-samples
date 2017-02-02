﻿using AbstractFactory.Abstract;
using AbstractFactory.Entities.Enums;

namespace AbstractFactory.Entities.Microsoft
{
	public class MicrosoftMouse : IMouse
	{
		/// <summary>
		/// The model of a mouse.
		/// </summary>
		public string Model => "Arc Touch Mouse";

		/// <summary>
		/// The current price in US dollars.
		/// </summary>
		public decimal Price => 60;

		/// <summary>
		/// The type of mouse.
		/// </summary>
		public MouseType Type => MouseType.Pc;

		/// <summary>
		/// The Vendor.
		/// </summary>
		public Company Vendor => Company.Microsoft;

		public override string ToString()
		{
			return string.Format("Model: {0}\nPrice: {1}\nType: {2}\nVendor: {3}\n", Model, Price, Type, Vendor);
		}
	}
}
