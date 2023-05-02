namespace Models;

public class Person
{
    // public Person() { }
    public Person(string _name) 
    { 
        this.Name = _name;
    }
    public Person(string name,string surname) : this(name)
    {
        this.SurName = surname;
    }

    //Test constructor
    public Person(bool a, bool b, bool c) : this("bool", "boolly")
    {
        
    }
    //Test

    public virtual void SayMyName(){
        System.Console.WriteLine("I'm a Person");
    }

    public Person(string name,string surname, byte age) : this(name)
    {
        this.SurName = surname;
        this.Age = age;
    }

    public string Name { get; set; } = null!;
    public string SurName { get; set; } = null!;
    public byte Age { get; set; }
}

public class Employee : Person
{
    /* public Employee(){ } 
        
            When instanciate an object from inheriting class the properties thats inherited will be set at base(inherited) class.
        By default it will use base calsses default constructor with no parameters if we don't say it explicitly
        by writing base(params).
    */
    public Employee(int _salary) :  base("Name from employee", "Surname from employee")
    {
        base.Name = "name";
        base.SurName = "surname";
        base.Age = 5;
        this.SalaryOfHour = _salary;
    }


    public int SalaryOfHour { get; set; }
    public int WorkingHour { get; set; }

    public override void SayMyName()
    {
        //base.SayMyName();
        System.Console.WriteLine("I'm an Employee");
    }

}


public class Student : Person
{   
    public Student() : base("Name from Student", "Surname from Student")
    {
        
    }  

    public Student(int iqRank) : this()
    {
        this.IQRank = iqRank;
    }

    public Student(int iqRank, int languageRank) : this(iqRank)
    {
        this.LanguageRank = languageRank;
    }

    public int IQRank { get; set; }

    public int LanguageRank { get; set; }

    public override void SayMyName()
    {
        //base.SayMyName();
        System.Console.WriteLine("I'm a Student");
    }
}