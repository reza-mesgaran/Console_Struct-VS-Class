using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Struct_VS_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();   

            MyStruct myStruct;    // Create an object from struct (1st method)

            MyStruct myStruct1 = new MyStruct(12);    //Create an object from struct  (2th method - use constructor)

            // **** Note : -new- keyword is used while use parameterized constructors


        }
    }


    //------------------ Struct (Value Type - Stack - Can't be Static (But can have Static member) 
     struct MyStruct :IMyInterface, IMyInterface2    // Struct	Can inherit multiple interfaces
    {
        int myField;
        public int myProperty { get; set; }

        static int myStaticField;

        void myMethod()
        {

        }

        // MyStruct() {   }      ERROR :  Struct'Default Constructor

        public MyStruct(int m)    // Struct'Parametrized Constructor
        {
            this.myProperty = m;
            this.myField = m;
        }

    }
    //------------------ Class (Reference Type - Heap - 
    public class MyClass : IMyInterface, IMyInterface2    // Class 	Can inherit multiple interfaces
    {
        int MyField;
        public int MyProperty { get; set; }  

        static int MyStaticField;

        void MyMethod()
        {

        }

        public MyClass()        // Class'Default Constructor
        {

        }

        public MyClass(int m)  // Class'Parametrized Constructor
        {
            this.MyField = m;
            this.MyProperty = m;
        }

    }

     interface IMyInterface
    {

    }
     interface IMyInterface2
    {
    }

    //struct MyStruct2: MyStruct  { }   ERROR : NO , inheritance for struct

    // abstract struct  MyStruct3 { }  ERROR : A struct can't be abstract


}
