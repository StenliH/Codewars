using System;

namespace Codewars
{
	static class Kyu_6
	{
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
