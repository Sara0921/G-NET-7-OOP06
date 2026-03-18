using System.ComponentModel;
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
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
