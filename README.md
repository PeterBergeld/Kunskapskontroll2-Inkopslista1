### Skriv bokstäver där programmet vill ha ett tal.
So every line in the program that wants a number?!!?
mdContent.AppendLine("<font size=\"6\">1</font>");
### Ta bort en vara som inte finns.         //Made it awkward for me as that tells me to remove line of code from the prog. asap. 
### Where IS THE PRODUCT!!
### but I need to cleary slow it down
---------

#### __Starting the prog__

__1__
### Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array. = Points to a list thats outside of an valid range of an array
cs:line 90
We change the 0 to 3 cus we have 3 parts (3 products).  items.Add(new Item(parts[1], int.Parse(parts[3 instead of 0])));

### at Program.<Main>$(String[] args) in C:\Users\peter\Desktop\Kunskapskontroll2-Inkopslista\Program.cs:line 2
At line 2 the list goes away and we can run the code.




### 2 Skriv bokstäver där programmet vill ha ett tal.
--------------------
"What string is being passed into int.Parse() when it crashes?"
Id say there is none as its a int again so that needs to be a string
.Stopping here for now Its some Tryparse missing here i presume. 2026-09-30

Unhandled exception. System.FormatException: The input string 'hej' was not in a correct format.
   at System.Number.ThrowFormatException[TChar](ReadOnlySpan`1 value)
   at System.Int32.Parse(String s)
   at Program.<Main>$(String[] args) in C:\Users\peter\Desktop\Kunskapskontroll2-Inkopslista\Program.cs:line 29 (32)

   The try/catch get used to fix the error


__4__
-----------
   Lägg till en vara, spara, avsluta och starta om. Ser listan likadan ut?











#### 2 side (2 chapter )

C:\Users\peter\Desktop\Kunskapskontroll2-Inkopslista\Program.cs(61,5): error CS1022: Type or namespace definition, or end-of-file expected
C:\Users\peter\Desktop\Kunskapskontroll2-Inkopslista\Program.cs(61,6): error CS8641: 'else' cannot start a statement.
C:\Users\peter\Desktop\Kunskapskontroll2-Inkopslista\Program.cs(61,6): error CS1003: Syntax error, '(' expected
C:\Users\peter\Desktop\Kunskapskontroll2-Inkopslista\Program.cs(61,6): error CS1525: Invalid expression term 'else'
C:\Users\peter\Desktop\Kunskapskontroll2-Inkopslista\Program.cs(61,6): error CS1026: ) expected
C:\Users\peter\Desktop\Kunskapskontroll2-Inkopslista\Program.cs(61,6): error CS1002: ; expected
C:\Users\peter\Desktop\Kunskapskontroll2-Inkopslista\Program.cs(85,1): error CS1022: Type or namespace definition, or end-of-file expected





__3__ #### Ta bort en vara som inte finns
--------------------------------------------------

### Unhandled exception. System.ArgumentOutOfRangeException: Index was out of range. Must be non-negative and less than the size of the collection. (Parameter 'index')
### at System.Collections.Generic.List`1.RemoveAt(Int32 index)
### at ShoppingList.RemoveAt(Int32 number) in C:\Users\peter\Desktop\Kunskapskontroll2-Inkopslista\ShoppingList.cs:line 20
### at Program.<Main>$(String[] args) in C:\Users\peter\Desktop\Kunskapskontroll2-Inkopslista\Program.cs:line 30

The index is out of range. Cant be negative and less than the "amount"
Belive that the list changed now tho as i only type "Mjölk" 20 no ? 17:33 09-30-26
The Case didnt go as it got removed at. 
"Yeah that worked but why did i have to comment out the removeat?"
Chat- The number input got removed and gave the error. 