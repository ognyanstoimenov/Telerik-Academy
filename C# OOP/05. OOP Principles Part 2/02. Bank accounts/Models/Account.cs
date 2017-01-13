namespace _02.Bank_accounts.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Contracts;

	public abstract class Account : IAccount, IDepositable
	{
		public Account(ICustomer customer, decimal balance, decimal mothnlyInterest)
		{
			this.Customer = customer;
			this.Balance = balance;
			this.MonthlyInterest = mothnlyInterest;
			customer.Accounts.Add(this);
		}

		public ICustomer Customer { get; private set; }

		public decimal Balance { get; protected set; }

		public decimal MonthlyInterest { get; private set; }

		public void Deposit(int amount)
		{
			this.Balance += amount;
		}

		public virtual decimal CalculateInterest(int months)
		{
			months = months < 0 ? 0 : months;
			return this.MonthlyInterest * months;

		}
	}
}
