using System;
using System.Text;
namespace _12.Parse_URL
{
	class Program
	{
		static void Main()
		{
			string URL = Console.ReadLine();
			
			//protocol
			int indexOfProtocol = URL.IndexOf("://");
			string protocol = URL.Substring(0, indexOfProtocol);
			URL = URL.Substring(indexOfProtocol+3);
			
			//server 
			int indexOfServer = URL.IndexOf("/");
			string server = URL.Substring(0,indexOfServer);
			URL = URL.Substring(indexOfServer);

			//resource
			string resource = URL;
			Console.WriteLine("[protocol] = " + protocol);
			Console.WriteLine("[server] = " + server);
			Console.WriteLine("[resource] = " + resource);

		}
	}
}
