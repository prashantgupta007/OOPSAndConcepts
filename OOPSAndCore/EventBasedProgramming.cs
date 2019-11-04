using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSAndCore
{

    public interface I121
    {
        event NotifyGpaDelegate NotifyToParent;

        int MyProperty { get; set; }

        void Mymethod();
    }
    
    public class EventBasedProgramming
    {
        static void Main1(string[] args)
        {
                    

            Student oStudent = new Student();
            oStudent.Name = "James";
            oStudent.GPAScore = 80;

            ParentForEvent oParent = new ParentForEvent();
            oParent.Name = "Daddy Cool";

            oStudent.NotifyToParent += new NotifyGpaDelegate(oParent.NotifyMe);
            oStudent.RecordGPAScore();
        }
    }

    public class ParentForEvent
    {
        public string Name { get; set; }

        public void NotifyMe(int pGPAScore)
        {
            Console.WriteLine(String.Format("{0} notified about the GPA {1}", Name, pGPAScore.ToString()));
        }
    }

    public delegate void NotifyGpaDelegate(int GPAScore);

    public class Student
    {
        public event NotifyGpaDelegate NotifyToParent;

        public string Name { get; set; }
        public int GPAScore { get; set; }
        public void RecordGPAScore()
        {
            //if (NotifyToParent != null) {
            //    NotifyToParent(GPAScore);
            //}
            NotifyToParent?.Invoke(GPAScore);
        }
    }
}
