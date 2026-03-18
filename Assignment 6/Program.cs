using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_6
{
    #region Part01
    #region Question01
    //Abstraction vs Encapsulation
    //Abstraction is about hiding complexity — you show only what's necessary and hide the implementation details. It answers: "What does it do?"
    //Encapsulation is about bundling and protecting data — you wrap data and methods together and restrict direct access.It answers: "How is it protected?"
    //Example: A Coffee Machine
    //Abstraction:
    //Encapsulation:
    //The water tank level, internal temperature, and bean count are stored privately inside the machine.You can't directly change them — you interact only through buttons, and the machine controls its own state.
    #endregion
    #region Question02
    //4 Key Differences
    //                    Abstract Class                          | Interface
    //Methods     | Can have both complete and incomplete methods | All methods are incomplete(no body)
    //Variables   | Can have instance variables                   |Only constants(final static)
    //Inheritance |A class can extend only one                    |A class can implement multiple
    //Constructor |✅ Can have a constructor                      |❌ Cannot
    #endregion
    #region Question03
    //A) No. Appliance is an abstract class — you cannot instantiate it directly.
    //B)PowerConsumption()>>abstract>>Every appliance consumes different power — there's no sensible default. Each subclass must provide its own value.
    //Status()>>virtual>>Most appliances start on "Standby" — a reasonable default. But subclasses can override it if needed.
    //Label()>>concrete>>The format "Brand - XW" is the same for all appliances.t reuses the other methods internally.
    //C) what will it return? >> Standby
    //Because Toaster does not override Status(), so it falls back to the parent's virtual implementation which returns "Standby".
    #endregion
    #region Question04
    //A)Partial Class >> A partial class splits one class across multiple files using the partial keyword — at compile time, they're merged into one single class.
    // Organize large classes , Team collaboration , Enable code generation , Protect manual code
    //B) partial method is declared in one part of a partial class and optionally implemented in another part.
    //Yes, it still compiles.
    //Because If a partial method has no implementation, the compiler silently removes all calls to it as if they never existed. No error, no crash.
    //C)Extension Methods >> An extension method lets you add new methods to an existing type without modifying its source code, without inheritance, and without recompiling.
    //Three rules:
    //1.Must be in a static class
    //2.The method itself must be static
    //3.First parameter must use this followed by the type being extended
    //D)$20.00 


    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
