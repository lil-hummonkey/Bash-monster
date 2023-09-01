using BashMonster;
using Raylib_cs;    

Gubbe Goobie = new();
Monster Snoobie = new();
Goobie.hitBox = new Rectangle(10, 10, 20, 20);     


Goobie.hp = 100;    
Snoobie.hp = 30;
Snoobie.hp -= 20;

while (Raylib.WindowShouldClose() == false)
{







Raylib.BeginDrawing();
Console.WriteLine($"{Goobie.name} has {Goobie.hp}");
Console.WriteLine($"{Snoobie.name} has {Snoobie.hp}");
Raylib.DrawRectangleRec(,Color.BLUE);
Console.WriteLine("Goobie attacks");



Raylib.EndDrawing();
}