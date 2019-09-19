using System;

namespace linked_list
{
    public class Program
    {
        public static void Main()
        { 
            string[] data = new string[]{"E", "B", "E", "E", "B", "A", "B"};    
            Node linked_list = LinkedListHelpers.createLinkedList(new string[]{"E", "B", "E", "E", "B", "A", "B"});
            Node filteredList = LinkedListHelpers.removeDuplicate(linked_list);
            LinkedListHelpers.print(filteredList);
        }
       
    }
}
