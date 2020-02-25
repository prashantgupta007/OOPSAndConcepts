using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore
{
    class ConstructorTest
    {
        public static void Main1()
        {
            //** MOST IMPORTANT NOTE: ** All static constructor get called first according to above hierarchy then it calls to normal constructors
            // Also static constructors can't be called explictly and we can't control the calling of static constructors
            /* It should always be remembered that constructor creation goes Child to Parent constructor for static constructors
               and Parent to Child constructors for normal class constructors
            */
            /* We can't write any access specifier with static constructor. e.g.
             
               public static StaticClass(){}     //It will give a compilation error that "access modifiers are not allowed on static constructors"
            */
            /* We can't create overloaded static constructors. i.e.
             
               static StaticClass(string str)    //It's a compile time error, i.e. "Static constructor must be parameterless"
             */

            //Parent parent = new Parent();       // It'll call Parent static constructor then default Parent class constructor
            //Console.WriteLine("Parent Class Ends Here\n\n");

            //Child child = new Child();            // It'll call child static then Parent static constructor then Parent default constructor then child class default constructor
            //Parent parentChild = new Child();     // Constructor calling order will be similar to above style
            //Console.WriteLine("Child Class Ends Here\n\n");

            //ChildOfChild childOfChild = new ChildOfChild();     //  constructor Calling order will be ChildOfChild then Child then Parent class static constructors first
            Child parentOfChildOfChild = new ChildOfChild();      //  afterwards Parent then Child then ChildOfChild normal constructors
            //Parent parentChildOfChild = new ChildOfChild();     //  Constructor calling order for this and above 2 lines would be same
            //Console.WriteLine("Child Class Ends Here\n\n");

            Console.ReadKey();
        }
    }
}
