namespace HomeWork;



public class Mage : Unit
{
    public int squareDamage { get; set; }
    public override void Attack()
    {
        Console.WriteLine($"Mage use magical staff to attack, and applies square damage equal:{squareDamage} m^2 ");
    }
}
