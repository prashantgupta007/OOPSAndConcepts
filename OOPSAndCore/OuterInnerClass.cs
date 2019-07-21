using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    public class OuterInnerClass
    {
        public void OuterClassMethod()
        {
            Console.WriteLine("Inside OuterClassMethod");
        }

        public class InnerClass
        {
            public void InnerClassMethod()
            {
                Console.WriteLine("Inside InnerClassMethod");
            }
        }
    }

    public class AnotherClass
    {
        public void AnotherClassMethod()
        {
            OuterInnerClass objOuterInnerClass = new OuterInnerClass();
            objOuterInnerClass.OuterClassMethod();

            OuterInnerClass.InnerClass objInnerClass = new OuterInnerClass.InnerClass();
            objInnerClass.InnerClassMethod();
            //objInnerClass.OuterClassMethod();     // Give compile time error that OuterInnerClass.InnerClass doesn't contain
                                                    // defnition for OuterClassMethod
        }

    }
}
