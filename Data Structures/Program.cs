using System;

namespace Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            System.Console.WriteLine("Append: " + list);

            var list2 = new LinkedList<int>();
            list2.InsertFirst(1);
            list2.InsertFirst(2);
            list2.InsertFirst(3);
            System.Console.WriteLine("Insert first: " + list2);


        }
    }
}
