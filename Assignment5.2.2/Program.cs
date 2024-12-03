namespace Assignment5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter a number:");
			int x = Convert.ToInt32(Console.ReadLine());
			RecursionNumbers(1, x);//starts from 1 and counts up to x which is 10
		}
		static void RecursionNumbers(int number, int max)
		{
			if (number <= max)
			{
				Console.WriteLine($"{number}");
				RecursionNumbers(number + 1, max);//moves to the next number 
			}
		}

	}
}
