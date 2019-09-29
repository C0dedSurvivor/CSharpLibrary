using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is a single-line comment. Useful for making short comments and descriptions

/*
 * This is a multi-line comment. Useful for longer definitions
 * Also good for if you want to split up the sentences
 */

/// <summary>
/// This is an XML comment. It is created by typing ///
/// on the line above a function, variable, class, or a whole lot more.
/// It allows you to describe what the function does, its params, and its return type
/// 
/// A namespace groups a set of definitions together. 
/// It makes sure there's no problems if two libraries have definitions with the same name.
/// By default it will have the same name as your project.
/// </summary>
namespace Library
{
    class Program
    {
        //This is explained and used later
        delegate int MyDelegate(int one, int two);

        /// <summary>
        /// Main is the entrypoint of your program. It is the first method that is run when the program is launched
        /// The end of this function is also the end of your program
        /// </summary>
        /// <param name="args">Used for command-line arguments. Just ignore it in a normal program.</param>
        static void Main(string[] args)
        {
            Console.Write("This is how you write words to the console. ");
            Console.Write("If you want a new line, add \n");
            Console.WriteLine("Or use this instead.");
            Console.WriteLine("Forward-slash is called an escape character. It allows you to print characters that would normally do other things when in a string.");
            Console.WriteLine("For example, \\ prints a forward slash. \" prints a quotation mark, which normally marks the end of the string. If you put \n it puts a newline character.");

            /*
             * VARIABLES: PRIMITIVE TYPES
             */

            //This is an integer variable, also called an Int32 or just int. It stores a whole number with a max value of 2,147,483,647 and a min value of -2,147,483,647.
            //int.MaxValue = the highest value an int can store
            int aInt = int.MaxValue;
            //You can change the value of a variable as much as you want
            aInt = 5;

            //This is a short variable, also called an Int16. It stores a whole number with a max value of 32,767 and a min value of -32,767.
            short aShort = 5;
            //This is a long variable, also called an Int64. It stores a whole number with a max value of 32,767 and a min value of -32,767.
            long aLong = 5;
            //Appending u to the variable makes it unsigned, meaning it can no longer store negative numbers but its positive max value is doubled.
            uint aUInt = 500;
            ushort aUShort = 500;
            ulong aULong = 500;
            //That is a character, it stores a single character denoted by single quotes.
            char aChar = 'a';
            //This is a string. It stores a line of characters.
            string aString = "A string's beginning and end is denoted by quotation marks.";
            //This is a decimal. It can store decimal values with a max of 7.9228 x 10^28 and a min of -7.9228 x 10^28.
            //It is denoted by an m or M and is the most precise for storing decimal values.
            decimal aDecimal = 2.34m;
            //This is a float, also called a single. It can store decimal values with a max of 3.402823E+38 and a min of -3.402823E+38.
            //It is denoted by an f and IS NOT ALWAYS PRECISE.
            float aFloat = 2.34f;
            //This is a double. It can store decimal values with a max value of 1.79769313486232E+308 and a min of -1.79769313486232E+308.
            //It is more precise than a float.
            double aDouble = 2.34;
            //This is a bool, also called a boolean. It stores a true/false value.
            bool aBool = true;
            //Putting const in front of a variable declaration makes it so the value can never be changed after it is first created.
            const float pi = 3.1415f;

            //Putting a ? after a primitive type makes it nullable, meaning it can store a normal value for that type or null
            bool? aNullableBool = null;
            //Use .Value to extract the value or .HasValue to see if it is null or not
            if (aNullableBool.HasValue)
            {
                bool truthyValue = aNullableBool.Value;
            }

            //To convert between different variable types, put the variable type you want in parenthesis next to the value you have
            aDouble = (double)aInt;
            //Some variable types aren't able to be converted between each other or will only work properly in certain circumstances
            //The following conversion between int and bool is an example of an invalid cast: aBool = (bool)aInt;
            //Others have functions that need to be used instead, like this one for string to int
            aInt = int.Parse("42");

            /*
             * MATH
             */

            //There are 5 basic math operators in C#:
            // a + b for addition, a - b for subtraction, a * b for multiplication, 
            // a / b for division, and a % b for modulo (the remainder of a / b)
            Console.WriteLine("Addition: " + (5 + 2) + " Subtraction: " + (5 - 2) + " Multiplication: " + (5 * 2) 
                + " Division: " + (5 / 2) + "Modulo: " + (5 % 2));
            //Division between two integers will result in an integer, meaning the decimal places will be chopped off.
            //To get around this, convert one (traditionally the bottom) into a float or double.
            //For more advanced math functions you can use the math class.
            //It also has mathematical constant like pi and e.
            Console.WriteLine("Power: " + Math.Pow(6, 3) + " Square root: " + Math.Sqrt(9) + " Sin: " + Math.Sin(Math.PI));

            /*
             * USER INPUT
             */

            //This gets a string value from the user through the console.
            //It waits until the user presses the enter key and gets everything they typed in until then.
            string userInput = Console.ReadLine();

            /*
             * VARIABLES: Arrays
             */

            //An array can be made with any variable or class type by appending [].
            //You must declare the length of the array when you assign a new array.
            int[] intArray = new int[8];
            //To assign the value of a slot in the array, append [x] to the name of the array where x is the index you want.
            //Arrays start their index cout at 0, meaning 0 is the first value, 1 is the second, etc.
            intArray[3] = 6;
            //You can also declare all of the values in an array at once like this:
            intArray = new int[] { 4, 5, 200, -15, 4 }; //Note you do not need to declare the size of the array with this as it is automatically set to the amount of values you give.
            //If you try to access a spot that is outside the size of the array it will break.

            /*
             * COMPARATORS
             */

            //To compare objects, you use an if statement.
            /* Ways to compare values: Returns a boolean value representing the result
             * == is the equals operator, true if the objects to either side of it are equivalent.
             * != is the not equals operator, true if the objects to either side of it are not equivalent.
             * > is the greater than operator, true if the object on the left is greater than the object on the right
             * >= is the greater than or equal to operator, true if the object on the left is greater than or equal to the object on the right
             * < is the less than operator, true if the object on the left is less than the object on the right
             * <=is the less than or equal to operator, true if the object on the left is less than or equal to the object on the right
             * 
             * Boolean algebra: Ways to modify or combine results.
             * ! is the not operator, flipping the result of a comparison.
             * && is the and operator, is only true if the comparisons on both sides of it result to true.
             * || is the or operator, is true if at least one of the comparisons next to it are true.
             */
            //If one of these blocks evaluates to true, it will ignore all other blocks in this chain
            if (aUInt > aInt)
            {
                //You can attach a variable value to a string with a + to append it to the string.
                Console.WriteLine("aUInt is the greater value with a value of " + aUInt);
            }
            //If the previous condition is false, it will check this one.
            //You can stack as many as you want under one another and they will be checked in order.
            else if(aUInt < aInt)
            {
                Console.WriteLine("aInt is the greater value with a value of " + aInt);
            }
            //If all previous checks are false, it defaults to this
            else
            {
                Console.WriteLine("aInt and aUInt are equal with a value of " + aInt);
            }

            //A switch block is used to check if a single variable is equal to a set of other values.
            switch (aInt)
            {
                //This is equivalent to if(aInt == 5)
                case 5:
                    Console.WriteLine("aInt = 5");
                    //This marks the end of the case, and ends the switch statement
                    break;
                //This is equivalent to else if(aInt == 25 || aInt == 30)
                case 25:
                case 30:
                    Console.WriteLine("aInt = 25 OR aInt = 30");
                    break;
                //This is equivalent to else, only run if no other case is true. Should always be the last case.
                default:
                    Console.WriteLine("aInt != 5 && aInt != 25 && aInt != 30");
                    break;
            }

            /*
             * LOOPS
             */

            //The increment and decrement operators change the value of a number-storing variable by one
            Console.WriteLine("aInt = " + aInt + ". Due to the immediate increment operator, aInt now = " + ++aInt + ". Due to the delayed increment operator, aInt still = " + aInt++ + " but will increment after this line finishes.");
            Console.WriteLine("Now aInt = " + aInt);

            /* A for loop repeats the code inside of it a set number of times. It is formed of four parts:
             * 1: The variable to be used to count the executions and what value it starts at. In this case "int i = 0;"
             *    This variable can be declared here or earlier in the code.
             * 2: The exit condition of this loop. The loop will stop looping when this is false. In this case "i < 5"
             * 3: How much to change the counter by each run of the loop. This can be any amount, positive or negative. In this case, "i++"
             *    i++ is an incrementer, meaning 1 will be added to i every time the line is called
             * 4: The code to be looped. This is the code inbetween the following curly braces. In this case, "Console.WriteLine("This code has run " + i + " times.");"
             */
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("This code has run " + i + " times.");
            }

