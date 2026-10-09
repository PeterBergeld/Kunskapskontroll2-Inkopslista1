// One item on the shopping list.
class Item
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Item(string name, int price)
    {
       // Console.WriteLine($"DEBUG: name = '{name}'"); 
        if (string.IsNullOrWhiteSpace(name))
        {
           throw new ArgumentException("Namnet kan inte vara null eller tomt");  
           
        }

        //System.Console.WriteLine("Du får inte skriva en tom rad"); 
    
        if (price < 0)
        {
        throw new ArgumentOutOfRangeException(nameof(price), "Du får inte skriva ett negativt tal");
        //System.Console.WriteLine("Du får inte skriva ett negativt tal");
        }
        
//         }
        Name = name;
        Price = price;
    }




    public override string ToString()
    {
        return $"{Name} - {Price} kr";
    }
}


