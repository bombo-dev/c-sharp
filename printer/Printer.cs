using System;
namespace CSharpGrammer.printer
{
	public class Printer
	{
		public Printer()
		{

		}

		public static void displayChoiceClassMsg()
		{
			Console.WriteLine("직업을 선택하세요!");
		}

		public static void displayClassInfo()
		{
			int[] values = (int[])Enum.GetValues(typeof(ClassInfo));
			string[] names = (string[])Enum.GetNames(typeof(ClassInfo));

			for (int i = 0; i < values.Length; i++)
			{
				Console.WriteLine($"[{values[i]}] {names[i]}");
			}
		}
	}
}

