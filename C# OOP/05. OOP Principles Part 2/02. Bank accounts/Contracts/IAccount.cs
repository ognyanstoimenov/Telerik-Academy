namespace _02.Bank_accounts.Contracts
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public interface IAccount : IDepositable
	{
		ICustomer Customer { get; }
		decimal Balance { get; }
		decimal MonthlyInterest { get; }
		decimal CalculateInterest(int months);
	}
}
