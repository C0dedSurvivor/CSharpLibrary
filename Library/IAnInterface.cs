using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// An interface is a template for other classes
    /// It contains a list of properties, functions, and indexers that any class inheriting from this must implement
    /// Unlike a class, it cannot be instantiated, it cannot inherit a class, and it has no functionality itself
    /// Everything declared in an interface must be public
    /// By convention, interface names begin with a capital I
    /// </summary>
    public interface IAnInterface
    {
        /// <summary>
        /// This is an example of an interface property
        /// Use "get;" to force the implementation to have a getter property, and "set;" for a setter
        /// </summary>
        int MyProtectedVar
        {
            get;
        }

        /// <summary>
        /// This is an interface function definition
        /// Any class that inherits from this must have a function named HiddenTotal that takes no arguments and returns an int.
        /// </summary>
        int HiddenTotal();
    }
}
