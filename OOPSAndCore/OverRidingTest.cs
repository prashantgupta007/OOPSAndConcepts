using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{

    class OverRidingTest
    {
        public static void Main1()
        {
            var obj = new { city = "New York" };
            Console.Write(obj.city);
            dynamic obj1 = new { city = "New York 2" };
            Console.Write(obj1.city);
            //Console.WriteLine(20 + 45 + "A");
            //Console.WriteLine("A" + 20 + 45);
            //int hoogtePlaatjes = 900;
            //int breedtePlaatjes = 600;
            //double verHs = (hoogtePlaatjes / breedtePlaatjes);


            //Parent oParent = new Parent();
            //Parent oParentChild = new Child();
            //Child oChild = new Child();
            //Child oChildP = new Parent();  //----------Its a compile time errer
            //Child oChildParent = (Child)new Parent();  //----------Its a run time errer

            //Parent objParent = new Parent();
            //Console.WriteLine("Parent: " + objParent.GetTypeWithoutOverRiding());
            //Console.WriteLine("Parent: " + objParent.GetTypeWithOverRiding());
            //Console.WriteLine("Parent: " + objParent.StopOverRiding());
            //Console.WriteLine("Parent Class Ends Here\n");

            //Child objChild = new Child();
            //Console.WriteLine("Child: " + objChild.GetTypeWithoutOverRiding());
            //Console.WriteLine("Child: " + objChild.GetTypeWithOverRiding());
            //Console.WriteLine("Child: " + objChild.StopOverRiding());
            //Console.WriteLine("Child Class Ends Here\n");

            Parent objParentChild = new Child();                     // It will call both level constructers i.e. Parent & Child class constructors
            //Parent objParentChild = new Child("");
            Console.WriteLine("Parent-Child: " + objParentChild.GetTypeWithoutOverRiding());    // this one will call to Parent class method GetTypeWithoutOverRiding()
            Console.WriteLine("Parent-Child: " + objParentChild.GetTypeWithOverRiding());       // this one will call to Child class method GetTypeWithOverRiding()
            Console.WriteLine("Parent-Child: " + objParentChild.StopOverRiding());
            Console.WriteLine("Parent-Child Class Ends Here\n");

            //Parent objParentChildofChild = new ChildOfChild();      // It will call all three level constructers i.e. Parent, Child & then ChildOfChild class constructors
            //Console.WriteLine("Parent-Child: " + objParentChildofChild.GetTypeWithoutOverRiding());    // this one will call to Parent class method GetTypeWithoutOverRiding()
            //Console.WriteLine("Parent-Child: " + objParentChildofChild.GetTypeWithOverRiding());       // this one will call to ChildOfChild class method GetTypeWithOverRiding()
            //Console.WriteLine("Parent-Child: " + objParentChildofChild.StopOverRiding());
            //Console.WriteLine("Parent-ChildofChild Class Ends Here\n");

            //ChildOfChild objChildOfChild = new ChildOfChild();      // It will call all three level constructers i.e. Parent, Child & then ChildOfChild class constructors
            //Console.WriteLine("ChildOfChild: " + objChildOfChild.GetTypeWithoutOverRiding());
            //Console.WriteLine("ChildOfChild: " + objChildOfChild.GetTypeWithOverRiding());
            //Console.WriteLine("ChildOfChild: " + objChildOfChild.StopOverRiding());   // this one will call to child class method StopOverRiding()
            //Console.WriteLine("ChildOfChild Class Ends Here");

            Console.ReadKey();
        }
    }

    class Parent
    {
        public Parent()
        {
            Console.WriteLine("Inside Parent Class Constructor");
        }

        public Parent(string str)
        {
            Console.WriteLine("Inside Parent Class Constructo with Parameterr");
        }

        public string GetTypeWithoutOverRiding()
        {
            return "Inside Parent Class Without OverRiding Method";
        }

        //public virtual string GetTypeWithoutOverRiding()                  // This and upper, both methods act as same i.e.
        //{
        //    return "Inside Parent Class Without OverRiding Method";       // either use virtual keyword or not it will perform similar
        //}

        public virtual string GetTypeWithOverRiding()
        {
            return "Inside Parent Class With OverRiding Method";
        }

        //private virtual string GetTypeWithOverRiding1()     //  it will through a compile time error, “virtual or abstract members cannot be private”
        //{
        //    return "Inside Parent Class With OverRiding Method";
        //}

        //sealed string StopOverRiding() // It will through a compile time error "StopOverRiding() cannot be sealed because it is not an override"
        //{
        //    return "Parent With OverRiding";
        //}
        public virtual string StopOverRiding()
        {
            return "In Parent Class With OverRiding Method for Sealed Method";
        }
    }

    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Inside Child Class Constructor");
        }

        public Child(string str)
        {
            Console.WriteLine("Inside Child Class Constructor with parameter");
        }

        //public string GetTypeWithoutOverRiding()          // This and below, both methods act as same i.e. 
        //{                                                 // either use new keyword or not it will perform similar
        //    return "Inside Child Class Without OverRiding Method";
        //}

        public new string GetTypeWithoutOverRiding()
        {
            return "Inside Child Class Without OverRiding Method";
        }

        public override string GetTypeWithOverRiding()
        {
            return "Inside Child Class With OverRiding Method";
        }

        //public new string StopOverRiding()
        //{
        //    return "Inside Child Class With OverRiding for Sealed function";
        //}

        public override sealed string StopOverRiding()
        {
            return "Inside Child Class With OverRiding for Sealed function";
        }
    }

    class ChildOfChild : Child
    {
        public ChildOfChild()
        {
            Console.WriteLine("Inside ChildOfChild Class Constructor");
        }

        public string GetTypeWithoutOverRiding()
        {
            return "Inside ChildOfChild Class Without OverRiding Method";
        }

        public override string GetTypeWithOverRiding()
        {
            return "Inside ChildOfChild Class With OverRiding Method";
        }

        //public override sealed string StopOverRiding()  // Here it will through an error
        //{                                               // "cannot override inherited method 'Child.StopOverRiding()' because it is sealed"
        //    return "Inside Child Class With OverRiding for Sealed function";
        //}
    }


    public class ParentNew
    {
        string parentString;
        public ParentNew()
        {
            Console.WriteLine("Parent Constructor.");
        }

        public ParentNew(string myString)
        {
            parentString = myString;
            Console.WriteLine(parentString);
        }

        public void print()
        {
            Console.WriteLine("Print from Parent Class.");
        }
    }


    public class ChildNew : ParentNew
    {
        public ChildNew() : base("From Derived")
        {
            Console.WriteLine("Child Constructor.");
        }

        public new void print()
        {
            Console.WriteLine("Print from Child Class.");
        }

        public static void Main1()
        {
            ChildNew child = new ChildNew();
            child.print();
            ((ParentNew)child).print();

            Console.ReadLine();
        }
    }
}
