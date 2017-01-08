namespace _02.Students_and_workers
{
	public class Worker : Human
	{

		public Worker(string firstName, string lastName,decimal salary,int workHoursPerDay) : base(firstName,lastName)
		{
			this.WeekSalary = salary;
			this.WorkHoursPerDay = workHoursPerDay;
		}

		public decimal WeekSalary { get; private set; }

		public int WorkHoursPerDay { get; private set; }

		public decimal MoneyPerHour()
		{
			return WeekSalary / (WorkHoursPerDay * 5);
		}
	}
}
