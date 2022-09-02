using System;
using System.Collections.Generic;

namespace BankAccountProj
{
    class Program
    {
        static void Main(string[] args)
        {
            exceptionTest();
        }

        public static void test1()
        {
            BankAccount account1 = new BankAccount("A0123", 0.5);
            BankAccount account2 = new BankAccount("A0456", 0.8);
            BankAccount account3 = new BankAccount("A0456");

            account1.deposit(500);
            account1.withdraw(100);
            Console.WriteLine(account1.getBalance());
            //Console.WriteLine(account1.getOwnerInfo()); // account1 Person is missing

            account2.deposit(800);
            account2.withdraw(200);

            //account3.balance = 500 Cannot add balance since property is private


            if (account1.getBalance() > account2.getBalance())
            {
                Console.WriteLine("Account 1 has the highest balance");
            }
            else
            {
                Console.WriteLine("Account 2 has the highest balance");
            }

            Person person1 = new Person("Dilshard", "Razick", 1992);
            person1.setAddress("Wattala");
            person1.display();

            Person p1 = new Person("Dilshard", "Razick", 1992);
            BankAccount account4 = new BankAccount("B0123", 5000, p1);
            Console.WriteLine(account4.getOwnerInfo());
        }

        public static void test2()
        {
            //METHOD 1
            Person p1 = new Person("Dilshard", "Razick", 1992);

            //Create accounts from Bank Account using array;
            BankAccount[] accounts =
            {
                new BankAccount("A0123"),
                new BankAccount("A0124",4000),
                new BankAccount("A0125",2000, p1)
            };            

            accounts[0].deposit(1000);
            accounts[0].withdraw(2000);
            //Console.WriteLine("Owner : " + accounts[0].getOwnerInfo()); // Cant because no Person assigned for constructor
            Console.WriteLine("Balance : " + accounts[0].getBalance() + "\n");

            accounts[1].deposit(100);
            accounts[1].withdraw(200);
            Console.WriteLine("Balance : " + accounts[1].getBalance() + "\n");
            //.getOwnerInfo()) cannot call since no person added to constructor

            accounts[2].deposit(5000);
            accounts[2].withdraw(4000);
            Console.WriteLine("Owner : " + accounts[2].getOwnerInfo());
            Console.WriteLine("Balance : " + accounts[2].getBalance());


            //METHOD2
            BankAccount[] account2 = new BankAccount[3];
            account2[0] = new BankAccount("ACC001", 10000);
            account2[1] = new BankAccount("ACC002", 80000);

            account2[0].deposit(1000);
            account2[0].withdraw(2000);
            
            Console.WriteLine("Balance : " + account2[0].getBalance() + "\n");
        }

        public static void test3Tu8()
        {
            Person person1 = new Person("John", "Peter", 1990);
            Person person2 = new Person("Smith", "Ann", 1992);

            BankAccount account1 = new BankAccount("A0001", 1000.50, person1);
            BankAccount account2 = new BankAccount("A0002", 490.10, person2);

            Console.WriteLine("Account 1 balance : " + account1.getBalance());
            Console.WriteLine("Account 1 Closed? : " + account1.isAccountClosed());

            Console.WriteLine("Account 2 balance : " + account2.getBalance());
            Console.WriteLine("Account 2 Closed? : " + account2.isAccountClosed());

            if (!account1.isAccountClosed() && !account2.isAccountClosed())
            {
                account1.withdraw(50.0);
                account1.MoveAccount(account2);
            }

            Console.WriteLine("Account 1 balance : " + account1.getBalance());
            Console.WriteLine("Account 1 Closed? : " + account1.isAccountClosed());

            Console.WriteLine("Account 2 balance : " + account2.getBalance());
            Console.WriteLine("Account 2 Closed? : " + account2.isAccountClosed());
        }

        public static void accountCount()
        {
            // if getAccountCount() static methos then canr create access through an object
            //BankAccount account1 = new BankAccount("A0001", 1000.50); 
            //Console.WriteLine(account1.getAccountCount());

            Console.WriteLine(BankAccount.getAccountCount());
            
        }

