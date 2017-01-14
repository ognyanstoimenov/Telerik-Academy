namespace _02.Bank_accounts.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Contracts;

	public class MortgageAccount : Account, IAccount, IDepositable
	{
		public MortgageAccount(ICustomer customer, decimal balance, decimal mothnlyInterest) : base(customer, balance, mothnlyInterest)
		{

		}

		public override decimal CalculateInterest(int months)
		{
			if (this.Customer is IIndividual)
			{
				months = months - 6;
				return base.CalculateInterest(months);
			}
			else // (this.Customer is ICompany)
			{
				decimal sum = 0;
				for (int i = 0; i < months; i++)
				{
					var toAdd = this.MonthlyInterest;
					if (i < 12)
					{
						sum += toAdd / 2;
					}
				}
				return sum;
			}
		}
	}
}
