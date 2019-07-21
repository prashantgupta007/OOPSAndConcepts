using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyObjSerial
{
	[Serializable()]	//Set this attribute to all the classes that you define to be serialized
	public class Employee : ISerializable
	{
		public int EmpId;
		public string EmpName;
		
		//Default constructor
		public Employee()
		{
			EmpId = 0;
			EmpName = null;
		}
		
		//Deserialization constructor.
		public Employee(SerializationInfo info, StreamingContext ctxt)
		{
			//Get the values from info and assign them to the appropriate properties
			EmpId = (int)info.GetValue("EmployeeId", typeof(int));
			EmpName = (String)info.GetValue("EmployeeName", typeof(string));
		}
		
		//Serialization function.
		public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			//You can use any custom name for your name-value pair. But make sure you
			// read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
			// then you should read the same with "EmployeeId"
			info.AddValue("EmployeeId", EmpId);
			info.AddValue("EmployeeName", EmpName);
		}
	}
	
	//Main class
	public class ObjSerial
	{
		public static void Main1(String[] args)
		{
			//Create a new Employee object
			Employee emp = new Employee();
            emp.EmpId = 9;
            emp.EmpName = "JMV";
			
			// Open a file and serialize the object into it in binary format.
			// EmployeeInfo.osl is the file that we are creating. 
			// Note:- you can give any extension you want for your file
			// If you use custom extensions, then the user will now 
			//   that the file is associated with your program.
			Stream stream = File.Open("EmployeeInfo.osl", FileMode.Create);
			BinaryFormatter bformatter = new BinaryFormatter();
			
			Console.WriteLine("Writing Employee Information");
            bformatter.Serialize(stream, emp);
			stream.Close();

            //Clear emp for further usage.
            emp = null;
			
			//Open the file written above and read values from it.
			stream = File.Open("EmployeeInfo.osl", FileMode.Open);
			bformatter = new BinaryFormatter();
			
			Console.WriteLine("Reading Employee Information");
            emp = (Employee)bformatter.Deserialize(stream);
			stream.Close();

            Console.WriteLine("Employee Id: {0}", emp.EmpId.ToString());
            Console.WriteLine("Employee Name: {0}", emp.EmpName);

            Console.ReadKey();
		}
	}
}