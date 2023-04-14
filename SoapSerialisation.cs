
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Assignment
{
    
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
            
            Employee emp = new Employee {  Id = 121 , EmpName = "RAVI" };

            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (FileStream stream = new FileStream("Employee.soap", FileMode.Create))
            {
                serializer.Serialize(stream, emp);
            }
            using (FileStream stream = new FileStream("Employee.soap", FileMode.Open))
            {
                Employee deserializedPerson = (Employee)serializer.Deserialize(stream);
                Console.WriteLine($" Id: {deserializedPerson.Id}, EmpName: {deserializedPerson.EmpName}");
            }
        }
    }
}
