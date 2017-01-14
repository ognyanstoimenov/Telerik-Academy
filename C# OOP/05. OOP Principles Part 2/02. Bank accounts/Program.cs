namespace _02.Bank_accounts
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Contracts;
	using Models;

	class Program
	{
		static void Main()
		{
			ICustomer Customer1 = new IndividualCustomer("Marin","Marinov", "0896544135");
			new DepositAccount(Customer1, 186, 50);
			new MortgageAccount(Customer1, 2000, 10);
			new LoanAccount(Customer1, 344, 21);
			Console.WriteLine(Customer1.Accounts[2].CalculateInterest(3));

			Console.WriteLine("==========================");

			ICustomer Company1 = new CompanyCustomer("Terlik", "Mladost 1A", "025438712");
			new MortgageAccount(Company1, 48756, 1000);
			new DepositAccount(Company1, 486, 400);
			new LoanAccount(Company1, 811, 40);
			(Company1.Accounts[1] as DepositAccount).Draw(10);
			Console.WriteLine(Company1);
			new LoanAccount(Company1, 344, 21);
			Console.WriteLine(Company1.Accounts[0].CalculateInterest(4));
		}
	}
}
