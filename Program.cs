using System;

namespace PalindromeStringNumber;

public class Program
{
	public static void Main(string[]args)
	{
		Console.Write("Enter something to check if it is palindrome: ");
		var text = Console.ReadLine();
		var len = text.Length;
		var flag = true;
		
		// check palindrome
		for(int i = 0; i < len/2; i++)
		{
			if(text[i] != text[len - (i + 1)])
				flag = false;
			break;
		}
		
		// If flag is true, text is palindrome
		if(flag)
			Console.WriteLine($"{text} is palindrome");
		else
			Console.WriteLine($"{text} is not palindrome");
			
		Console.ReadLine();
	}
}