            //As said, it can also count down.
            for(int aCounter = 5; aCounter > 0; aCounter--)
            {
                Console.WriteLine("Count = " + aCounter);
                //If an if statement has no curly braces, only the next runable line of code will be controlled by it. Comments do not count.
                if (aCounter == 6)
                    //A break statement will immediately exit the loop and stop it from running again.
                    //This works in all loop types.
                    break;
                if (aCounter > 2)
                    //Continue will immediately jump back to the top of the loop and start the next iteration as if this one had run to completion.
                    //This works in all loop types.
                    continue;
                Console.WriteLine("This entire iteration was run.");
            }

            //If you don't know how many times a loop should run, a while loop will run until a chosen condition is met.
            while (aInt > aShort)
            {
                aInt--;
                Console.WriteLine("aInt = " + aInt + ". aShort = " + aShort);
            }

            //A do-while loop is a while loop that will run the first time without checking if the condition is met.
            do
            {
                Console.WriteLine("Even though the condition is false, this will still run once");
            } while (aInt != aShort);

            //A foreach loop will run once for each value in a list-like variable
            //It will grab a reference to each value, so any edit to the grabbed value (in this case "i") will edit the value in the variable too
            Console.Write("The array = |");
            foreach(int i in intArray)
            {
                Console.Write(i + "|");
            }
            Console.Write("\n");

