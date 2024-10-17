//Divide by Zero Exception Handling


using System;

class Program
{
    static void Main()
    {
        try
        {
            // Prompt for the first number
            Console.Write("Enter the first number: ");
            double numerator = Convert.ToDouble(Console.ReadLine());

            // Prompt for the second number
            Console.Write("Enter the second number: ");
            double denominator = Convert.ToDouble(Console.ReadLine());



            //Null Reference Exception

using System;

class Program
{
    static void Main()
    {
        try
        {
            // Create a null object of type Person
            Person person = null;

            // Attempt to access a method on the null object
            Console.WriteLine(person.GetName());
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Error: Attempted to access a method or property on a null object.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}

class Person
{
    public string Name { get; set; }

    public string GetName()
    {
        return Name ?? "No name set";
    }
}




            //Merge two sorted linkedlist


using System;

public class ListNode
{
    public int Val;
    public ListNode Next;
    public ListNode(int val = 0, ListNode next = null)
    {
        Val = val;
        Next = next;
    }
}

public class MergeTwoSortedLinkedLists
{
    public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        while (l1 != null && l2 != null)
        {
            if (l1.Val < l2.Val)
            {
                tail.Next = l1;
                l1 = l1.Next;
            }
            else
            {
                tail.Next = l2;
                l2 = l2.Next;
            }
            tail = tail.Next;
        }

        tail.Next = l1 ?? l2;
        return dummy.Next;
    }

    public static void Main()
    {
        ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        ListNode mergedHead = MergeTwoLists(l1, l2);
        Console.Write("Merged List: ");
        PrintList(mergedHead);
    }

    private static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.Val + (head.Next != null ? " -> " : "\n"));
            head = head.Next;
        }
    }
}


            //Index Out of Range Exception



using System;

class Program
{
    static void Main()
    {
        // Create an array of 5 elements
        string[] fruits = { "Apple", "Banana", "Cherry", "Date", "Elderberry" };

        try
        {
            // Prompt the user to enter an index
            Console.Write("Enter an index (0-4) to access a fruit: ");
            int index = Convert.ToInt32(Console.ReadLine());

            // Display the corresponding element
            Console.WriteLine($"Fruit at index {index}: {fruits[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Error: The index entered is out of range. Please enter a valid index (0-4).");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric index.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}


            //File Not Found Exception


using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Specify the path of a non-existing file
        string filePath = "non_existing_file.txt";

        try
        {
            // Attempt to read the file
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File content:");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: The file was not found. Please check the file path.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}


            //Implement a generic Stack


using System;

public class Stack<T>
{
    private class Node
    {
        public T Value;
        public Node Next;

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node top;

    public void Push(T value)
    {
        Node newNode = new Node(value) { Next = top };
        top = newNode;
    }

    public T Pop()
    {
        if (top == null) throw new InvalidOperationException("Stack is empty.");
        T value = top.Value;
        top = top.Next;
        return value;
    }

    public bool IsEmpty()
    {
        return top == null;
    }

    public static void Main()
    {
        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine($"Popped Value: {stack.Pop()}"); // Should print 3
        Console.WriteLine($"Stack Empty: {stack.IsEmpty()}"); // Should print False
    }
}


            //Reverse a Linked List



using System;

public class ListNode
{
    public int Val;
    public ListNode Next;
    public ListNode(int val = 0, ListNode next = null)
    {
        Val = val;
        Next = next;
    }
}

public class ReverseLinkedList
{
    public static ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;

        while (current != null)
        {
            ListNode nextTemp = current.Next;
            current.Next = prev;
            prev = current;
            current = nextTemp;
        }
        return prev;
    }

    public static void Main()
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        Console.WriteLine("Original List: 1 -> 2 -> 3 -> 4");
        ListNode reversedHead = ReverseList(head);
        Console.Write("Reversed List: ");
        PrintList(reversedHead);
    }

    private static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.Val + (head.Next != null ? " -> " : "\n"));
            head = head.Next;
        }
    }
}


            //Find the Element of a LinkedList

using System;

public class ListNode
{
    public int Val;
    public ListNode Next;
    public ListNode(int val = 0, ListNode next = null)
    {
        Val = val;
        Next = next;
    }
}

public class FindMiddleElement
{
    public static ListNode FindMiddle(ListNode head)
    {
        if (head == null) return null;

        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }
        return slow;
    }

    public static void Main()
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode middle = FindMiddle(head);
        Console.WriteLine($"Middle Element: {middle?.Val}"); // Should print 3
    }
}


            //Implement a Generic Queue Using Linked List


using System;

public class LinkedListQueue<T>
{
    private class Node
    {
        public T Value;
        public Node Next;

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node head;
    private Node tail;

    public LinkedListQueue()
    {
        head = null;
        tail = null;
    }

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (tail != null)
        {
            tail.Next = newNode;
        }
        tail = newNode;
        if (head == null)
        {
            head = tail;
        }
    }

    public T Dequeue()
    {
        if (head == null) throw new InvalidOperationException("Queue is empty.");
        T value = head.Value;
        head = head.Next;
        if (head == null)
        {
            tail = null; // If the queue is now empty, set tail to null
        }
        return value;
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    public static void Main()
    {
        var queue = new LinkedListQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        Console.WriteLine($"Dequeued Value: {queue.Dequeue()}"); // Should print 1
        Console.WriteLine($"Queue Empty: {queue.IsEmpty()}"); // Should print False
    }
}


            //Format Exception


using System;

class Program
{
    static void Main()
    {
        try
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            // Attempt to convert the input to an integer
            int number = Convert.ToInt32(userInput);

            // Display the result
            Console.WriteLine($"You entered: {number}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: The input is not a valid number. Please enter a numeric value.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The number entered is too large or too small for an integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}



            // Perform the division
            double result = Divide(numerator, denominator);

            // Display the result
            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static double Divide(double numerator, double denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException();
        }
        return numerator / denominator;
    }
}
