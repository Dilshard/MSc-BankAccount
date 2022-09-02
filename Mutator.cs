using System;
namespace BankAccountProj
{
	public class Mutator
	{
		public Mutator()
		{
		}

		public static String UpperCase(String s)
        {
			return s.ToUpper();
        }

		public static int Increament(int n)
        {
			n++;
			return n;
        }

		public void changeArrayElement(int[] a)
        {
			for(int i=0; i < a.Length; i++)
            {
				a[i] -= 1;
            }
        }

	}
}