            /*
             * VARIABLES: INTERMEDIATE DATA STRUCTURES
             */

            //A list is like an array, but doesn't have a definite size. It can expand to fit the amount of items you try to fit in it.
            List<int> intList = new List<int>();
            //The same syntax can be used as with an array to add values at initialization
            intList = new List<int>() { 4, 5, 200, -15, 4 };
            //Similarly to arrays, the values are 0-indexed and can be accessed with [index]
            Console.WriteLine("The third value in the list is " + intList[2]);
            //Add a value to the end of the list with .Add(Value);
            intList.Add(7);
            //Add a value to a specific index with .Insert(index, value); Any values previously in the index or higher will be pushed over by one
            intList.Insert(4, 90);
            //Remove a known value with .Remove(Value);
            intList.Remove(5);
            //Remove an item at an index with .RemoveAt(index);
            intList.RemoveAt(0);
            //Check if a value is in the list with .Contains(Value);
            Console.WriteLine("intList contains 200: " + intList.Contains(200));

            //A queue is like a list but with some special restrictions. You can only insert to the back of the list and you can only pull from the front.
            //This is called FIFO (First in First out) and works like a checkout line at a grocery store.
            Queue<int> intQueue = new Queue<int>();
            //To add a value to the queue you use .Enqueue(Value);
            for (int i = 1; i < 6; i++)
            {
                intQueue.Enqueue(i);
            }
            //To look at the first value without removing it use .Peek();
            Console.WriteLine("The first value in intQueue is " + intQueue.Peek());
            //.Dequeue() returns the first value in the queue and removes it from the queue.
            Console.Write("In FIFO order, the values (formerly) in intQueue are: |");
            for (int i = 1; i < 6; i++)
            {
                Console.Write(intQueue.Dequeue() + "|");
            }
            Console.WriteLine();

            //A stack is like a list but with some special restrictions. You can only insert to the front of the list and you can only pull from the front.
            //This is called FILO (First in Last out) and works like a can of pringles.
            Stack<int> intStack = new Stack<int>();
            //To add a value to the stack you use .Push(Value);
            for (int i = 1; i < 6; i++)
            {
                intStack.Push(i);
            }
            //To look at the first value without removing it use .Peek();
            Console.WriteLine("The first value in intQueue is " + intStack.Peek());
            //.Pop() returns the first value in the stack and removes it from the stack.
            Console.Write("In FILO order, the values (formerly) in intStack are: |");
            for (int i = 1; i < 6; i++)
            {
                Console.Write(intStack.Pop() + "|");
            }
            Console.WriteLine();

