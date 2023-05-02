using Struct.Models;
internal partial class Program
{
    //Book book = new(); Main() method doesn't see this instance !!
    private static void Main(string[] args)
    {
        //NOTE: Struct type can not inherit from class and cannot be inherited by a class.
        // Struct type can implement an interface
        Book book = new();
        book.Adi = "Harry Potter";
        Console.WriteLine(book.Adi);

        // Struct type cannet be declared with static keyword
        // but can has a static member !
        BaseModel.Id = 10;
        book.YazarAdi = "J.K.Rowling";
        book.YazarAdi = "J.K.Rowlingeeee"; //Even this field is readonly we can assign value to it :)
        Console.WriteLine("Static Id of BaseModel struct: {0}\nReadonly YazarAdi: {1}\nconst YayinEvi: {2}", BaseModel.Id, book.YazarAdi, BaseModel.YayinEvi);
    }
}