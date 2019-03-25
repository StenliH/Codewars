using System;
using System.Collections.Generic;

namespace Codewars
{
	static class Kyu_6
	{
		public static char FindMissingLetter(char[] array)
		{
			char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

			bool isUpper = Char.IsUpper(array[0]);

			if (!isUpper)
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Char.ToUpper(array[i]);
				}
			}

			int index = Array.IndexOf(alphabet, array[0]);

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != alphabet[i + index])
				{
					char output = alphabet[i + index];
					return isUpper ? output : Char.ToLower(output);
				}
			}

			return ' ';
		}

		public static void Run_FindMissingLetter()
		{
			Console.WriteLine($"Missing letter is: { FindMissingLetter(new char[] { 'O','Q','R','S' }) }");
			Console.ReadLine();
		}

		public static string LongestConsec(string[] strarr, int k)
		{
			int n = strarr.Length;
			if (n == 0 || k > n || k <= 0)
				return "";

			string longestConsec = "";
			for (int i = 0; i < n-k+1; i++)
			{
				string consecTemp = "";
				for (int j = i; j < i+k; j++)
				{
					consecTemp += strarr[j];
				}

				if (longestConsec.Length < consecTemp.Length)
				{
					longestConsec = consecTemp;
				}
			}

			return longestConsec;
		}

		public static void Run_LongestConsec()
		{
			string result = Kyu_6.LongestConsec(new string[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1);
			Console.WriteLine(result);
		}
	}

}
