using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsCSharp
{
    internal class DynamicArray
    {
        static void Main(string[] args)
        {
            DynamicArrayFunc();
        }
        static void DynamicArrayFunc()
        {
            Console.WriteLine("Enter the Size of the array");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Datatype of The array in CTS");

            Type datatype = Type.GetType(Console.ReadLine());
            Array array = Array.CreateInstance(datatype, size);
            Console.WriteLine("Lets enter the values for the array");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value for the position {i} of the datatype{datatype.Name}");
                var input = Console.ReadLine();
                array.SetValue(Convert.ChangeType(input, datatype), i);

            }
            Console.WriteLine("All the values are set, now lets read them");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
