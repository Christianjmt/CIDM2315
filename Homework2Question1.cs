namespace HW2Q1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input a letter grade: ");
       
        string input = Console.ReadLine();
        
        if(input == "A")
        {
             Console.WriteLine("GPA Point: 4 ");
        }
        else if(input == "B")
        {
             Console.WriteLine("GPA Point: 3 ");
        }
        else if(input == "C")
        {
             Console.WriteLine("GPA Point: 2 ");
        }
       else if(input == "D" )
        {
             Console.WriteLine("GPA Point: 1 ");
        }
        else if(input == "F")
        {
             Console.WriteLine("GPA Point: 0 ");
        }
        else 
        {
             Console.WriteLine("Wrong Letter Grade!");
        }
}
}
