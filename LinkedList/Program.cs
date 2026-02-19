namespace LinkedList;

internal class Program
{


    static void Main(string[] args)
    {

        Linked_List<string> list = new Linked_List<string>();
        list.Insert("Vahe");
        list.Insert("Armen");
        list.Insert("Narek");
        list.Insert("Hayk");
        list.Insert("Ara");
        list.Insert("Suren");

        list.Print();


        Console.WriteLine(list.Find("Vahe"));
        //list.Remove("Vahe");
        list.Remove("Suren");
        list.Insert("Sur");
        

        list.Print();

     

    }

}