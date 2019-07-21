using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    public class GenericClass<T>
    {
        T t;
        public GenericClass(T obj)
        {
            t = obj;
        }

        public void GetClassType()
        {
            Console.Write("\nType of class is: " + t.GetType());
        }
    }

    public class Test
    {
        //enum Week : int { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        //enum Week { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

        public static void Main1()
        {
           //Week w = Week.Wednesday;

            GenericClass<string> str = new GenericClass<string>("");
            str.GetClassType();

            GenericClass<int> inte = new GenericClass<int>(0);
            inte.GetClassType();

            Console.ReadKey();

            //MyCustomList<int> intList = new MyCustomList<int>();
            //// Add two integers to list
            //intList.Add(1);
            //intList.Add(33);
            ////intList.Add("Emp"); // The next statement will fail and wont compile

            ////If we want our MyCustomList to store strings, it can be done as follows:
            //MyCustomList<string> strList = new MyCustomList<string>();
            //strList.Add("Emp"); // This statement will not fail and run properly
        }
    }

    public class MyCustomList<MYTYPE>
    {
        private ArrayList m_list = new ArrayList();
        public int Add(MYTYPE value)
        {
            return m_list.Add(value);
        }

        public void Remove(MYTYPE value)
        {
            m_list.Remove(value);
        }

        public MYTYPE this[int index]
        {
            get
            {
                return (MYTYPE)m_list[index];
            }
            set
            {
                m_list[index] = value;
            }
        }
    }
}
