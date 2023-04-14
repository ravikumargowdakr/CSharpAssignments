
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Assignment
{
    // Define a class to be serialized
    [Serializable]
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            // Create an instance of the Person class
            Employee emp = new Employee {  Id = 121 , EmpName = "RAVI" };

            // Serialize the object to a SOAP file
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            //using (FileStream stream = new FileStream("Employee.soap", FileMode.Create))
            //{
            //    serializer.Serialize(stream, emp);
            //}

            //Deserialize the object from the SOAP file
            using (FileStream stream = new FileStream("Employee.soap", FileMode.Open))
            {
                Employee deserializedPerson = (Employee)serializer.Deserialize(stream);
                Console.WriteLine($" Id: {deserializedPerson.Id}, EmpName: {deserializedPerson.EmpName}");
            }
        }
    }
}