namespace _02.Bank_accounts.Contracts
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Models;

	public interface ICustomer
	{
		string Name { get; }
		string Phone { get; }
		IList<Account> Accounts { get; }
		CustomerType CustomerType { get; }
	}
}
