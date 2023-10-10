using P2_2ItemValues;

Item[] itemValue = new Item[3];

for (var i = 0; i < itemValue.Length; i++)
{
    itemValue[i] = new Item();
}
itemValue[0].goldValue = 100;
itemValue[1].goldValue = 200;
itemValue[2].goldValue = 300;
for (var i = 0; i < itemValue.Length; i++)
{
    Console.WriteLine(itemValue[i].goldValue);
}
