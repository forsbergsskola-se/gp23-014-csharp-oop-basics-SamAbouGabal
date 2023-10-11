namespace P4_1Replacing;

public class Plant
{
    public bool isGrown;

    public void PrintStatus()
    {
        if (this.isGrown)
        {
            Console.WriteLine("Plant is a tree.");
        }

        else
        {
            Console.WriteLine("Plant is a seed");
        }
    }

    public void Grow()
    {
        if (isGrown)
        {
            Console.WriteLine("Plant has already grown");
            return;
        }

        Console.WriteLine("Plant is growing.");
        this.isGrown = true;
        
    }
}