using P3_2People;

Person[] person = new Person[3];
for (var i = 0; i < person.Length; i++)
{
    person[i] = new Person();
}
for (var i = 0; i < person.Length; i++)
{
    person[i].Name = Console.ReadLine();
}
for (var i = 0; i < person.Length; i++)
{
    person[i].Greeting();
}