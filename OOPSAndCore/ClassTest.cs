﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    public class ClassTest
    {
        public static void Main1()
        {
            //NewClassTest objNewClassTest = new NewClassTest();    // Error:  NewClassTest() is inaccessible due to its protection level and can be accessed like Singleton Pattern
            NewClassTest1 objNewClassTest1 = new NewClassTest1();   // It will work fine
            objNewClassTest1.Sum(1, 2);                             // It will also work fine
            objNewClassTest1.Sub(1, 2);                             // It will also work fine
            //objNewClassTest1.Mul(1, 2);                           // Error: Mul() is not accesible du to its protection level
            //objNewClassTest1.Division(1, 2);                      // Error: Division() is not accesible due to its protection level
        }
    }

    public class NewClassTest
    {
        private NewClassTest()
        {
        }
    }

    public  class NewClassTest1
    {
        public NewClassTest1()
        {

        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        protected int Mul(int a, int b)
        {
            return a * b;
        }

        internal int Sub(int a, int b)
        {
            return a + b;
        }

        private int Division(int a, int b)
        {
            return a / b;
        }
    }
}
