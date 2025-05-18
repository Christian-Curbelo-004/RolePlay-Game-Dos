using Library;

namespace Ucu.Poo.RoleplayGame;

public class Dwarf : IPersonaje
{
    private int health = 100;
    private int initialHealth = 100;

    public Dwarf(string name)
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

    public Axe Axe { get; set; }

    public Shield Shield { get; set; }

    public Helmet Helmet { get; set; }

    // No tiene sentido para Dwarf, pero hay que implementarlas por la interfaz
    public Staff Staff { get; set; } = null;

    public SpellsBook SpellsBook { get; set; } = null;

    public int AttackPoints { get; set; } = 0;

    // NUEVO: puede usar el daño del hacha como valor de ataque
    public int AttackValue
    {
        get => Axe != null ? Axe.Damage : 0;
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
        return Axe != null ? Axe.Damage : 0;
    }

    public string HealPj()
    {
        this.Cure();
        return $"{Name} fue curado.";
    }

    public void ShowElements()
    {
        Console.WriteLine($"{Name} tiene:");
        if (Axe != null) Console.WriteLine($"- Hacha: {Axe.Damage} daño");
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
