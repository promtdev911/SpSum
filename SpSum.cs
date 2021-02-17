using System;

namespace SpSum
{
    class SumTwoNums
    {
    
    	public int spSum(int a, int b)
		{
			var result = a + b;
		
			if (result > 9 && result < 20)
				return 20;
				
			return result;
		}
    }
}
