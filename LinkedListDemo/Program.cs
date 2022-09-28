namespace LinkedListDemo
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Computation of Linked List");
            LinkedList linkedlist = new LinkedList();
            linkedlist.AddFirst(70);
            linkedlist.AddFirst(30);
            linkedlist.AddFirst(56);
            linkedlist.Display();
        }
    }
}