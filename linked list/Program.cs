using System;

namespace linked_list
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] data = new string[]{"E", "B", "E", "E", "B", "A", "B"};    
            Node linked_list = LinkedListHelpers.createLinkedList(new string[]{"E", "B", "E", "E", "B", "A", "B"});
            LinkedListHelpers.print(linked_list);
            Console.WriteLine();
            Node filteredList = LinkedListHelpers.removeDuplicate(linked_list);
            LinkedListHelpers.print(filteredList);
        }
       
    }
}
