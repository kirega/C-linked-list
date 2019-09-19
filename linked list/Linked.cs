using System;
/* Declaration syntax in C# is [access-specifier] [type] [name] */
public static class LinkedListHelpers
{

    public static Node removeDuplicate(Node node)
    {
        string history = "";
        Node head = node;
        Node prev = node;
    
        while (node != null)
        {
            int count = history.Length - history.Replace(node.data, "").Length;
        
            if (count >= 2)
            {
                prev.next = node.next;
            }
            else
            {
                prev = node;
                history += node.data;
            }
            node = node.next;
        }

        return head;
    }

    public static void print(Node node)
    {
        while (node != null)
        {   
            if(node.next != null){
                Console.Write(node.data + "->");
            } else{
                Console.Write(node.data );
            }
            node = node.next;
        }

    }
    public static Node createLinkedList(string[] data){
        if(data.Length > 1) {
            Node head = new Node(data[0]);
            Node last = head;
            for(int i = 1; i < data.Length; i++){
                while(last.next != null) {
                    last = last.next;
                }
                last.next = new Node(data[i]);
            }
            return head;
        }
        return new Node("Error");
    }
}