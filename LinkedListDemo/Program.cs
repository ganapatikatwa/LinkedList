namespace LinkedListDemo
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Computation of Linked List");
            LinkedList linkedlist = new LinkedList();
            linkedlist.Append(56);
            linkedlist.Append(30);
            linkedlist.Append(70);
            linkedlist.Display();
        }
    }
}