namespace HW3Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Assign an int value to N: "); 
        int number = Convert.ToInt32(Console.ReadLine());
        for(int row = 0; row<number; row++)
        {
            for(int col = 0; col<number; col++)
            {
    	    Console.Write("#");
            }
  	        Console.WriteLine("");
        }

    }
}
