using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    class StaticTest
    {
        public static void Main1()
        {
            var a = 100;
            dynamic b = a;
            var c = b;
            c = "";
            //NewClassTest1 objNewClassTest1 = new NewClassTest1();   // It will work fine(Check this class in ClassTest.cs)
            //objNewClassTest1.Sum(1, 2); 


            //Write the order of constructors calling of both of classes objects creation
            //Class1 objClass1 = new Class2();
            //Class1 objClass1 = new Class2("");
            Class1 objClass1 = new Class2("", "");
            //Class2 objClass2 = new Class2();
            //Class2 objClass2 = new Class2("");

            //StaticClass.StaticTestFunction();
            //StaticClass.StaticTestFunction("");

            //NonStaticClass.StaticTestFunction();
            //NonStaticClass.StaticTestFunction(); 

            //NonStaticClass nsc = new NonStaticClass();
            //nsc.NonStaticTestFunction();
            //nsc = new NonStaticClass("paramerized constructor");
            //nsc.NonStaticTestFunction();
            NonStaticClass.StaticTestFunction();

            //NonStaticClass nsc1 = new NonStaticClass("paramerized constructor");
            //nsc1.NonStaticTestFunction();

            Console.ReadKey();
        }
    }

    #region Non Static Class
    class NonStaticClass
    {
        ///<summary>
        /// Note 1: If we create an object of any class or initilizes a class with default constructor then only default constructor will be called
        ///         parameterized/overloaded constructor will never be called
        ///</summary>
        public NonStaticClass() // default constructor
        {
            Console.WriteLine("Inside default Constructor of NonStaticClass");
        }

        ///<summary>
        /// Note 1: If we create an object of any class or initilizes a class with parameterized constructor then default constructor will never be called
        ///         only parameterized/ overloaded constructor will be called
        /// Note 2: If a class has non default constructor then it is not necessary to create default constructor
        ///</summary>
        public NonStaticClass(string str)  // normal constructor with paramer i.e. overloaded constructor
        {
            Console.WriteLine("Inside parametersied Constructor of NonStaticClass");
        }

        ///<summary>
        /// Note 1: Static constructor can never be overloaded either a class is staic or non static i.e. a static constructor can exists only once in a class
        /// Note 2: We can never call static constructor explicitly, it automatically invokes with the invokation of any member of a class
        /// Note 3: Whenever we initialize any class member or function, Static constructors always initializes itself first before any constructor
        /// Note 4: If a non static class do not have static constructor then static function will never call default constructor
        ///         and just the static function/method will be called, But if a non static class will have static constructor 
        ///         and if we call a static or nonstatic function then static constructor will be automatically called at first.
        /// Note 5: In a single calling method only once a static constructor will be called i.e. 
        ///         If I'll call StaticTestFunction() twice in the Main() or if I'll call static function(s) with non static function(s) in both cases
        ///         static constructor will be called once.
        ///</summary>
        static NonStaticClass() // static constructor
        {
            Console.WriteLine("Inside Static Constructor of NonStaticClass");
        }

        public static void StaticTestFunction()
        {
            Console.WriteLine("Inside Static Function of NonStaticClass");
        }

        public void NonStaticTestFunction()
        {
            Console.WriteLine("Inside Normal Function of NonStaticClass");
        }
    }
    #endregion Non Static Class


    #region Static Class
    ///<summary>
    /// Note 1: Static class can never have non static members because we can't create objects of static classes
    /// Note 2: In a Static class we explicitely need to define every member as static
    ///</summary>

    //static class StaticClass : NonStaticClass     { // lines of codes }       // this and below, both type of inheritance will throw and error
    //static class StaticClass : AnotherStaticClass { // lines of codes}        // "Static classes can't derived from type. It must be derived from object"

    //public static class StaticClass { // lines of codes }  // this and below Both lines are correct just their access modifier is different
    static class StaticClass                             // below has public and it has default access modifier which is internal
    {
        ///<summary>
        /// Error: It will give a compilation error that "access modifiers are not allowed on static constructors"
        /// </summary>
        //public static StaticClass()
        //{
        //    Console.WriteLine("Inside Static Constructor of StaticClass");
        //}
        static StaticClass()
        {
            Console.WriteLine("Inside Static Constructor of StaticClass");
        }

        //static StaticClass(string str)    //It's a compile time error, i.e. "Static constructor must be parameterless"
        //{
        //    Console.WriteLine("Inside Static Constructor of StaticClass");
        //}

        public static void StaticTestFunction()
        {
            Console.WriteLine("Inside Static Function of StaticClass");
        }

        public static void StaticTestFunction(string str)
        {
            Console.WriteLine("Inside Static Function of StaticClass with overloaded function");
        }

        ///<summary>
        /// Error: It will throw an error that "cannot declare instance member in a static class"
        /// </summary>
        //public void NonStaticTestFunction()
        //{
        //    Console.WriteLine("Inside Non Static Function of StaticClass");
        //}

    }
    #endregion Static Class


    #region Another Static Class
    //static class AnotherStaticClass : NonStaticClass { // lines of codes }       // this and below, both type of inheritance will throw and error
    //static class AnotherStaticClass : StaticClass    { // lines of codes}        // "Static classes can't derived from type. It must be derived from object"
    //public static class AnotherStaticClass  // this and below Both lines are correct just their access modifier is different
    public static class AnotherStaticClass           // It has public and upper has default access modifier which is internal
    {

    }
    #endregion Another Static Class

    //class AnotherNonStaticClass : AnotherStaticClass  //Error: 'OOPSAndCore.AnotherNonStaticClass': cannot derive from static class 'OOPSAndCore.AnotherStaticClass'
    //{ 

    //}

    public class Class1
    {
        public Class1()
        {
            Console.WriteLine("Inside default Constructor of Class1");
        }

        public Class1(string param)
        {
            Console.WriteLine("Inside parameterized Constructor of Class1");
        }

        static Class1()
        {
            Console.WriteLine("Inside static Constructor of Class1");
        }
    }

    public class Class2 : Class1
    {
        public Class2()
        {
            Console.WriteLine("Inside default Constructor of Class2");
        }

        public Class2(string param)
        {
            Console.WriteLine("Inside parameterized Constructor of Class2");
        }

        public Class2(string param1, string praram2) : base("")
        {
            Console.WriteLine("Inside double parameterized Constructor of Class2");
        }

        static Class2()
        {
            Console.WriteLine("Inside static Constructor of Class2");
        }
    }
}
