using Raylib_cs;
namespace BashMonster;
public class Gubbe
{
    public Rectangle hitBox;
    public string name;
    public float maxHp = 100;
    public float hp;
    public float attack = 80;

    public Gubbe()
    {
        Console.WriteLine("bob");
    }

    public void ResetHP()
    {
        hp = maxHp;
    }
}
