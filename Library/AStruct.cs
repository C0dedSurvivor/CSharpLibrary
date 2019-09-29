using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Structs are similar to classes, with a few key differences.
    /// 1: Structs can only inherit interfaces, not classes.
    /// 2: Structs cannot be inherited.
    /// 3: Structs cannot have a parameterless constuctor.
    /// 4: Struct constructors require that all fields in a struct be given values.
    /// 5: Structs and classes are stored in different areas of memory. (Beyond the scope of this project)
    /// 
    /// Semantically, classes represent objects whereas structs represent a set of data.
    /// For example, a car would be a class but position would be a struct.
    /// </summary>
    struct AStruct
    {
        int x;
        int y;
        int z;

        public AStruct(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Move(int x, int y, int z)
        {
            this.x += x;
            this.y += y;
            this.z += z;
        }

        public void Print()
        {
            Console.WriteLine("My position: (" + x + ", " + y + ", " + z + ")");
        }
    }
}
