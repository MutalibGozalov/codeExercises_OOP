using Sealed.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        BaseClass obj = new();
        BaseClass obj2 = new ChildClass(); //LSP
        BaseClass obj3 = new GrandChild(); //LSP
        obj.MyFunction();
        obj2.MyFunction();
        obj3.MyFunction(); //GrandChild inherits MyFunction() but can not override it.
    }
}