namespace HW7;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(input_id: 110, input_name: "alice", input_age:28);
        Customer cus2 = new Customer(input_id: 111, input_name: "bob", input_age:30);

        cus1.PrintCusInfo();
        cus2.PrintCusInfo();

        cus1.ChangeID(220);
        cus2.ChangeID(221);

        cus1.PrintCusInfo();
        cus2.PrintCusInfo();

        cus1.CompareAge(cus2);
    }
}

class Customer
{
    public int cus_id {get;set;}
    public string cus_name;
    public int cus_age;

public Customer(int input_id, string input_name, int input_age) 
{
    cus_id=input_id;
    cus_name=input_name;
    cus_age=input_age;
}
public void ChangeID(int new_id) 
{
    cus_id = new_id;
}
public void PrintCusInfo()
{
    Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age: {cus_age}");
} 
public void CompareAge(Customer objCustomer)
{
    if (this.cus_age >= objCustomer.cus_age)
    {
        Console.WriteLine($"{this.cus_name} is older");
    }
    else
    {
        Console.WriteLine($"{objCustomer.cus_name} is older");
    }
} 
}