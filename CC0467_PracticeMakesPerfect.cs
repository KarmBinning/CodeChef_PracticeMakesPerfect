/*
 * https://www.codechef.com/problems/PRACTICEPERF
*/

using System;

public class Test
{
	public static void Main()
	{
		int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
		int count = 0;
		foreach(int ip in inputs)
		{
		    if(ip>=10)
		        count++;
		}
		Console.WriteLine(count);
	}
}
