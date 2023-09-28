namespace HW5Q3;

class Program
{
    static void Main(string[] args)
    {
        createAccount();
    }
    static bool checkAge(int birthyear)
    {
	int age = 2023-birthyear;
	
    if (age >=18)
        return true;
	else 
        return false;
    } 
    static void createAccount(){
    Console.Write("Enter a username: ");
    Console.ReadLine();
    Console.Write("Enter a password:");
    string password = Console.ReadLine();
    Console.Write("Enter password again: ");
    string passwordcheck = Console.ReadLine();
    Console.WriteLine("Enter your birthyear: ");
    int birthyear = Convert.ToInt32(Console.ReadLine());
    if(checkAge(birthyear) == true && password == passwordcheck)
    {
        Console.WriteLine("Account created successfully!");
    }
    else if(checkAge(birthyear) == false)
    {
        Console.WriteLine("Account could not be created.");
    }
    else 
    {
        Console.WriteLine("wrong password");
    }
} 

}
