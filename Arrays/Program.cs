 
List<string> shoppingList = new List<string>();

shoppingList.Add("Eggs");
shoppingList.Add("Rice");
shoppingList.Add("Milk");
shoppingList.Add("Yogurt");

for (int i = 0; i < shoppingList.Count; i++)
{
    Console.WriteLine(shoppingList[i]);
}

shoppingList.Remove("Milk");
shoppingList.RemoveAt(0);

Console.WriteLine("");

for (int i = 0; i < shoppingList.Count; i++)
{
    Console.WriteLine(shoppingList[i]);
}

Console.ReadKey();
