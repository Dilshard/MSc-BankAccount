using System;
namespace BankAccountProj
{
	public class CalcManager
	{
		public CalcManager()
		{
		}

		public static bool isEven(int n)
        {
			int answer = n % 2;

			if(answer == 0)
            {
				return true;
            }
            else
            {
				return false;
            }
        }

		public static int cube(int n)
        {
			int answer = Convert.ToInt32(Math.Pow(n, 3));
			return answer;
        }

		public static double add(double[] x)
        {
			double answer = 0;

			for(int y = 0; y < x.Length; y++)
            {
				answer = answer + x[y];
            }

			return answer;
        }
	}
}

