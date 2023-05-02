using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed.Models
{
    public sealed class SealedClass
    {
        
    }

    public class BaseClass // :SealedClass --> Sealed classes can not be inherited from
    {
        public int Id { get; set; }

        public virtual void MyFunction()
        {
            Console.WriteLine("MyFuntion() in BaseClass");
        }   // Sealed methods cannot be overridden by inheriting(child) class
    }

    public class ChildClass : BaseClass
    {
        public sealed override void MyFunction() // Once a virtual method has sealed, the GrandChild class below 
        {                                        // will not be able to override it.
            Console.WriteLine("MyFuntion() in ChildClass");
        }
    }

    public class GrandChild : ChildClass
    {
        // public override MyFunction --> Can not override sealed method 
    }
}