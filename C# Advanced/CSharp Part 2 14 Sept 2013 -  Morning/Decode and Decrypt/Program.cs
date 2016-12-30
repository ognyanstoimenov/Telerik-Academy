using System;
using System.Text;
using System.Text.RegularExpressions;
namespace Decode_and_Decrypt
{

	class Program
	{

		static string Encrypt(string text, string cypher)
		{
			int longerLength = Math.Max(text.Length, cypher.Length);
			char[] result = text.ToCharArray();
			for (int t = 0, c = 0, l = 0; l < longerLength; t++, c++, l++)
			{
				//TEXT > CYPHER
				if (c >= cypher.Length) c = 0;
				//CYPHER > TEXT;
				if (t >= text.Length) t = 0;
				result[t] = (char)(((result[t] - 65) ^ (cypher[c] - 65)) + 65);
			}
			return String.Join("", result);

		}

		static string Encode(string text)
		{
			char currentSymbol = text[0];
			StringBuilder result = new StringBuilder();
			int currentGroup = 1;
			for (int i = 1; i < text.Length; i++)
			{
				if (text[i] == currentSymbol)
				{
					currentGroup++;
				}
				if (text[i] != currentSymbol || i == text.Length - 1)
				{
					if (currentGroup > 2)
					{
						result.Append(currentGroup).Append(currentSymbol);
					}
					else
					{
						result.Append(text[i]);
						result.Append(text[i]);
					}
					{
						currentSymbol = text[i];
						currentGroup = 1;
					}
				}
			}
			return result.ToString();
		}

		static string Decode(string encodedText)
		{
			string pattern = @"([0-9]+)(.)";
			return Regex.Replace(encodedText, pattern, DecodeFunc);
			
		}
		static string DecodeFunc(Match m)
		{
			int repeatCount = int.Parse(m.Groups[1].ToString());
			char toRepeat = m.Groups[2].ToString()[0];

			return new string(toRepeat, repeatCount);
		}

		static string Decrypt(string encryptedText, string cypher)
		{
			return Encrypt(encryptedText, cypher);
		}

		static void Main()
		{
			string message = Console.ReadLine();
			int i = message.Length - 1;
			string lengthofCypherText = string.Empty;
			while (char.IsDigit(message[i]))
			{
				lengthofCypherText = message[i] + lengthofCypherText;
				i--;
			};
			int lengthofCypher = int.Parse(lengthofCypherText);
			int indexOfNum = message.LastIndexOf(lengthofCypherText);
			string messageNoNum = message.Remove(indexOfNum);
			string decodedMessage = Decode(messageNoNum);
			string cypher = decodedMessage.Substring(decodedMessage.Length - lengthofCypher);
			string messageToDecrypt = decodedMessage.Remove(decodedMessage.Length - lengthofCypher);
			Console.WriteLine(Decrypt(messageToDecrypt, cypher));
		}
	}
}
