namespace HomeWork;



public class Knight : Unit
{
    public int swordLength { get; set; }
    public override void Attack()
    {
        Console.WriteLine($"Knight attack with sword, and applies damage:-{swordLength} hp");
    }
}