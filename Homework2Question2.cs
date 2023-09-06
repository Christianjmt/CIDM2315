namespace HW2Q2;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Please Input The First Number:");
       string Input1 = Console.ReadLine();
       Console.Write("Please Input The Second Number:");
       string Input2 = Console.ReadLine();
       Console.Write("Please Input The Third Number:");
       string Input3 = Console.ReadLine();

       int First = Convert.ToInt32(Input1);
       int Second = Convert.ToInt32(Input2);
       int Third = Convert.ToInt32(Input3);

       if(First<Second)
       {
            if(First<Third)
            {
    	    Console.WriteLine($"The smallest number is: {First}");
            }
            else
             {
    	    Console.WriteLine($"The smallest number is: {Third}");
             }
       }
       else
       { 
            if(Second<Third)
            {
    	    Console.WriteLine($"The smallest number is: {Second}");
            }
            else
            {
    	    Console.WriteLine($"The smallest number is: {Third}");
            }
       }

        


    }
}
