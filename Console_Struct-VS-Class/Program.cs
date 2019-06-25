using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Notes:
    
    Structs:
        1.Value Type 
        2.On Stack
        3.Can't inherit from class/struct BUt can inherit from multiple interfaces 
        4.Has only parameterized constructor (not defualt constructor)
        5.Make instance of struct with/without new-Keyword
            a.without new-keyword : constructor won't run
            b.with new-keyword : parameterized constructor will run
        6.Can't be Static (But can have Static member) 
        7.Can't be Abstract / Sealed
        8.Fileds can't initialized while define
        9.can have constants, fields, methods, properties, indexers, operators
        10.Can't be Null
        11.When a struct is assigned to a new variable, any modification to the new copy does not change the data for the original copy. 
        =======
        Class:
        1.Reference Type 
        2.On Heap
        3.Can inherit from class/struct and multipe interfaces 
        4.Has both kind of constructor (default / parameterized)
        5.Make instance of struct only with new-Keyword
        6.Can be Static & can have Static member) 
        7.Can be Abstract / Sealed
        8.Fileds can initialized while define
        9.can have constants, fields, methods, properties, indexers, operators 
        10.Can be Null
        11.When a struct is assigned to a new variable, any modification to the new copy does not change the data for the original copy. 

 */



namespace Console_Struct_VS_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
          //---------------  Struct

            MyStruct myStruct;    // Create an object from struct (1st method)
            //
            MyStruct myStruct1 = new MyStruct(12);    //Create an object from struct  (2th method - use constructor)
            //
            myStruct1.myProperty = 10;

            MyStruct myStruct2 = myStruct1;  // all MyStruct1's members copy to MyStruct2 (fileds,properties,...)

            myStruct1.myProperty = 100;  // Now change value of base struct

            Console.WriteLine("myProperty of myStruct1 is:{0}",myStruct1.myProperty);
            Console.WriteLine("myProperty of myStruct2 is:{0}", myStruct2.myProperty+"\n");  // check Note no.11
            //
            //myStruct1 = null;  
            //----------------------------------- class     
            MyClass myClass = new MyClass();  // Create an object from Class 
            //
            myClass.MyProperty = 10;

            MyClass myclass2= myClass;  // all MyClass's members copy to MyClass2 (fileds,properties,...)

            myClass.MyProperty = 100;  // Now change value of base struct

            Console.WriteLine("myProperty of myClass is:{0}", myClass.MyProperty);
            Console.WriteLine("myProperty of myClass2 is:{0}", myclass2.MyProperty);  // check Note no.11
            myClass = null;


            Console.ReadKey();
        }
}


    //------------------ Struct   
    struct MyStruct : IMyInterface, IMyInterface2    // Struct	Can inherit multiple interfaces (But can't inherit from anotehr struct/class)
    {
        int myField;
        public int myProperty { get; set; }

        static int myStaticField;

        // MyStruct() {   }      ERROR :  Struct'Default Constructor

        public MyStruct(int m)    // Struct'Parametrized Constructor
        {
            myProperty = m;
            myField = m;
        }
        void myMethod()
        {

        }
    }
    //------------------ Class 
    public class MyClass : IMyInterface, IMyInterface2    // Class 	Can inherit multiple interfaces or Class 
    {
        int MyField;
        public int MyProperty { get; set; }

        static int MyStaticField;

        public MyClass()        // Class'Default Constructor
        {

        }

        public MyClass(int m)  // Class'Parametrized Constructor
        {
            this.MyField = m;
            this.MyProperty = m;
        }
        void MyMethod()
        {

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
