/*
 * Binary to Decimal Converter
 * Converts binary to decimal number.
 * v1.0 2016
 * David B.
*/


using System;
using System.Collections;

namespace binaryToDecimal
{
	class MainClass
	{
		public static void calculateDec()
		{
			Console.WriteLine("Enter your binary number: ");
			string number = Convert.ToString(Console.ReadLine());
			int[] numberArray = new int[number.Length];
			for (int i = 0; i < number.Length; i++)
			{
				numberArray[i] = number[i];
			}

			int result = 0;
			int power = 0;

			for (int i = numberArray.Length - 1; i >= 0; i--)
			{
				int placeholder = numberArray[i] - 48;
				if (placeholder == 0)
				{
					result = result;
				}
				else
				{
					result = result + (int)Math.Pow(2, power);
				}

				power = power + 1;

			}

			Console.WriteLine(result);

		}

		public static void Main(string[] args)
		{
			calculateDec();
		}
	}
}
