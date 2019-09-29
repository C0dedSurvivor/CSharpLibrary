using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// An enum is a type of variable with a defined set of values it can hold.
    /// Enums are not normally in their own file, however these are removed for readability
    /// Each selection is also mapped to an int starting at 0.
    /// EX: First = 0, Second = 1, etc.
    /// </summary>
    enum MyEnum
    {
        //To define options write the names separated by a comma.
        First,
        Second,
        Third,
        Fourth
    }

    /// <summary>
    /// You can also define what each value maps to.
    /// A defaultly defined option will just equal the previous option + 1.
    /// EX: SomethingsReallyBroken = 405.
    /// </summary>
    enum Errors
    {
        OK = 200,
        Redirect = 302,
        NotFound = 404,
        SomethingsReallyBroken
    }
}
