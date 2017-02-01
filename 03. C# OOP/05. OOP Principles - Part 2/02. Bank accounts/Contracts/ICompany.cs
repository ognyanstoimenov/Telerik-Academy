namespace _02.Bank_accounts.Contracts
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public interface ICompany : ICustomer
	{
		string Address { get; }
	}
}
