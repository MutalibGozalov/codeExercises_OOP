using Static.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        string SqlConenction = ConnectionHelpers.SqlConnection;
        string MongoConenction = ConnectionHelpers.MongoConnection;
        Console.WriteLine(SqlConenction + "\n" + MongoConenction);

       // ConnectionHelpers.ExcelConnection = "new value";
       // ERROR: A static readonly field cannot be assigned to (except in a static constructor or a variable initializer)
       string constField = ConnectionHelpers.constConnectionString;
       System.Console.WriteLine("Const(static+readonly) field: {0}", constField);
    }
}