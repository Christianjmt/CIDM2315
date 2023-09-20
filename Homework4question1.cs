namespace HW4Q1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input two integers: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        input(a,b);
    }
    static void input(int a, int b)
    { 
        Console.WriteLine($"a = {a}; b = {b} ");
        if(a>b)
        {
            Console.WriteLine($"The largest number is:{a}");
            
        }
        else
        {
            Console.WriteLine($"The largest number is:{b}");
            
        }
    }
}
