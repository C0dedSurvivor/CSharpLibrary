using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// This is a class.
    /// A class is a custom data structure that can have its own variables and functions.
    /// Just like other data structures, you make a single copy of this, called an instance, by using one of the class' constructors
    /// </summary>
    class AClass
    {
        // There are many different ways to store data in a class

        //Static values only have one copy shared between all instances of a class
        //These are accessed by using AClass.myStaticVar where AClass is
        //the name of the class instead of the name of your instance
        //This variable has a default value of 0, meaning its starting value when first created is 0
        static int amountOfInstances = 0;

        //Variables and functions inside a class can have different accessability levels
        //Private variables and functions can only be accessed within the class they are declared in.
        //This is the default accessability level of instance variables, but you can also use the private keyword
        private int myPrivateVar = 1;
        //Public variables and functions can be accessed from anywhere you have that class instance
        public int myPublicVar;
        //Protected variables and functions are a little different. They can be accessed within the class they are declared, but also
        //inside any class that derives/inherits from the class it is in. This will be explained more later
        protected int myProtectedVar;

        private int[] myIndexerArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        /// <summary>
        /// Alongside access modifiers, there are ways to "gate" the outside access to a variable without removing it entirely
        /// This is done with getters and setters
        /// You start by essentially declaring a new variable of the same type, but instead of a value you add something similar to the block below
        /// You do not need to have both a getter and setter
        /// </summary>
        public int MyPrivateVar{
            //This is the getter. This allows the value of the variable in question to be accessed
            //The return is what is passed back when the variable is called
            get
            {
                return myPrivateVar;
            }

            //This is the setter. It allows the value of the variable in question to be changed
            //The keyword "value" denote what the variable is being set to
            //I.E., for "MyPrivateVar = 5" value would equal 5
            set
            {
                myPrivateVar = value;
            }
        }

        /// <summary>
        /// This is an indexer property
        /// It is set up similarly to a normal property but allows the cass instance to be accessed like an array
        /// </summary>
        /// <param name="index">The integer in the square brackets during the call</param>
        public int this[int index]
        {
            get { return myIndexerArray[index]; }
            set { myIndexerArray[index] = value; }
        }

        /// <summary>
        /// This is called the default constructor. It takes no arguments, and is called when you use "new AClass()";
        /// The job of constructors is to set up default values for all of the data contained in the class and ready the instance for use
        /// </summary>
        public AClass()
        {
            amountOfInstances++;
            myPublicVar = 2;
            myProtectedVar = 3;
        }

        /// <summary>
        /// This is a destructor. It is called when an instance of this class is freed from memory (when it is no longer accessable)
        /// It is normally used to free other objects in the class so they don't take up memory
        /// </summary>
        ~AClass()
        {
            amountOfInstances--;
        }

        /// <summary>
        /// This is a parameterized constructor. It takes parameters similar to a function when used
        /// </summary>
        /// <param name="myPublicVar"></param>
        public AClass(int myPublicVar)
        {
            //Your parameters do not need to have the same name as the variable they will be assigned to
            //However, if they do use this.myVarName to reference the class variable and myVarName to reference the parameter
            this.myPublicVar = myPublicVar;

            amountOfInstances++;
        }

        /// <summary>
        /// Class instances can also have functions
        /// </summary>
        public int GetTrueValue()
        {
            return myPrivateVar + myProtectedVar + myPublicVar;
        }

        /// <summary>
        /// Class functions can also be static
        /// These are accessed by using AClass.MyStaticFunction()
        /// where AClass is the name of the class instead of the name of your instance
        /// </summary>
        public static int GetInstanceCount()
        {
            return amountOfInstances;
        }

        /// <summary>
        /// A virtual function is a type of function that can be overridden by a derived(child) class
        /// When called from an instance of AClass this function will run
        /// When called from an instance of a derived class, the version of the function in that class will run
        /// To learn more about inheritance, overriding, and derived classes go to the ADerivedClass.cs file
        /// </summary>
        /// <returns></returns>
        public virtual int OverridableFunction()
        {
            return 1;
        }
    }
}
