
namespace P6GoodKnight;

public class Knight
{
    public Shield Shield;
    public  Sword Sword;
    
    public void GetHit(Sword Sword)
    {
        if (this.Shield != null) // If I have a Shield
        {
            if (Sword == null) // And they have no Sword
            {
                Console.WriteLine("Knights Shield fends off the strike.");
            }
            else // If they do have a Sword
            {
                Console.WriteLine("Knights Shield was pierced by the Sword.");
                Shield = null;
            }
        }
        else //If i dont have a shield
        {
            Console.WriteLine("The Knight has no Shield and is wounded.");
        }
    }

    public void Attack(Knight target)
    {
        if (this.Sword == null)
        {
            Console.WriteLine("Knight attacks Knight With Bare Hands");
        }
        else
        {
            Console.WriteLine($"Knight attacks Knight With a Sword");
        }
    }
}



