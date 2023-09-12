namespace HW3Q1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please Input an integer:");
        int input = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        int Factors = 0;
       if(input <= 1)
        {
            Console.WriteLine("Please input a number greater than 1.");
        }
       else
       {
        while(count <= input)
        {
            if(input%count == 0)
            {
            Factors++;
            
            }
            count++;
       }
       if(Factors == 2)
        {
            Console.WriteLine($"{input} is a prime number");
         }
       else
        {
            Console.WriteLine($"{input} is not a prime number");
        }
       }
        
        
        
        
        
        
        
        
    }
}
