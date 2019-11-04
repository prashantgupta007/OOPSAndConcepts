using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore
{
    public class AbstractTest
    {
        public static void Main1()
        {
            var child = new AbstractClassChild();
            var childOver = new AbstractClassChild("Test");
            Console.ReadKey();
        }
    }

    public abstract class AbstractClassParent
    {
        /*******
        public access spefier is also correct 
        but it'll show a warning because Abstract class can't be initialized directly
        and can be initialized only by Child or Internal classes
        ********/
        //public AbstractClassParent()
        //{
        //    Console.WriteLine("Inside AbstractClassParent");
        //}

        protected AbstractClassParent()
        {
            Console.WriteLine("Inside AbstractClassParent");
        }

        protected AbstractClassParent(string testOverload)
        {
            Console.WriteLine("Inside AbstractClassParent Overload COnstruct");
        }
    }

    public class AbstractClassChild : AbstractClassParent
    {
        public AbstractClassChild()
        {
            Console.WriteLine("Inside AbstractClassChild");
        }

        public AbstractClassChild(string testChildOverload) : base(testChildOverload)
        {
            Console.WriteLine("Inside AbstractClassChild Overload COnstruct");
        }
    }
}
