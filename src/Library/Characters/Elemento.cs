namespace Library;

public class Elemento: IElemento
{
    public string Name {get; private set;}
    public int Attack {get; private set;}
    public int Armor {get; private set;}

    public Elemento (string nombre, int ataque, int armadura)
    {
        this.Name = nombre;
        this.Attack = ataque;
        this.Armor = armadura;
    }
}