Player player = new Player();
player.Health = 3;
Monster monster = new Monster();
monster.Health = 3;
Console.WriteLine($@"You have {player.Health} Health.
You are fighting a monster with {monster.Health} Health.");

while (player.Health > 0)
{
    char userInput = GetUserInput();
    if (userInput == 'A')
    {
        player.Attack(monster);
    }
    else if (userInput == 'H')
    {
        player.Heal();
    }
    //Monsters turn
    if (monster.Health > 0)
    {
        monster.Attack(player);
    }
    else
    {
        monster = new Monster();
        monster.Health = 3;
        Console.WriteLine($"A new monster spawns with {monster.Health} Health");
    }
}

Console.WriteLine("Game Over!");

char GetUserInput()
{
    Console.WriteLine("What do you want to do? [A]ttack or [H]eal?");
    ConsoleKeyInfo key = Console.ReadKey();
    Console.WriteLine();
    return char.ToUpper(key.KeyChar);
}