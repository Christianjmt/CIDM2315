namespace HW5Q2;

class Program
{
   static void Main(string[] args)
    {
        int int1, int2, int3, int4;
        int max1 = output(out int1,out int2);
        int max2 = output(out int3,out int4);
        Console.WriteLine($"a = {int1}, b = {int2}, c = {int3}, d = {int4}");
        if(max1>max2)
        {
            Console.WriteLine($"Largest number is {max1}");
        }
        else
        {
            Console.WriteLine($"Largest number is {max2}");
        }
        
        
    }
    static int output(out int num1, out int num2)
    {
        Console.WriteLine("Please two integers.");
        Console.Write("Please input the first integer: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please input the second integer: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        
        if(num1<num2)
        {
            return num2;
        }
        else 
        {
            return num1;
        }

   }
}
