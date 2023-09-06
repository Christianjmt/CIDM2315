namespace HW2B;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input a year:");
        string input = Console.ReadLine();

        int Year = Convert.ToInt32(input);

        if(Year%4 ==0 && Year%100 != 0)
        {
            Console.WriteLine($"{Year} is a leap year!");
        }
        else
        { 
            if (Year%400 == 0 )
            {
                Console.WriteLine($"{Year} is a leap year!");

            }
            else
            {
            Console.WriteLine($"{Year} is not a leap year.");
            }
        }
        
    }
}
