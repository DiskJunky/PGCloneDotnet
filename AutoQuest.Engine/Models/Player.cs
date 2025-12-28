namespace AutoQuest.Engine.Models;

/// <summary>
/// This holds details about a player in the system.
/// </summary>
public class Player : Quiddity
{
    /// <summary>
    /// The main constructor, used to create a Player instance.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="health">The health of the player.</param>
    public Player(string name = "Etnad", 
                  int health = 10) 
        : base(GameEntity.Player, name, health)
    {
    }
    
    /// <summary>
    /// Gets or sets the game mode that the player is currently in.
    /// </summary>
    public PlayerMode Mode { get; internal set; }
}