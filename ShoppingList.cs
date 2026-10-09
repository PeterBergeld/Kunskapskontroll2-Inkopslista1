// Holds the items and takes care of loading and saving them.
using System.Data;

class ShoppingList
{
    private List<Item> items = new List<Item>();
    private string path;

    public int Count => items.Count; // Property that returns the number of items in the list. Didnt have the count property added yet

    public int budget;
    public ShoppingList(string path, int budget)
    {
        this.path = path;
        this.budget = budget;
    }

    public bool Add(Item item) // handled by returning false or by throwing an exception. but need to change so it returns something, thus using the bool return datatype
    {
        if (Total() + item.Price > budget) 
        {
            System.Console.WriteLine("Du har inte tillräckligt med pengar och varan adderades inte");
            return false;
        }
        items.Add(item);
           // System.Console.WriteLine//("Varan lade`s till i korgen");
        return true;

    }

    // Removes the item the user sees as number 1, 2, 3 ...
    public void RemoveAt(int number)
    {
        if (number < 1 || number > items.Count) // Check if the number is out of range from the amount of products in the list. If it is, throw an exception.
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Number is out of range.");
        }
        items.RemoveAt(number - 1);
    }

    // Adds up the price of every item on the list.
    public int Total()
    {
        int sum = 0;

        for (int i = 0; i < items.Count; i++)
        {
            sum += items[i].Price;
        }

        return sum;
    }

    // Looks up an item by its name. Returns null if there is no such item.
    public Item Find(string name)
    {
        foreach (Item item in items)
        {
            if (item.Name == name)
            {
                return item;
            }
        }

        return null;
    }

    public void Print()
    {
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i].Name} - {items[i].Price} kr"); // Needed both.
        }

        Console.WriteLine($"Totalt: {Total()} kr");
    }

    // Writes one item per line, as "price;name".
    public void Save()
    {
        Console.WriteLine(Path.GetFullPath(path));
        //Console.WriteLine("Save() was called!");  // to actually see if the method is called. It is, so the problem is not here.
        //Console.WriteLine(Path.GetFullPath(path));
        List<string> lines = new List<string>();
        Console.WriteLine($"Antal varor att spara: {items.Count}");

        foreach (Item item in items)
        {
            lines.Add($"{item.Price};{item.Name}");
            
        }

        try
        {
            File.WriteAllText(path, string.Join("\r\n", lines) + "\r\n"); 
        }
        catch
        {
            Console.WriteLine("Kunde inte spara listan.");
        }   

        Console.WriteLine("Listan är sparad.");
    }

    // Reads the file back into the list.
    public void Load()
    {

           if (!File.Exists(path))
        {
                return;
        }
        string text = File.ReadAllText(path);
        string[] lines = text.Split('\n');

                                                //try.parse

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) //if the input it null or empty or whitespace then we just continue to the next line.
            {
                 continue; 
            }
            
            string[] parts = line.Trim().Split(';');
            items.Add(new Item(parts[1], int.Parse(parts[0]))); // Just to get me  started...Yeah there is an array created, so that means part 0 becomes price
            // and 1 becomes item thus 15;mjölk
            
        }
     
    }
}
