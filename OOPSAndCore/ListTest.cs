using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSAndCore
{
    class ListTest
    {
        public static void Mai1n()
        {
            List<List<pax1>> rooms = new List<List<pax1>>();
            List<pax1> room = new List<pax1>();

            // $pax = array ();
            pax1 p = new pax1();

            // $pax["paxType"] = "Adult";
            p.paxtype = "Adult";

            // $room[] = $pax;
            room.Add(p);

            // $rooms[] = $room;
            rooms.Add(room);

            pax1[][] paxRooms = new pax1[rooms.Count][];
            for (int i = 0; i < rooms.Count; i++)
            {
                paxRooms[i][1] = p;
                //paxRooms[i][1] = rooms[i].ToArray();
                //paxRooms[i][1] = p;
            }
        }
    }

    public class pax1
    {
        public string paxtype { get; set; }
        public int age { get; set; }
    }



    #region Var Test
    public class Program1
    {
        static void Main1()
        {
            //var a = "Str";
            //a = 5;

            /*
             * Error CS0029  Cannot implicitly convert type 'int' to 'string'
             */

        }
    }

    public class Program2
    {
        static void Main2()
        {
            //var a;
            //a = 5;

            /*
            Error CS0818  Implicitly - typed variables must be initialized
            */

        }
    }

    public class Program3
    {
        static void Main1()
        {
            //var a = null;
            //a = "Str";

            /*
            Error Cannot assign < null > to an implicitly-typed variable OOPSAndCore 
            */

        }
    }

    #endregion Var Test


    public class Project
    {
        public int IdNumber;

        public Project(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }

    public class Employee
    {
        public int Age;
        public string Name;
        public Project proj;

        public Employee Copy()
        {
            return (Employee)this.MemberwiseClone();
        }
    }

    public class Example
    {
        public static void Main1()
        {
            System.Console.WriteLine("12345 ".GetType());

            Console.ReadLine();

            var employeeSkill = new List<EmployeeSkill>();
            var result = employeeSkill.Where(e=> e.Skill.Count(s => s.Value >= 5) >= 3);
        }
    }

    public class EmployeeSkill
    {
        public Dictionary<string, int> Skill { get; set; }
    }
}