namespace HW5Q1;

class Program
{
    static void Main(string[] args)
    {
        int int1, int2;
        int returned_num = output(out int1,out int2);
        Console.WriteLine($"a = {int1}, b = {int2}");
        Console.WriteLine($"Largest number is {returned_num}");
    }
    static int output(out int num1, out int num2)
    {
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
