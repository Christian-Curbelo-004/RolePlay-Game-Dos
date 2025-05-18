using Library;

namespace Ucu.Poo.RoleplayGame;

public class Archer : IPersonaje
{
    private int health = 100;
    private int initialHealth = 100;

    public Archer(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public int Health
    {
        get => this.health;
        set => this.health = value < 0 ? 0 : value;
    }

    public int InitialHealth
    {
        get => this.initialHealth;
        set => this.initialHealth = value;
    }

    public Bow Bow { get; set; }

    public Shield Shield { get; set; }

    public Helmet Helmet { get; set; }

    public Axe Axe { get; set; } = null;

    public Staff Staff { get; set; } = null;

    public SpellsBook SpellsBook { get; set; } = null;

    public int AttackPoints { get; set; } = 0;

    public int AttackValue
    {
        get => Bow != null ? Bow.AttackValue : 0;
        set => AttackPoints = value;
    }

    public int GetTotalArmor()
    {
        int shieldValue = Shield != null ? Shield.DefenseValue : 0;
        int helmetValue = Helmet != null ? Helmet.DefenseValue : 0;
        return shieldValue + helmetValue;
    }

    public int GetTotalAtack()
    {
        return Bow != null ? Bow.AttackValue : 0;
    }

    public string HealPj()
    {
        this.Cure();
        return $"{Name} fue curado.";
    }

    public void ShowElements()
    {
        Console.WriteLine($"{Name} tiene:");
        if (Bow != null) Console.WriteLine($"- Arco: {Bow.AttackValue} ataque");
        if (Helmet != null) Console.WriteLine($"- Casco: {Helmet.DefenseValue} defensa");
        if (Shield != null) Console.WriteLine($"- Escudo: {Shield.DefenseValue} defensa");
    }

    public void Attack(IPersonaje personaje)
    {
        personaje.ReceiveAttack(this.AttackValue);
    }

    public void ReceiveAttack(int damage)
    {
        int defensa = GetTotalArmor();
        if (defensa < damage)
        {
            this.Health -= damage - defensa;
        }
    }

    public void Cure()
    {
        this.Health = this.InitialHealth;
    }
}
