﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    class TryCatchTest
    {
        public static void Main1()
        {
            TryWithoutCatch();
        }
        private static void TryWithoutCatch()
        {
            /* try block can be written without catch block, but in this case we must have to
               write finally block. Otherwise it will give a compile time error.
             * Means we can implement try, catch & finally block like this:
             # try{} catch{}
             # try{} catch{} finally{} 
             # try{} finally{} -- But in this case if any exception will occured then finally clause will not be called and it'll throw unhandled exception
             * But we can't implement try, catch & finally block like this:
             # try{}
             # catch{}
             # catch{} finally{}
             */
            try
            {
                //var value = Convert.ToInt32("as");
            }
            //catch (Exception ex) 
            //{
            //    Console.Write("Inside Catch Block");  
            //}
            finally // this code will work fine :-)
            {
                Console.Write("Inside Finally");
            }                            
        }

        private void TryCatchMethod1()
        {
            try { }
            catch (Exception ex) { }
            //catch (ArrayTypeMismatchException exc)    // Its a compile time error i.e.
            //{ }                                       // A previous catch clause already catches all exceptions of this or of a super type ('System.Exception')
        }

        private void TryCatchMethod2()
        {
            try { }
            catch (ArrayTypeMismatchException exc) 
            { }
            catch (Exception ex) { }                        // It will work fine, because super class exception is written after Children class exceptions
        }

        private void TryCatchBlockWithThrows()
        {
            //throw;                                        // It's compile time error i.e. A throw statement with no argument is not allowed outside of a catch clause
            
            //string s = "";
            //throw s;                                      // It's compile time error i.e. the type caught or thrown must be derived from System.Exception
            
            
            try 
            {
                //throw;                                    // It's compile time error i.e. A throw statement with no argument is not allowed outside of a catch clause

                //string s = "";
                //throw s;                                  // It's compile time error i.e. the type caught or thrown must be derived from System.Exception
            }
            catch (Exception ex) 
            {
                throw;                                      // these both lines will work fine
                throw ex;

                //string s = "";
                //throw s;                                  // It's also a error i.e. the type caught or thrown must be derived from System.Exception
            }
            
        }
    }
}