        public static void mutatorTest()
        {
            Console.WriteLine(Mutator.UpperCase("Hi"));
            Console.WriteLine(Mutator.Increament(200));
        }

        public static void addUsingDictionary()
        {
            //Week 11 - Page 57 | Rec 20 July 01:15:59
            //Week 12 - Page 5 | Rec 22 July 17:00:00

            Person person1 = new Person("Dilshard", "Razick", 1992);
            Person person2 = new Person("John", "Peter", 1990);
            Person person3 = new Person("Smith", "Ann", 1992);

            Person person4 = new Person("Paul", "David", 1990);
            BankAccount account1 = new BankAccount("ACC004", 4500, person4);

            Dictionary<String, BankAccount> accounts = new Dictionary<string, BankAccount>();

            accounts.Add("ACC001", new BankAccount("ACC001", 5000, person1));
            accounts.Add("ACC002", new BankAccount("ACC002", 6000, person2));
            accounts.Add("ACC003", new BankAccount("ACC003", 6500, person3));
            accounts.Add("ACC003", account1); //From manually created account

            accounts["ACC001"].withdraw(500);
            account1.withdraw(500);

            foreach(String accNumber in accounts.Keys)
            {
                Console.Write(accNumber+" : ");
                Console.WriteLine(accounts[accNumber].getOwnerInfo());
            }

            accounts.Remove("ACC002");
            //Console.WriteLine(accounts["ACC002"].getBalance()); //Account "ACC002" has been removed
            Console.WriteLine("No of accounts created : "+accounts.Count);
        }

        public static void addUsingDictionarySort()
        {
            //Week 12 - Page X | Rec 22 July 37:00:00

            Person person1 = new Person("Dilshard", "Razick", 1992);
            Person person2 = new Person("John", "Peter", 1990);
            Person person3 = new Person("Smith", "Ann", 1992);
            Person person4 = new Person("Ann", "Ann", 1991);
            Person person5 = new Person("David", "Ann", 1990);

            Dictionary<String, BankAccount> accounts = new Dictionary<string, BankAccount>();

            accounts.Add("ACC001", new BankAccount("ACC001", 15000, person1));
            accounts.Add("ACC002", new BankAccount("ACC002", 26000, person2));
            accounts.Add("ACC003", new BankAccount("ACC003", 6500, person3));
            accounts.Add("ACC004", new BankAccount("ACC004", 6500, person4));
            accounts.Add("ACC005", new BankAccount("ACC005", 8500, person5));

            List<BankAccount> bankAccountList = new List<BankAccount>(accounts.Values);

            bankAccountList.Sort();

            foreach(BankAccount bank in bankAccountList)
            {
                Console.WriteLine(bank.getBalance());
            }
            
        }

        public static void testChangeArrayElement()
        {
            Mutator mutator = new Mutator();

            int[] array = new int[3];
            array[0] = 100;
            array[1] = 200;
            array[2] = 300;

            foreach(int num in array)
            {
                Console.Write(num + " ");
            }

            
            mutator.changeArrayElement(array);


            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

        }

        public static void testCalcManager()
        {
            int number = 9;
            double[] numbers = { 10, 20, 10 };
            Console.WriteLine(CalcManager.isEven(number));
            Console.WriteLine(CalcManager.cube(number));
            Console.WriteLine(CalcManager.add(numbers));
            //Console.WriteLine(isEven(number); ERROR cannot access static method without class name
        }

        public static void testWithdraw()
        {
            //To test newly created method call "canwithdraw()" in BankAccount class
            BankAccount account = new BankAccount("ACC001", 650);
            Console.WriteLine("Balance : " + account.getBalance());
            account.withdraw(650);
            Console.WriteLine("Balance : " + account.getBalance());
            account.withdraw(1);
        }

        public static void exceptionTest()
        {
            try
            {
                int[] numbers = new int[2];
                numbers[0] = Convert.ToInt32(Console.ReadLine());
                numbers[1] = 450;

                Console.WriteLine(numbers[1]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                exceptionTest();
            }

        }
    }
}

//Utility class will have only static methods inside
//Console.WriteLine(Math.Pow(2, 4)); //Math is a class and Pow is an Static method
