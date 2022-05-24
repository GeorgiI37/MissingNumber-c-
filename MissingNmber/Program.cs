using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.WriteLine("Enter A:");
				int a = Int32.Parse(Console.ReadLine());
				int b = 0;


				while (true)
				{
					Console.WriteLine("Enter B:");
					b = Int32.Parse(Console.ReadLine());
					if (b <= a)
						Console.WriteLine("B should be larger thann a");
					else
						break;
				}

				Console.WriteLine("Enter comma splited list values:");
				string listString = Console.ReadLine();

				List<int> includesList = listString.Split(',').Select(int.Parse).ToList();

				string result = Missing(a, b, includesList);

				Console.WriteLine("Result:");
				Console.WriteLine(result);
				Console.ReadLine();
			}
			catch { }
		}

		static string Missing(int a, int b, List<int> includesList) {
			List<int> exceptionList = new List<int>();

			for (int i = a; i <= b; i++)
			{
				if (!includesList.Contains(i))
					exceptionList.Add(i);
			}
			string result = string.Join(",", exceptionList.Select(n => n.ToString()).ToArray());
			return result;
		}
    }
}
