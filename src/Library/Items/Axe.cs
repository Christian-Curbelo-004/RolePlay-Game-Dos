namespace Ucu.Poo.RoleplayGame;

public class Axe
{
    public int DefenseValue { get; set; }
    public int Damage { get; set; }
    public int Weight { get; set; }

    // Constructor con parámetros
    public Axe(int defensevalue, int damage, int weight)
    {
        DefenseValue = defensevalue;
        Damage = damage;
        Weight = weight;
    }

    // Constructor vacío (por defecto)
    public Axe()
    {
        DefenseValue = 0;
        Damage = 0;
        Weight = 0;
    }
}
