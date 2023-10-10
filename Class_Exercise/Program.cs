using Class_Exercise;

Player[] players = new Player[3];
for (var i = 0; i < players.Length; i++)
{
    players[i] = new Player();
}
players[0].Health = 100;
players[0].Name = "Marc";

players[1].Health = 12;
players[1].Name = "Alex";

players[2].Health = 5;
players[2].Name = "Felix";


House[] houses = new House[2];
for (var i = 0; i < houses.Length; i++)
{
    houses[i] = new House();
}
houses[0].stories = 2;
houses[0].color = "Blue";

houses[1].stories = 3;
houses[1].color = "Yellow";

Balls[] ball = new Balls[4];
for (var i = 0; i < ball.Length; i++)
{
    ball[i] = new Balls();
}

ball[0].Color = "Green";
ball[0].Size = "Huge";

ball[1].Color = "Red";
ball[1].Size = "Big";

ball[2].Color = "Yellow";
ball[2].Size = "Tiny";

ball[3].Color = "Blue";
ball[3].Size = "Small";
