using System.Collections.Generic;
using System.Text;

namespace University.Other
{
	public static class ListUtils
	{
		public static string Combine<T>(this List<T> list, string delimetr = ",", string wrapper = "")
		{
			StringBuilder lBuilder = new StringBuilder();
			for (int l = 0; l < list.Count; l++)
			{
				lBuilder.Append(string.Format(wrapper + list[l] + wrapper + delimetr));
			}
			lBuilder.Remove(lBuilder.Length - 1, 1);
			return lBuilder.ToString();
		}
	}
}