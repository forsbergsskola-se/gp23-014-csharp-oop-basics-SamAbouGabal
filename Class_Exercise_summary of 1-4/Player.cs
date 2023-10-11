public class Player
{
    public int Health;

    public void Attack(Monster target)
    {
        target.Health--;
        Console.WriteLine($"You attack the Monster. It has {target.Health} Health.");
    }

    public void Heal()
    {
        this.Health = 3;
        Console.WriteLine($"You heal yourself. You now have {this.Health} Health");
    }
}