            //A dictionary is like a list, but instead of storing a value at a specific index it stores it with a unique key.
            //It has the fastest lookup time of any data structure
            //This can be filled at initialization but the declaration looks slightly different.
            Dictionary<string, int> siDictionary = new Dictionary<string, int>() { { "Key1", 4 }, { "Key2", 5 }, { "OtherWord", 800 } };
            //To add a key-value pair to the dictionary, use .Add(key, value);
            //The dictionary will error if the given key already exists in the dictionary. There can be duplicate values, however.
            siDictionary.Add("New key", 0);
            //To get a value, it is the same syntax as an array or list but use the key instead of the index.
            Console.WriteLine("The value attached to the key Key2 is " + siDictionary["Key2"]);

            /*
             * FUNCTIONS
             */

            //This is a function call. It sends two ints, in this case 5 and 6, to the Add function.
            //It returns an int as a result, which is then stored in the variable added.
            //Right-click on Add, click "Peek Definition", and scroll up a little to learn more.
            int added = Add(5, 6);
            Console.WriteLine("5 + 6 = " + added);

            //This is a recursive function. It is a type of function that calls itself until a certain condition is met
            //Right-click on Factorial, click "Peek Definition", and scroll up a little to learn more.
            Console.WriteLine("!6 = " + Factorial(6));

            /*
             * ERROR HANDLING
             */

            //Try/catch/finally blocks will run all the code in the try block until it runs into an error.
            try
            {
                int i = 0;
                Console.WriteLine("AAAAHHHHH: " + (1 / i));
                Console.WriteLine("This line is never run.");
            }
            //If an error is encountered it will stop and go to the corresponding catch block.
            //An error will move execution to the first catch block with a matching error type
            //An error type of "Exception" will catch all other errors and acts like an else.
            //This will catch any error of type DivideByZero and put information relating to it into the variable "e".
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error encountered: " + e.Message);
            }
            //The finally block is run when either the try or catch blocks finish execution.
            //It is usually used to free resources allocated in the try and/or catch blocks.
            finally
            {
                Console.WriteLine("This code runs either way.");
            }
            

            /*
             * CLASSES
             */

            //Classes are a way to group data into what are called objects
            //They act as a template for creating usable objects
            //To learn more about classes and the specific class used here, open and look through the AClass.cs file then come back here
            //To be able to use a class you need to make an instance of that class, which is an object based off your class template
            //To do that you call "new" and then use one of the constructors for your class
            //Here we will use the default constructor
            AClass myClassInstance = new AClass();
            //Here are some examples of how to access the different parts of the class
            Console.WriteLine("Accessing my public variable directly = " + myClassInstance.myPublicVar + ". Using my private variable getter property = " + myClassInstance.MyPrivateVar);
            //This shows the difference between a static and non-static method call
            Console.WriteLine("Calling my class function = " + myClassInstance.OverridableFunction() + ". Calling the static function = " + AClass.GetInstanceCount());
            //Accessing the instance like an array uses the indexer property
            Console.WriteLine("Indexer property at index 3: " + myClassInstance[3]);

            /*
             * CLASSES: INHERITANCE
             */

            //Inheritance is a concept in object oriented programming that allows a class to "inherit" the functionality of another class.
            //Derived classes are classes that also have all the functionality of other classes and/or interfaces.
            //To learn more about derived classes and the specific class used here, open and look through the ADerivedClass.cs file then come back here.
            //Here we will use our parameterized constructor.
            ADerivedClass myDerivedInstance = new ADerivedClass(4);
            //It has the same parts to it as its base class.
            Console.WriteLine("Accessing my public variable directly = " + myDerivedInstance.myPublicVar + ". Using my private variable getter property = " + myDerivedInstance.MyPrivateVar);
            //It also contains all the functionality required by the interface.
            Console.WriteLine("Accessing interface getter property = " + myDerivedInstance.MyPrivateVar + ". Calling the interface method = " + myDerivedInstance.HiddenTotal());
            //An overridden method will run as defined in the derived class instead of the base class.
            Console.WriteLine("Base class method = " + myClassInstance.OverridableFunction() + ", Derived class version = " + myDerivedInstance.OverridableFunction());

