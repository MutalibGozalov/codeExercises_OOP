namespace SeperateModels;

public class Employee //: Person
{
  
    public Employee(int _salary) //: base("name from employee")
    {
        this.SalaryOfHour = 12;
    }


    public int SalaryOfHour { get; set; }
    public int WorkingHour { get; set; }

}

