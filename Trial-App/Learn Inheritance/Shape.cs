using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial_App
{
    public class Shape
    {
        // A few example members
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // Virtual method which can be edited in other child class
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }

}

/* Polymorphism is a Greek word that means "many-shaped" and it has two distinct aspects:

-   At run time, objects of a derived class may be treated as objects of a base class 
    in places such as method parameters and collections or arrays. 
    When this polymorphism occurs, the object's declared type is no longer identical to its run-time type.

-   Base classes may define and implement virtual methods, 
    and derived classes can override them, 
    which means they provide their own definition and implementation. 
    At run-time, when client code calls the method, the CLR looks up the run-time type of the object, 
    and invokes that override of the virtual method. 
    In your source code you can call a method on a base class, and cause a derived class's version of the method to be executed.

    Fields can't be virtual; only methods, properties, events, and indexers can be virtual.

    DerivedClass B = new DerivedClass();
    B.DoWork();  // Calls the new method.

    BaseClass A = B;
    A.DoWork();  // Also calls the new method.


    public class BaseClass
    {
        public virtual void DoWork() { }
        public virtual int WorkProperty
        {
            get { return 0; }
        }
    }
    public class DerivedClass : BaseClass
    {
        public override void DoWork() { }
        public override int WorkProperty
        {
            get { return 0; }
        }
    }
*/