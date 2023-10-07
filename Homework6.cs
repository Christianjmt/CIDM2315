namespace HW6Q1;

class Program
{
    static void Main(string[] args)
    {
        Professor professor1 = new Professor();
        professor1.profName = "Alice";
        professor1.classTeach = "Java";
        professor1.SetSalary(9000);

        Professor professor2 = new Professor();
        professor2.profName = "Bob";
        professor2.classTeach = "Math";
        professor2.SetSalary(8000);

        Student student1 = new Student();
        student1.studentName = "Lisa";
        student1.classEnroll="java";
        student1.setGrade(90);

        Student student2 = new Student();
        student2.studentName = "Tom";
        student2.classEnroll="Math";
        student2.setGrade(80);
        
        professor1.printprofinfo();
        professor2.printprofinfo();

        student1.printstuinfo();
        student2.printstuinfo();

        Console.WriteLine($"The salary difference between {professor1.profName} and {professor2.profName} is: "+ (professor1.GetSalary()-professor2.GetSalary()));
        Console.WriteLine($"The total grade of {student1.studentName} and {student2.studentName} is: "+ (student1.getGrade()+student2.getGrade()));
    }
     
}
class Professor 
{
    public string profName;
    public string classTeach;
    private double salary;

    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }
    public double GetSalary()
    {
        return salary; 
    }
    public void printprofinfo()
    {
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: "+ GetSalary());
    }
}
class Student
{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public void setGrade(double newGrade)
    {
        studentGrade = newGrade;
    }
    public double getGrade()
    {
        return studentGrade;
    }
    public void printstuinfo()
    {
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is: "+ getGrade());
    }
}