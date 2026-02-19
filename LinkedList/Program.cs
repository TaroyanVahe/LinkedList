namespace LinkedList;

internal class Program
{


    static void Main(string[] args)
    {

        Linked_List list = new Linked_List();
        list.Insert(5);
        list.Insert(1);
        list.Insert(2);
        list.Insert(3);
        list.Insert(7);
        list.Insert(8);

        list.Print();


        Console.WriteLine(list.Find(1));
        list.Remove(4);

        list.Print();
        Console.WriteLine(list.Find(4));

    }

}