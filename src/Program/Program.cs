
using Library;
using Ucu.Poo.RoleplayGame;

SpellsBook book = new SpellsBook();
book.Spells = new Spell[]{ new Spell() };

IPersonaje  gandalf = new Wizard("Gandalf"); // Wizard
gandalf.Staff = new Staff();
gandalf.SpellsBook = book;

IPersonaje gimli = new Dwarf("Gimli"); // Dwarf

gimli.Axe = new Axe(10, 200, 30);
gimli.Helmet = new Helmet();
gimli.Shield = new Shield();

IPersonaje thorin = new Dwarf("Thorin"); // Enano
thorin.Axe = new Axe(8, 180, 50);
thorin.Helmet = new Helmet();
thorin.Shield = new Shield();


IPersonaje archer = new Archer("Archer"); // Archer
archer.Bow = new Bow();
archer.Helmet = new Helmet();
archer.Shield = new Shield();


Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

gimli.ReceiveAttack(gandalf.AttackValue);

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

gimli.Cure();

Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
