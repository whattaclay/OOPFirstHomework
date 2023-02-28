using HomeWork;

namespace HomeWork;
public class Archer : Unit
{
    public int archeryDistance { get; set; }
    public override void Attack() 
    {
        Console.WriteLine($"Archer archery with bow and arrows, with archery distance equal:{archeryDistance}м.");
    }
}
