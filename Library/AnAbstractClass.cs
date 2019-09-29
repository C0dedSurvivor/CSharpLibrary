using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// An abstract class is similar to an interface but with a few key differences
    /// 1: Since an abstract class is still a class, another class cannot inherit multiple of them
    /// 2: An abstract class can inherit from other classes and interfaces
    /// 3: Variables, functions, etc. in an abstract class can be protected or private, not just public
    /// 4: An abstract class' functions can be implemented in the abstract class instead of just defined
    /// 
    /// Similarly to an interface, an instance of an abstract class cannot be made
    /// </summary>
    abstract class AnAbstractClass
    {
        protected string myProtectedVar = "5";

        public int MyProtectedVar
        {
            get
            {
                return int.Parse(myProtectedVar);
            }
        }

        public AnAbstractClass(string myValue)
        {
            myProtectedVar = myValue;
        }

        public virtual void Print()
        {
            Console.WriteLine(MyProtectedVar);
        }
    }
}
