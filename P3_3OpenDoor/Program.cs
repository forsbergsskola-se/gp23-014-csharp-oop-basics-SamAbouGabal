using P3_3OpenDoor;

House blueHouse = new House();
House redHouse = new House();

Console.WriteLine(blueHouse.isDoorOpen);
Console.WriteLine(redHouse.isDoorOpen);

blueHouse.OpenDoor();
Console.WriteLine(blueHouse.isDoorOpen);
Console.WriteLine(redHouse.isDoorOpen);

redHouse.OpenDoor();
Console.WriteLine(blueHouse.isDoorOpen);
Console.WriteLine(redHouse.isDoorOpen);