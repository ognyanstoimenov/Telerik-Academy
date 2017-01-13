namespace _02.Bank_accounts.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Contracts;

	public abstract class Customer : ICustomer
	{
		public Customer(string name,string phone)
		{
			this.Name = name;
			this.Phone = phone;
			this.Accounts = new List<Account>();
		}

		public string Name { get; private set; }

		public string Phone	{ get; private set; }

		public IList<Account> Accounts { get; protected set; }

		public CustomerType CustomerType { get; protected set; }

	}
}

