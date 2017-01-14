namespace _02.Bank_accounts.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Contracts;

	public class CompanyCustomer : Customer, ICustomer, ICompany
	{
		public CompanyCustomer(string name, string address, string phone) : base(name, phone)
		{
			this.Address = address;
		}

		public string Address { get; private set; }

		public override string ToString()
		{
			StringBuilder result = new StringBuilder();
			result.Append(string.Format($"COMPANY: {this.Name} Address:{this.Address} \n"));
			foreach (var acc in this.Accounts)
			{
				result.Append(string.Format($"{acc.GetType().Name}: Balance=${acc.Balance}, Monthly Interest= ${acc.MonthlyInterest}\n"));
			}
			return result.ToString();
		}
	}
}

