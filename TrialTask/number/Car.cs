using System;
using System.Collections.Generic;

namespace number
{
	public class Car
	{
		public string Uri 
		{ 
			get
			{
				string[] chars = { "À", "Å", "T", "Î", "Ð", "Í", "Ó", "Ê", "Õ", "Ñ", "Â", "Ì" };
				string result;

				do
				{
					result = $"{chars[random.Next(0, 12)]}{random.Next(1, 10)}{random.Next(1, 10)}{random.Next(1, 10)}{chars[random.Next(0, 12)]}{chars[random.Next(0, 12)]} 116 RUS";
				}
				while (Uris.Contains(result));
				Uris.Add(result);
				return result;
			}
		}

		readonly Random random = new();
		static List<string> Uris = new();
	}
}
