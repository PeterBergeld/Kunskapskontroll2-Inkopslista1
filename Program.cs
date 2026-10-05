ShoppingList list = new ShoppingList("items.txt", 500);

list.Load();

while (true)
{
    list.Print();
    Console.WriteLine();
    Console.WriteLine("1. Lägg till vara");
    Console.WriteLine("2. Ta bort vara");
    Console.WriteLine("3. Spara");
    Console.WriteLine("4. Sök vara");
    Console.WriteLine("5. Avsluta");
    Console.Write("Välj: ");

    

    if (!int.TryParse(Console.ReadLine(), out int choice))
    {
        Console.WriteLine("Du måste skriva ett nummer.");
        continue;
    }

    if (choice == 1)
    {
        Console.Write("Namn: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Pris: ");
        if (!int.TryParse(Console.ReadLine(), out int price))
        {
            if ( string.IsNullOrWhiteSpace(name)) 
            throw new ArgumentException();
            System.Console.WriteLine("Du får inte skriva en tom rad");

            Console.WriteLine("Du måste skriva ett nummer.");
            continue;
        }

        bool added = list.Add(new Item(name, price));
        if (added)
        {
            System.Console.WriteLine("Varan blev tillagd");
        }
        if (price < 0) 
        {
            throw new ArgumentOutOfRangeException();
            
        }
        else
        {
            System.Console.WriteLine("Varan blev inte tillagd , du är över budget");
        }
       
    }
    else if (choice == 2)
    {
        if (list.Count == 0)  // if the list == 0 then we have to make a if statement to catch that and say the list is empty
        {
            Console.WriteLine("Listan är tom.");
            continue;
        }

        Console.Write("Ange numret på varan som ska tas bort: ");
        if (!int.TryParse(Console.ReadLine(), out int number))  // a ! false sign to catch if the user writes letters instead of numbers
        {
            Console.WriteLine("Du måste skriva ett nummer.");
            continue;
        }

        if (number < 1 || number > list.Count) // Yeah we had this one here too before. but then we didnt have the count public int Count => items.Count;
        {
            Console.WriteLine("Varan finns inte i listan.");
            continue;
        }

        list.RemoveAt(number);
        Console.WriteLine("Varan togs bort.");
    }
    else if (choice == 3)
    {
        list.Save();
    }
    else if (choice == 4)
    {
        Console.Write("Namn att söka efter: ");
        string wanted = Console.ReadLine() ?? "";
        Item found = list.Find(wanted);

        if (found == null)
            Console.WriteLine("Varan finns inte i listan.");
        else
            Console.WriteLine($"Hittade: {found}");
    }
    else if (choice == 5)
    {
        break;
    }
   
}



        // if ( string.IsNullOrWhiteSpace(name)) 
        // throw new ArgumentException();
        // System.Console.WriteLine("Du får inte skriva en tom rad");
        

        // if (price < 0)
        // throw new ArgumentOutOfRangeException();
        // System.Console.WriteLine("Du får inte skriva ett negativt tal");