public class Monster
{
    public int Health;

    public void Attack(Player target)
    {
        target.Health--;
        Console.WriteLine($"The monster attacks you. You have {target.Health} Health.");
    }
}