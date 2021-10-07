using System;

namespace REST_service
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(GetRandomCarUri());
		}

		public static string CompleteQuery(string query)
		{
			if (query[0..3] == "GET")
			{

			}
		}

		public static string GetRandomCarUri()
		{
			Random random = new();
			string[] chars = { "А", "Е", "T", "О", "Р", "Н", "У", "К", "Х", "С", "В", "М" };

			return $"{chars[random.Next(0, 12)]}{random.Next(1, 10)}{random.Next(1, 10)}{random.Next(1, 10)}{chars[random.Next(0, 12)]}{chars[random.Next(0, 12)]} 116 RUS";
		}
	}
}
