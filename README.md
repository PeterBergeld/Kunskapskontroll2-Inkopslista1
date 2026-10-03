
# Kunskapskontroll 2 – Inköpslista

## Debugging Notes and Observations

### 1. Testing Invalid Input

**Instruction:** Skriv bokstäver där programmet vill ha ett tal.

**My interpretation:** Does this mean every line in the program that expects a number?

For example:
- Menu choice
- Product price
- Product number when removing an item

The goal is to test what happens when the user enters something unexpected, such as `hej` instead of a number.

### 2. Removing a Product That Doesn't Exist

**Instruction:** Ta bort en vara som inte finns.

**My comment:** I found this instruction confusing because I interpreted it as removing a line of code from the program.

What I need to test is what happens when the user tries to remove a product that isn't in the list.

### 3. Where IS THE PRODUCT?!

I need to understand where the product goes after I add it, and how the program stores and displays it.

I also need to slow down and follow the code step by step instead of changing several things at once.

---

## Starting the Program

### Issue 1: `IndexOutOfRangeException`

**Error message:**

`System.IndexOutOfRangeException: Index was outside the bounds of the array.`

**Location:** `ShoppingList.cs`, line 90.

**What it means:** The program tried to access an array position that doesn't exist.

**Code:**

```csharp
items.Add(new Item(parts[1], int.Parse(parts[3])));
```

**My initial thought:** We changed the index from `0` to `3` because we thought we had three parts (three products).

**What I need to understand:** An index is a position, not the number of products. Index `0` is the first element, `1` is the second, `2` is the third, and `3` is the fourth.

Changing the index to `3` only works if the array actually contains at least four elements.

### Issue 2: Empty Lines in the Saved File

I noticed that the saved file could contain an empty line or whitespace.

We added this check:

```csharp
if (string.IsNullOrWhiteSpace(line))
{
    continue;
}
```

**What it does:** It skips empty lines and lines containing only whitespace, so the program doesn't try to process them as products.

### Issue 3: Error Pointing to `Program.cs`, Line 2

**Error location:**

`Program.<Main>$(String[] args) in Program.cs:line 2`

After making the changes, the program could start running again.

**My observation:** The list seemed to disappear, and I could run the code.

**What I need to investigate:** Was the list actually empty, or was it simply not being loaded or displayed correctly?

---

## Lessons Learned So Far

### 1. Understanding Error Messages

- Read the entire error message and identify the file and line number.
- Identify the exception type and what it means.

### 2. Understanding Arrays

- An array index represents a position, not a number of products.
- Check the number of elements before accessing an array index.

### 3. Handling Saved Data

- Skip empty lines when reading saved data.
- Verify whether products are loaded and displayed correctly.

### 4. Debugging Approach

- Test one change at a time.
- Distinguish between fixing a crash and fixing the underlying problem.
- Verify whether a product is added, saved, loaded, and displayed correctly.
- Slow down and understand why a change works instead of just making the error disappear.










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