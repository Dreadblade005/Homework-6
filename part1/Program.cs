using System;

namespace part1
{
	public class Counter
	{

		// Declare a integer variable 
		private int count;

		// Create a method named setCounter().
		// This method helps to set the counter to 0.
		public void setCounter()
		{
			count = 0;
		}

		// Create a method named incCounter().
		// This method helps to increase the count by 1.
		public void incCounter()
		{
			count += 1;
		}

		// Create a method named dscCounter().
		// This method helps to decrease the count by 1.	
		public void dscCounter()
		{
			// Create an if-statement to check the counter
			// is a positive integer or not.
			// To avoid negative values.
			if (count > 0)
			{
				count -= 1;
			}
		}

		// Accessor Method
		// Create an accessor method to get the current count value.
		public int getCount()
		{
			return count;
		}

		// Create a method named displayCount().
		// This method helps to outputs the count to the screen. 
		public void displayCount()
		{
			Console.Out.WriteLine("Current Count Value: " + count);
		}

		// Create a toString() method.	
		public String toString()
		{
			return "Counter [count=" + count + "]";
		}

		// Create a equals() method.
		public bool equals(Object obj)
		{
			if (this == obj)
				return true;
			if (obj == null)
				return false;
			Counter other = (Counter)obj;
			if (count != other.count)
				return false;
			return true;
		}


	}
}

public class CounterTest
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create an object named cObj for the Counter class.
			part1.Counter cObj = new part1.Counter();

			// Set Counter
			cObj.setCounter();
			// Display Counter
			cObj.displayCount();

			// Increment the counter
			cObj.incCounter();
			// Display Counter
			cObj.displayCount();

			cObj.incCounter();
			cObj.displayCount();

			// Create another counter object
			part1.Counter cObj2 = new part1.Counter();
			cObj2.setCounter();
			cObj2.incCounter();


			// Display counter values of two objects
			Console.Out.WriteLine("cObj Count Value: " + cObj.getCount());
			Console.Out.WriteLine("cObj2 Count Value: " + cObj2.getCount());

			// Check first counter object is eaual to the second counter object or not.
			Console.Out.WriteLine("cObj is equal to cObj2: " + cObj.equals(cObj2));

			// Decrement the counter.
			cObj.dscCounter();

			// Display the counter using the toString().
			Console.Out.WriteLine("cObj: " + cObj.toString());
			Console.Out.WriteLine("cObj2: " + cObj2.toString());

			Console.Out.WriteLine("cObj is equal to cObj2: " + cObj.equals(cObj2));

		}

	}
}

