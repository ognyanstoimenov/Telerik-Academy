namespace SchoolSystem.Models
{
    using System;
    using System.Text.RegularExpressions;
    public class Student
    {
        private string name;
        private int id;

        internal Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || !Regex.IsMatch(value, @"^[A-Z][a-z]*\s[A-Z][a-z]*$"))
                {
                    throw new ArgumentException("Name invalid!");
                }
                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < 10000 || value > 100000)
                {
                    throw new ArgumentException("Value out of range");
                }
                this.id = value;
            }
        }
        public override string ToString()
        {
            return $"{this.Name} ID: {this.Id}";
        }
    }
}
