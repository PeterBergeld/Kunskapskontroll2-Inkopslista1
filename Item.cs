// One item on the shopping list.
class Item
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Item(string name, int price)
    {
        if ( string.IsNullOrWhiteSpace(name)) 
        throw new ArgumentException();
        System.Console.WriteLine("Du får inte skriva en tom rad");
        

        if (price < 0)
        throw new ArgumentOutOfRangeException();
        System.Console.WriteLine("Du får inte skriva ett negativt tal");
//         }
{
        Name = name;
        Price = price;
}

// if ( string.IsNullOrWhiteSpace(name)) //Should be before the Item is "created"
//         {
//             throw new ArgumentException();
//         }
    }

    public override string ToString()
    {
        return $"{Name} - {Price} kr";
    }
}
