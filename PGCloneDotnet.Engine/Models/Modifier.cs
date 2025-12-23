namespace PGCloneDotnet.Engine.Models;

public class Modifier
{
    public Modifier() { }

    public Modifier(string name, int value) : this()
    {
        Name = name;
        Value = value;
    }

    public string Name { get; protected set; } = null!;

    public int Value { get; protected set; }
}
