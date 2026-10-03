// Holds the items and takes care of loading and saving them.
using System.Data;

class ShoppingList
{
    private List<Item> items = new List<Item>();
    private string path;

    public int Count => items.Count; // Property that returns the number of items in the list. Didnt have the count property added yet

    
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
        //Console.WriteLine("Save() was called!");  // to actyally see if the method is called. It is, so the problem is not here.
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
        }    // so what happens when we just comment it out? It will just not save the list. yeah thats a crash XDXD
        // try
        // {
        //     File.WriteAllText(path, string.Join("\r\n", lines) + "\r\n"); // Line "" SO IT CREATES A EMPTY ONE
        // }
        // catch
        // {
        // }    // so what happens when we just comment it out? It will just not save the list. yeah thats a crash XDXD

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
