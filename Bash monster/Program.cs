using System.Runtime.Intrinsics.Arm;
using BashMonster;
using Raylib_cs;    

Raylib.InitWindow(1000,1000, "Goobie v Snoobie");
Gubbe goobie = new Gubbe();
Monster Snoobie = new();
goobie.hitBox = new Rectangle(10, 10, 100, 100);     


goobie.hp = 100;    
Snoobie.hp = 30;
Snoobie.hp -= 20;

while (Raylib.WindowShouldClose() == false)
{






Raylib.BeginDrawing();
Console.WriteLine($"{goobie.name} has {goobie.hp}");
Console.WriteLine($"{Snoobie.name} has {Snoobie.hp}");
Raylib.DrawRectangleRec(goobie.hitBox,Color.BLUE);
Console.WriteLine("Goobie attacks");
Console.ReadLine();


Raylib.EndDrawing();
}