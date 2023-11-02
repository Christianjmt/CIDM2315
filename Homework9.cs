namespace HW9;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
       student stu1 = new student(inputid:111, inputname:"Alice");
       student stu2 = new student(inputid:222, inputname:"Bob");
       student stu3 = new student(inputid:333, inputname:"Cathy");
       student stu4 = new student(inputid:444, inputname:"David");

       Dictionary<string, double> studentinfo = new Dictionary<string, double>();
       studentinfo.Add("Alice", 4.0);
       studentinfo.Add("Bob", 3.6);
       studentinfo.Add("Cathy", 2.5);
       studentinfo.Add("David", 1.8);
       
       

       if(studentinfo.ContainsKey("Tom") == false)
       {  
        studentinfo.Add("Tom", 3.3);
       }

       Console.WriteLine("The average GPA is: " + studentinfo.Values.Average()); 
       
       foreach(var stu in studentinfo)
       {
        if(stu.Value > studentinfo.Values.Average())
        {
           foreach( var findstudent in student.studentlist)
           {
            if (stu.Key == findstudent.studentname)
            {
                findstudent.printinfo();
            }
           }
        }
        else
        {
            
            continue;
        }
       
       }
       
    }  
}
class student
{
    public static List<student> studentlist = new List<student>();
    public int studentid { get; set; }
    public string studentname { get; set; }
    public void printinfo()
    {
        Console.WriteLine($"Student ID: {studentid}, Student Name: {studentname}");
    }
    public student(int inputid, string inputname)
    {
        studentid = inputid;
        studentname = inputname;
        studentlist.Add(this);
    }

     
    
    
}