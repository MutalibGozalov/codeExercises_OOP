using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Struct.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Adi { get; set; }
        public DateTime BasimYili { get; set; }
        public string? YazarAdi { get; set; }
        public int SayfaAdet { get; set; }
        public string ISBNNo { get; set; } = null!;
        public string YayinEvi { get; set; } = null!;
    }

    public class Kitap // : Book --> can not derive from sealed type 'Book'
    {
        public readonly string? Name;
    }

    public struct BaseModel // Struct type can net be declared with static keyword
    {                       // but can has a static member !
        public static int Id { get; set; }
        public readonly string YazarAdi; //Inteesting fact: Readonly fields of Structs' is not actually readonly, tho they can be assigned to value.
        public const string YayinEvi = "EON Publish";

        public string? Adi { get; set; }
        public DateTime BasimYili { get; set; }

        public int SayfaAdet { get; set; }
        public string ISBNNo { get; set; }
    }

    public interface IMyInterface{}

    // Struct type !can! implement an interface
    public struct Book : IMyInterface   // : BaseEntity --> ERROR: Type 'BaseEntity' in interface list is not an interface
    {                                   // : BaseModel ----^, -> can not inherit from a class
        public int Id { get; set; }
        public string Adi { get; set; }
        public DateTime BasimYili { get; set; }
        public string YazarAdi { get; set; }
        public int SayfaAdet { get; set; }
        public string ISBNNo { get; set; }
        public string YayinEvi { get; set; }
    }
}