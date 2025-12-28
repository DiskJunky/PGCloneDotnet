namespace AutoQuest.Engine.Models;

/// <summary>
/// This holds details about a combatant that a <see cref="Player"/> may have to fight.
/// </summary>
public class Combatant : Quiddity
{
    public Combatant(string name, int health = 10) 
        : base(GameEntity.CombatEncounter, name, health)
    {
    }

    public Combatant(GameEntity entity, int health = 10) : base(entity, health)
    {
    }
}