            //One of the uses of inheritance is that a derived class can be represented as its base.
            //For example, you can store the instances of both a class and its derived class in an array of the base class.
            AClass[] myClassList = new AClass[]{ myClassInstance, myDerivedInstance };
            //While like this myDerivedInstance is treated as an instance of AClass, meaning you can't use any ADerivedClass-only functionality.
            //However, you can use any AClass functionality, and any overridden functionality will still use the derived class version.
            Console.WriteLine("Base class: " + myClassList[0].myPublicVar + " Derived class: " + myClassList[1].myPublicVar);
            Console.WriteLine("Base class function: " + myClassList[0].OverridableFunction()
                + " Derived class function: " + myClassList[1].OverridableFunction());
            //If you want to use ADerivedClass-only functionality on the derived class instances you need to use a cast
            foreach(AClass obj in myClassList)
            {
                //"a is b" checks if a is an instance of type b
                if (obj is ADerivedClass)
                {
                    //"a as b" is another way to "cast" or read one object as a different type of object
                    //Now we can use ADerivedClass functionality
                    ADerivedClass myTrueInstance = (obj as ADerivedClass);
                    //Because of how casting works with classes, any changes to the casted version will affect the uncasted instance as well
                    myTrueInstance.HiddenTotal();
                }
            }

            /*
             * ENUMS
             */

            //Enums are a variable type that stores one of a set selection of values.
            //To learn more about enums, look at the AnEnum.cs file then come back here.

            //To get an enum's option use MyEnumName.MyOptionName.
            MyEnum myEnum = MyEnum.First;
            //You can also cast an enum option to an int or an int to an option.
            Console.WriteLine("Enum to int: " + (int)Errors.NotFound + " Int to enum: " + (Errors)200);

            /*
             * STRUCTS
             */

            //Structs are similar to classes as in they can store data and have functionality, albeit with key differences.
            //To learn more about structs, look at the AStruct.cs file then come back here.

            //The syntax for structs are the exact same as that for classes
            AStruct myStructInstance = new AStruct(1, 2, 3);
            myStructInstance.Print();
            myStructInstance.Move(2, 5, 50);
            myStructInstance.Print();

            /*
             * CLASSES: ABSTRACT
             */

            //Abstract classes are templates for classes that can be inherited by other classes but not instanced on their own similarly to interfaces.
            //To learn more about abstract classes and how they're different from interfaces, look at the AnAbstractClass.cs file then come back here.

            //The syntax to inherit, override, and use an abstract class are the same as other classes so go back to that section for examples.

            /*
             * COMPARATORS: TERNARY
             */

            //A ternary statement is an inline if statement, written like this: a ? b : c
            //It is read "If a, return b. Else, return c."
            //It is useful for conditionally setting a value, such as "int a = ((5 > 4) ? 5 : 4);"
            //Note: Both returns of a ternary have to have the same tye, I.E. both ints or both strings.
            Console.WriteLine("Testing a conditional: " + (5 > 4 ? "5 is greater than 4" : "4 is greater than 5"));

            /*
             * FILES: TEXT
             */

            //TO USE FILE IO, PUT "using System.IO;" AT THE TOP OF YOUR FILE.

            //To edit text files, use a StreamWriter object.
            //The string given is the relative pathname to get to the file you want to edit.
            //Using statements will automatically deal with disposing the object in its constructor when done.
            //By putting it in a using statement it will automatically close to file when done.
            //If outside a using block "output.Close();" needs to be called when done.
            //Note: Opening a file for reading immediately clears the file. Use caution.
            using (StreamWriter output = new StreamWriter("MyFolder/MyTextFile.txt")) {
                //This writes the string to the file followed by a line break (enter key).
                output.WriteLine("This is my file, welcome!");
            }

