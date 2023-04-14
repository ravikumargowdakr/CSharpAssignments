namespace AssignmentsCSharp
{
    internal class OddEvenNo
    {
        static void Main(string[] args)
        {
            OddandEvenArray();
        }
        static void OddandEvenArray()
        {
            Console.WriteLine("Enter the number of Elements you want to add");
            var n = Console.ReadLine();
            int[] elements = new int[Convert.ToUInt32(n)];
            Console.WriteLine("Enter The elements");
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int j in elements)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine("Even " + j);
                }
                else
                {
                    Console.WriteLine("Odd " + j);
                }
            }

        }
    }
}