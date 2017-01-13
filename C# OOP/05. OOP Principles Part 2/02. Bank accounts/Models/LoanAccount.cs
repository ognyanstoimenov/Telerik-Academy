namespace _02.Bank_accounts.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Contracts;

	public class LoanAccount : Account, IAccount, IDepositable
	{
		public LoanAccount(ICustomer customer, decimal balance, decimal mothnlyInterest) : base(customer, balance, mothnlyInterest)
		{
		}

		public override decimal CalculateInterest(int months)
		{
			if (this.Customer.CustomerType == CustomerType.Comany)
			{
				months = months - 2;
			}
			else if (this.Customer.CustomerType == CustomerType.Individual)
			{
				months = months - 3;
			}
			return base.CalculateInterest(months);
		}
	}
}
