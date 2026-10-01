using System.Linq.Expressions;
using System.Runtime.CompilerServices;

ShoppingList list = new ShoppingList("items.txt");

//list.Load(); // so we can start the prog as is, lets see how it will react later.

while (true)
{
    Console.WriteLine();
    list.Print();
    Console.WriteLine();
    Console.WriteLine("1. Lägg till vara");
    Console.WriteLine("2. Ta bort vara");
    Console.WriteLine("3. Spara");
    Console.WriteLine("4. Sök vara");
    Console.WriteLine("5. Avsluta");
    Console.Write("Välj: ");

    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        Console.Write("Namn: ");
        string name = Console.ReadLine();
        Console.Write("Pris: ");
        int price = int.Parse(Console.ReadLine());
        list.Add(new Item(name, price));
    }
    else if (choice == 2)
{
    Console.Write("Nummer: ");

    try
    {
        int number = int.Parse(Console.ReadLine()); // has to be in the try. 

        if (number > 3)
        {
            Console.WriteLine("Du måste välja inom intervallet 1-3");
            Console.ReadLine();
        }

        // list.RemoveAt(number); //U cant have it removed before u get into the case
    }
    catch (FormatException)
    {
        Console.WriteLine("Du måste skriva ett nummer."); // first try/catch of the session
        Console.ReadLine();
    }
}
    else if (choice == 3)
    {
        list.Save();
    }
    else if (choice == 4)
    {
        Console.Write("Namn att söka efter: ");
        string wanted = Console.ReadLine();
        Item found = list.Find(wanted);

        if (found == null)
        {
            Console.WriteLine("Varan finns inte i listan.");
        }
        else
        {
            Console.WriteLine($"Hittade: {found}");
        }
    }
    else if (choice == 5)
    {
        break;
    }
}
