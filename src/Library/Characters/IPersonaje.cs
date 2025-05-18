using Ucu.Poo.RoleplayGame;

namespace Library;

public interface IPersonaje
{
    string Name { get; set; }
    int Health { get; set;} 
    int InitialHealth { get; set; }
    Staff Staff { get; set; }
    int AttackPoints { get; set; }
    int AttackValue { get; set; } // NUEVO
    
    SpellsBook SpellsBook { get; set; }
    Shield Shield { get; set; }
    Helmet Helmet { get; set; }
    Axe Axe { get; set; }
    Bow Bow { get; set; }


    int GetTotalArmor();
    int GetTotalAtack();
    string HealPj();
    void ShowElements();
    void Attack(IPersonaje personaje);
    void ReceiveAttack(int damage);

    void Cure();
}