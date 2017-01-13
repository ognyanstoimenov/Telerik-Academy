namespace _02.Bank_accounts.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Contracts;

	public class IndividualCustomer : Customer, ICustomer, IIndividual
	{
		public IndividualCustomer(string name,string lastName, string phone) : base(name, phone)
		{
			this.LastName = lastName;
			this.CustomerType = CustomerType.Individual;
		}

		public string LastName { get; private set; }

		public override string ToString()
		{
			StringBuilder result = new StringBuilder();
			result.Append(string.Format($"{this.Name} {this.LastName}: \n"));
			foreach (var acc in this.Accounts)
			{
				result.Append(string.Format($"{acc.GetType().Name}: Balance=${acc.Balance}, Monthly Interest= ${acc.MonthlyInterest}\n"));
			}
			return result.ToString();
		}
	}
}
