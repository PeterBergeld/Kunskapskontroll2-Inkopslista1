// Holds the items and takes care of loading and saving them.
class ShoppingList
{
    private List<Item> items = new List<Item>();
    private string path;

    public ShoppingList(string path)
    {
        this.path = path;
    }

    public void Add(Item item)
    {
        items.Add(item);
    }

    // Removes the item the user sees as number 1, 2, 3 ...
    public void RemoveAt(int number)
    {
        items.RemoveAt(number - 1);
    }

    // Adds up the price of every item on the list.
    public int Total()
    {
        int sum = 0;

        for (int i = 1; i < items.Count; i++)
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
            Console.WriteLine($"{i + 1}. {items[i]}");
        }

        Console.WriteLine($"Totalt: {Total()} kr");
    }

    // Writes one item per line, as "price;name".
    public void Save()
    {
        List<string> lines = new List<string>();

        foreach (Item item in items)
        {
            lines.Add($"{item.Price};{item.Name}");
        }

        try
        {
            File.WriteAllText(path, string.Join("\r\n", lines) + "\r\n"); // Line "" SO IT CREATES A EMPTY ONE
        }
        catch
        {
        }

        Console.WriteLine("Listan är sparad.");
    }

    // Reads the file back into the list.
    public void Load()
    {
        string text = File.ReadAllText(path);
        string[] lines = text.Split('\n');

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) // So we have to make an if statment to catch if its letters and not a number
            {
                 continue; 
            }
            
            string[] parts = line.Split(';');
            items.Add(new Item(parts[1], int.Parse(parts[0]))); // Just to get me  started...Yeah there is an array created, so that means part 0 becomes price
            // and 1 becomes item thus 15;mjölk
            
        }
    }
}
//     foreach (string line in lines)
// {
//     string[] parts = line.Split(';');

//     Console.WriteLine($"Line: '{line}'");
//     Console.WriteLine($"Parts count: {parts.Length}");

//     items.Add(new Item(parts[1], int.Parse(parts[0])));   // Error handling. CW writes it out in the console 

//'ine: '15;Mjölk
// Parts count: 2
// 'ine: '32;Bröd
// Parts count: 2
// 'ine: '89;Ost
// Parts count: 2
// Line: ''  thats the one that makes the error
// Parts count: 1
// }
// }
// }

// Line "" SO IT CREATES A EMPTY ONE
