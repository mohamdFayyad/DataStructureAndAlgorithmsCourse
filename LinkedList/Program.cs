namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new(1, "study DS");
            Task task2 = new(2, "workout for hour");
            Task task3 = new(3, "study problem solving");

            Node head = new(task1);
            Node node2 = new(task2);
            Node node3 = new(task3);

            head.NextNode = node2;
            node2.NextNode = node3;

            Console.WriteLine(head.NextNode?.NextNode?.Task.Text);

        }
    }
}