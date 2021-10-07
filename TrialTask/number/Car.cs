using System;

namespace number
{
	public class Car
	{
		public string Uri 
		{ 
			get
			{
				string[] chars = { "À", "Å", "T", "Î", "Ð", "Í", "Ó", "Ê", "Õ", "Ñ", "Â", "Ì" };

				return $"{chars[random.Next(0, 12)]}{random.Next(1, 10)}{random.Next(1, 10)}{random.Next(1, 10)}{chars[random.Next(0, 12)]}{chars[random.Next(0, 12)]} 116 RUS";
			}
		}

		readonly Random random = new();
	}
}
