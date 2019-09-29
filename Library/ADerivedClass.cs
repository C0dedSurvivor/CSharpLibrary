using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// ADerivedClass is what is known as a derived class, meaning it inherits some of its functionality from another class
    /// In this example, AClass would be called ADerivedClass' parent or base class and ADerivedClass would be called a child of AClass
    /// Each class can only derive/inherit from one other class, however you can derive from as many interfaces as you'd like
    /// This class relies on AClass.cs and IAnInterface.cs, it is suggested to read those first and come back
    /// </summary>
    class ADerivedClass : AClass, IAnInterface
    {
        /// <summary>
        /// This property was originally declared in IAnInterface and defined here
        /// </summary>
        public int MyProtectedVar
        {
            get
            {
                return myProtectedVar;
            }
        }

        /// <summary>
        /// When constructing a derived class you append the keyword base followed by any contructor arguments
        /// This uses AClass' parameterized constructor
        /// </summary>
        public ADerivedClass(int parentValue) : base(parentValue){
            
        }

        /// <summary>
        /// This method was originally declared in IAnInterface and defined here
        /// </summary>
        public int HiddenTotal()
        {
            return myProtectedVar + myPublicVar + 5;
        }

        /// <summary>
        /// To override a virtual method from a base class use the override keyword
        /// To use the version of the function from the base class use base.FunctionName()
        /// </summary>
        public override int OverridableFunction()
        {
            return base.OverridableFunction() + 5;
        }

        /// <summary>
        /// There are also some common functions between all objects that can be overridden
        /// ToString determines how the program translates this object into a string
        /// </summary>
        /// <returns>This object as represented by a string</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
