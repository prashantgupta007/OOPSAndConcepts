using System;

namespace OOPSAndCore
{
    //internal interface InternalInterface      // This and below lines of code are same i.e.
    interface IInternalInterface                 // default access specifier for interface, class & struct is internal
    {
        void M1();

        //internal void M2();        // The modifier 'internal' is not valid for this item

        //public void M3();         // The modifier 'public' is not valid for this item

        //protected void M4();      // Compilation error: Target runtime doesn't support 'protected', 'protected internal',
                                    //  or 'private protected' accessibility for a member of an interface.
    }

    public interface IPublicInterface
    {
        void M1();

        //internal void M2();       // The modifier 'internal' is not valid for this item

        //public void M3();         // The modifier 'public' is not valid for this item

        //protected void M4();      // Compilation error: Target runtime doesn't support 'protected', 'protected internal',
                                    //  or 'private protected' accessibility for a member of an interface.
    }

    public class InterfaceTest : I1, I2, I3
    {
        //void M1()                          
        //{                                 //  -----  These both methods will give an error -----  //
        //    Console.WriteLine("Hi");      //  'OOPSAndCore.InterfaceTest' does not implement interface member 'OOPSAndCore.I1.M1()'.
        //}                                 //  'OOPSAndCore.InterfaceTest.M1()' cannot implement an interface member because it is not public
        //protected void M1()
        //{
        //    Console.WriteLine("Hi");
        //}

        public void M1()
        {
            Console.WriteLine("Hi! Inside M1 method of Interface I1");
        }

        //void I2.M()                                   //  I will give a error "The modifier 'public' is not valid for this item"
        //{
        //    Console.WriteLine("Hi inside M method of Interface I2");
        //}

        void I2.M2()
        {
            Console.WriteLine("Hi inside M2 method of Interface I2");
        }
        public void M()
        {
            Console.WriteLine("Hi inside M");
        }
        void I2.M()
        {
            Console.WriteLine("Hi inside M method of Interface I2");
        }
        void I3.M()
        {
            Console.WriteLine("Hi inside M method of Interface I3");
        }

        public static void Main1()
        {
            InterfaceTest objInterfaceTest = new InterfaceTest();
            objInterfaceTest.M1();
            //objInterfaceTest.M2();                       // 'OOPSAndCore.InterfaceTest' does not contain a definition for 'M2' and no extension method 'M2' accepting 
                                                           // a first argument of type 'OOPSAndCore.InterfaceTest' could be found (are you missing a using directive or an assembly reference?)

            //****Imp:  Create object of Interface type inside InterfaceTest heap ****//
            I2 objI2 = new InterfaceTest();
            objI2.M2();                                   // this will call the second M2 method which is tagged with I2 interface name

            I3 objI3 = new InterfaceTest();
            
            objInterfaceTest.M();                         //1. this will call the first M method which is not tagged with interface name
            objI2.M();                                    //2. this will call the second M method which is tagged with I2 interface name
            objI3.M();                                    /*3. this will call the third M method which is tagged with I3 interface name
                                                             and if we will comment or remove third M2 method which is tagged with I3 interface name
                                                             then it will call the first M method which is not tagged with interface name */
           
            Console.ReadKey();
        }
    }

    interface I1
    {
        //int i { get; set; }       // An interface can also have properties 
        void M1();
    }

    //public interface I2
    interface I2                 // We can also declare intrface from above line because both are correct just the accesibility of interface has been changed
    {
        // public void M();      // It's an error, "The modifier 'public' is not valid for this item" 
        void M();                // It's correct syntax
        void M2();
        //M2();                  // It's an error (this declaration is incorrect and above one is correct), "Method must have a return type" 
        //void M2() {}           // It is also an error "Interface method cannot have a declaration"
    }

    interface I3
    {
        void M();
        //void M3();
    }
}
