using System.Text;

namespace Codewars.LinkedList;

public class Node
{
    public int Data { get; private set; }
    public Node Next { get; private set; }

    public Node(int data, Node next = null)
    {
        Data = data;
        Next = next;
    }
    
    public static string Stringify(Node? list)
    {
        StringBuilder result = new StringBuilder("");

        while (list != null)
        {
            result.Append(list.Data.ToString());
            result.Append(" -> ");
            list = list.Next;
        }
        result.Append("null");

        return result.ToString();
    }

    public static Node Push(Node? head, int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        return newNode;
    }

    public static Node BuildOneTwoThree()
    {
        Node? result = null;

        result = Push(result, 3);
        result = Push(result, 2);
        result = Push(result, 1);

        return result;
    }
    
    public static int Length(Node? head)
    {
        int length = 0;
        while (head != null)
        {
            length += 1;
            head = head.Next;
        }

        return length;
    }
  
    public static int Count(Node head, Predicate<int> func)
    {
        throw new NotImplementedException();
    }
}