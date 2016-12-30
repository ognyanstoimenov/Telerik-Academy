using System;

namespace _02.Company_Info
{
	class Program
	{
		static void Main()
		{
			string companyName = Console.ReadLine();
			string companyAdress = "Address: " + Console.ReadLine();
			string phoneNumber = "Tel. " + Console.ReadLine();
			string faxNumber = Console.ReadLine();
			if (faxNumber == "") faxNumber = "(no fax)";
			string webSite = "Web site: " + Console.ReadLine();
			string firstName = Console.ReadLine();
			string lastName = Console.ReadLine();
			string age = Console.ReadLine();
			string mgPhone = Console.ReadLine();
			char n = '\n';
			Console.WriteLine(companyName + n + companyAdress + n + phoneNumber + n + "Fax: " + faxNumber + n + webSite + n + "Manager: " + firstName + " " + lastName + " (age: " + age + ", tel. " + mgPhone + ")");

		}
	}
}
