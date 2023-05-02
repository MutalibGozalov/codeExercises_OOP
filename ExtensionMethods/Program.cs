using System;
using ExtensionMethods.Models;
internal class Program
{
    private static void Main(string[] args)
    {
        // NOTE: Extension method must be defined in a non-generic static class
        string text = "m#uTA;lib& %Goz$A?LoV".ToLowerAndReplace();
        Console.WriteLine(text);
    }
}