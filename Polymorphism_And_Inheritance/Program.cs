using System.Security.Cryptography;
using Models;
internal partial class Program
{
    private static void Main(string[] args)
    {
      Person p1 = new(true, true, false);
      Console.WriteLine("{0}\n{1}\n{2}", p1.Name, p1.SurName, p1.Age);

      Employee e1 = new(12);
      Console.WriteLine("EMPLOYEE: \nName: {0}\nSurname: {1}\nAge: {2}\nSalaryof hour: {3}", e1.Name, e1.SurName, e1.Age, e1.SalaryOfHour);

      Student s1 = new(70, 90);
      Console.WriteLine("\nSTUDENT: \nName: {0}\nSurname: {1}\nAge: {2}\nIQ: {3}", s1.Name, s1.SurName, s1.Age, s1.IQRank);

//-----Polymorphism, method overriding----------

      Person person = new("");
      person.SayMyName();

      e1.SayMyName();
      s1.SayMyName();
      
      Console.ReadLine();
    }
}
/*

Class Constructors Call Stack
When we instanciate an object from a class 1st the constructor method
thats used after new keyword will be called, if this constructor
calls any of itself's overloads (Contructor(int a, string b) : this(int a))
then current construcor will wait for that overload to finis, and if that
overloads' itself calls another overload then it will wait too and so on.
This process will create call stack of constructor methods, if a method
that's not calling another overload is called it will run and after finised
this last one on stack will be deleted, and next one will be start to executing.
When they're all finish executing the first method on stack thats called first
when we instanciate an object will end up creation of object.
  In case if the class we're trying to create an instance of is inheriting
another parent class then the after we calling the last constructor on the stack
instead of start executing this methos it will call the constructor methos of base
or inherited class, so stack will contuniue adding up at parent class just like it
was in current child class. 

*/