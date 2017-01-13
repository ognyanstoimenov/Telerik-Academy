namespace _02.Bank_accounts.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Contracts;

	public class DepositAccount : Account, IAccount, IDepositable, IDrawable
	{
		public DepositAccount(ICustomer customer, decimal balance, decimal mothnlyInterest) : base(customer, balance, mothnlyInterest)
		{

		}

		public void Draw(int amount)
		{
			this.Balance -= amount;
		}

		public override decimal CalculateInterest(int months)
		{
			if(this.Balance > 0 && this.Balance < 1000)
			{
				months = 0;
			}
			return base.CalculateInterest(months);
		}
	}
}