            //To read in from a text file, use a StreamReader object.
            //Same as editting, it needs a path to go to and to be closed if not in a using statement.
            //This will error if it tries to open a file that doesn't exist.
            using(StreamReader input = new StreamReader("MyFolder/MyTextFile.txt"))
            {
                string myLine = input.ReadLine();
            }

            /*
             * FILE: BINARY
             */

            //Binary files have a few benefits over text files.
            //1: They are generally smaller than text files.
            //2: You don't need to cast from a string for every other variable type.
            //However, it is unreadable without a program made to read it.

            //To write to a binary file is similar to a text file with one extra step.
            //Instead of directly passing in a string path you need to create a Stream object using File.OpenRead(path).
            //You then use that to make a BinaryWriter.
            //Any extension will work, however if using a common extension make sure it is readable as that file type.
            //For a generic file type use .data.
            //Note: Opening a file for reading immediately clears the file. Use caution.
            using (BinaryWriter writer = new BinaryWriter(File.OpenRead("MyFolder/MyBinaryFile.data")))
            {
                //The Write function writes the given data to the binary file.
                writer.Write(1.250F);
                writer.Write("Temp");
                writer.Write(10);
                writer.Write(true);
            }

            //To read from a binary file uses a similar format, just with BinaryReader instead of BinaryWriter.
            using(BinaryReader reader = new BinaryReader(File.OpenWrite("MyFolder/MyBinaryFile.data")))
            {
                //Unlike text files however, reading from the file requires the types and order of the data that are in the file.
                //Floats are called singles in this set of functions.
                float myReadFloat = reader.ReadSingle();
                string myReadString = reader.ReadString();
                //Int16 is a short, Int32 is an int, Int64 is a long
                int myReadInt = reader.ReadInt32();
                bool myReadBool = reader.ReadBoolean();
            }

            /*
             * DELEGATES
             */

            //Delegates are a variable type that stores function calls to use later.
            //If the delegate stores a function from a class instance it will be called on that specific instance.
            //To make a delegate first declare the delegate type you need.
            //Delegates are declared outside of a function. The one we will use is declared above the Main function.
            //In this example, the function returns an int and takes int two ints.
            //To create an instance of your delegate type, use your delegate type as you would any other variable.
            //To assign a function to the delegate, use the function name with no parentheses.
            MyDelegate myDelegateInstance = Add;

            //To use your delegate, call it like you would the function.
            Console.WriteLine("Calling my delegate: " + myDelegateInstance(2, 3));

            //CONGRATS! You've reached the end. You're more than ready to make your own program and start working.
            //For some general rules to follow as to how to name things and set up your program, read "C# Conventions.txt".
            //Good luck and happy coding!
        }

        /// <summary>
        /// This is an example function
        /// Static says that this function is attached to the class itself instead of an instance of that class. This will make more sense when you learn about classes.
        /// int specifies what kind of value this function passes back to where it was called. If it is void it means no value is returned.
        /// The two variables inside of the parenthesis say what kinds of values need to be passed in for this function to work, called the arguments or parameters of the function.
        /// The " = 2" next to "two" says that you don't need to pass anything in for that value, and if you don't "two" will be set to 2. This is called two's default value.
        /// If your argument is a primitive type it will be passed by value, meaning anything done to the value here won't affect the original variable
        /// If not it is called pass by reference and the original copy will be changed.
        /// This can be called anywhere in this file with Add(int, int) where each int is an integer value or variable.
        /// </summary>
        /// <param name="one">The first number</param>
        /// <param name="two">The second number</param>
        /// <returns>The sum of the two numbers</returns>
        static int Add(int one, int two = 2)
        {
            //Return ends the function and passes the following value back to where the function was called
            return one + two;
        }

        /// <summary>
        /// This is called a recursive function. It is a function that calls inself until a certain condition is met.
        /// </summary>
        /// <param name="num">The number to calculate the factorial of</param>
        /// <returns>The factorial of a number (Itself multiplied by every number between it and 1)</returns>
        static int Factorial(int num)
        {
            if (num == 1)
                //This is called the base case. It is when the function stops calling itself and returns something else.
                return 1;
            else
                //This is called the recursive case. It is when the function calls itself.
                return num * Factorial(num - 1);
        }
    }
}
