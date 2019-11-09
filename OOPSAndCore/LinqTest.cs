using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore
{
    class LinqTest
    {
        List<Employee> list1 = new List<Employee>
        {
            new Employee
            {
                Name = "Prashant",
                Age = 32
            },
            new Employee
            {
                Name = "Bhavya",
                Age = 30
            }
        };

        List<Employee> list2 = new List<Employee>
        {
            new Employee
            {
                Name = "Prashant",
                Age = 31
            },
            new Employee
            {
                Name = "Nitesh",
                Age = 30
            }
        };


        static void Main1(string[] args)
        {
            //LinqTest.JoinTest();

            LinqTest.JoinDynamicTest();

        }

        static IEnumerable<Employee> JoinTest()
        {
            LinqTest linqTest = new LinqTest();
            var result = from l1 in linqTest.list1
                         join l2 in linqTest.list2 on l1.Name equals l2.Name
                         select l1;
            return result;
        }

        static IEnumerable<dynamic> JoinDynamicTest()
        {
            LinqTest linqTest = new LinqTest();
            var result = from l1 in linqTest.list1
                         join l2 in linqTest.list2 on l1.Name equals l2.Name
                         select new { l1, l2.Age };
            return result;
        }

        static IEnumerable<dynamic> LeftJoinTest()
        {
            LinqTest linqTest = new LinqTest();
            var result = from l1 in linqTest.list1
                         join l2 in linqTest.list2 on l1.Name equals l2.Name
                                into l1l2
                         from x in l1l2.DefaultIfEmpty()
                         select new { l1, x.Name };
            return result;
        }
    }
}
