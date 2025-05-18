using Library;
namespace Ucu.Poo.RoleplayGame;

public class Wizard : IPersonaje
{
    private int health = 100;

    public Wizard(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public SpellsBook SpellsBook { get; set; }

    //Items nuevos
    public Staff Staff { get; set; }
    public Shield Shield { get; set; } = null;
    public Helmet Helmet { get; set; } = null;
    public Axe Axe { get; set; } = null;
    public Bow Bow { get; set; } = null;
    public int AttackValue
    {
        get
        {
            return SpellsBook.AttackValue + Staff.AttackValue;
        }
    }

    public int DefenseValue
    {
        get
        {
            return SpellsBook.DefenseValue + Staff.DefenseValue;
        }
    }

    public int InitialHealth
    {
        get
        {
            return this.InitialHealth;
        }
        private set
        {
            this.InitialHealth = value > 0 ? 0 : value;
        }
    }

    public int Health
    {
        get
        {
            return this.health;
        }
        private set
        {
            this.health = value < 0 ? 0 : value;
        }
    }

    int IPersonaje.Health { get => Health; set => Health = value; }
    int IPersonaje.InitialHealth { get => InitialHealth; set => InitialHealth = value; }
    public int AttackPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int IPersonaje.AttackValue { get => AttackValue; set => throw new NotImplementedException(); }

    public void ReceiveAttack(int power)
    {
        if (this.DefenseValue < power)
        {
            this.Health -= power - this.DefenseValue;
        }
    }

    public void Cure()
    {
        this.Health = 100;
    }

    public int GetTotalArmor()
    {
        throw new NotImplementedException();
    }

    public int GetTotalAtack()
    {
        throw new NotImplementedException();
    }

    public string HealPj()
    {
        throw new NotImplementedException();
    }

    public void ShowElements()
    {
        throw new NotImplementedException();
    }

    public void Attack(IPersonaje personaje)
    {
        throw new NotImplementedException();
    }
}
