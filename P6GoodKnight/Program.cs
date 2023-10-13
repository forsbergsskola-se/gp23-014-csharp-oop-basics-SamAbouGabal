using P6GoodKnight;

Knight attacker = new Knight();
Knight defender = new Knight();
defender.Shield = new Shield();
attacker.Sword = null;
attacker.Attack(defender);
defender.GetHit(attacker.Sword);
attacker.Sword = new Sword();
Console.WriteLine("Equipping a sword...");
attacker.Attack(defender);
defender.GetHit(attacker.Sword);
attacker.Attack(defender);
defender.GetHit(attacker.Sword);