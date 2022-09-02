using System;
namespace BankAccountProj
{
	public class Person
	{
		private String name;
		private String surname;
		private int yearOfBirth;
		private String address;

		public Person(String name, String surname, int yearOfBirth)
		{
			this.name = name;
			this.surname = surname;
			this.yearOfBirth = yearOfBirth;
		}

		public String getName()
        {
			return name;
        }

		public String getSurName()
        {
			return surname;
        }

		public int getYearOfBirth()
        {
			return yearOfBirth;
        }

		public void setAddress(String add)
        {
			this.address = add;
        }

		public String getAddress()
        {
			return address;
        }

		public void display()
        {
			//Console.WriteLine("Name : " + getName());
			//Console.WriteLine("Surname : " + getSurName());
			//Console.WriteLine("Year of borth : " + getYearOfBirth());
			//Console.WriteLine("Address : " + getAddress());

			Console.WriteLine(getName() + " " + getSurName());

			
		}
	}
}

