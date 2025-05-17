namespace Ucu.Poo.RoleplayGame;

public class Axe
{
    public int DefenseValue { get; set; }
    public int Damage { get; set; }
    public int Weight { get; set; }

    public Axe(int defensevalue, int damage, int weight)
    {
        DefenseValue = defensevalue;
        Damage = damage;
        Weight = weight;
    }
}


