namespace HW4Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Assign an int value to N: "); 
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Left align or right align?(input left or right): ");
        string b = Console.ReadLine();
        Console.WriteLine($"N is {a}; Shape is {b}");
        input(a,b);
        
        
    static void input (int a, string b)
    {
       int c = a-1;
       if(b=="left" || b == "Left")
       { 
        for(int row = 0; row<a; row++)
            {
                for(int col = 0; col<a; col++)
                {
                    if(row>=col)
                    {
                    Console.Write('*');
                    }
                }
        Console.WriteLine("");
            }
        }
        else if(b=="right" || b == "Right")
        {
            for(int row = 0; row<a; row++)
            {
                for(int spaces = 0; spaces <= c ; spaces++)
                {
                    Console.Write(" ");
                }
                for(int col = 0; col<a; col++)
                {
                    if(row>=col)
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine("");
                c--;
            }
        }
    }
    }
}