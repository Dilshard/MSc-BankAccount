using System;
namespace BankAccountProj
{
	public class BankAccount:IComparable<BankAccount>
	{
		private String number; //object variables
		private double balance;
		private Person owner;
		private static int accountCount; //class variable


		//Constructor 1
		public BankAccount(String enteredNum, double enteredBalance, Person owner)
		{
			number = enteredNum;
			balance = enteredBalance;
			this.owner = owner;
			accountCount++;
		}

		//Constructor 2
		public BankAccount(String enteredNum, double enteredBalance)
		{
			number = enteredNum;
			balance = enteredBalance;
			accountCount++;
		}

		//Constructor 3
		public BankAccount(String enteredNum)
		{
			number = enteredNum;
			balance = 0;
			accountCount++;
		}

		public void deposit(double amount)
        {
			balance = balance + amount;

        }

		public void deposit(double amount, double interest)
		{
			balance = (balance + amount) + interest;

		}

		//public void deposit(double money)
		//{
		//	balance = balance + money;

		//}

		public virtual void withdraw(double amount)
        {
            if (canwithdraw(amount))
            {
				balance = balance - amount;
            }
            else
            {
                Console.WriteLine("Sorry, Account has no sufficent balance!");
            }
        }

		private bool canwithdraw(double amount)
        {
			if(this.balance >= amount)
            {
				return true;
            }
            else
            {
				return false;
            }
        }

		public double getBalance()
        {
			return balance;
        }

		public String getOwnerInfo()
        {
			//Address will not be printed on directly created object(Method 1) since PERSON constructor is not having ADDRESS parameter
			//return "\nFull Name : " + owner.getName() + " " + owner.getSurName() + "\nDate of Birth : " + owner.getYearOfBirth() + "\nAddress : " + owner.getAddress() + "\n";
			return owner.getName()+" "+owner.getSurName();
        }

		public void MoveAccount(BankAccount otherAccount)
        {
			this.balance = this.balance + otherAccount.balance;
        }

		public bool isAccountClosed()
        {
			bool status;

			if(balance == 0)
            {
				status = true;
            }
            else
            {
				status = false;
            }

			return status;
        }

		//Static methods can have only static attributes
		public static int getAccountCount()
        {
			//accountCount is static attribute / class variable
			return accountCount;
        }

		public String getAccountNo()
        {
			return number;
        }

		public int CompareTo(BankAccount bank)
        {
			//return (this.getAccountNo().Equals(bank.getAccountNo()));
			return (int)(this.getBalance() - bank.getBalance());
        }
	}
}

