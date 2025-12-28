using AutoQuest.Engine.Models;

namespace AutoQuest.Engine;

/// <summary>
/// The different states a <see cref="Models.Player"/> can be in.
/// </summary>
public enum QuiddityState
{
    /// <summary>
    /// The state is unknown or unspecified.
    /// </summary>
    None,
    
    /// <summary>
    /// The player is alive.
    /// </summary>
    Alive,
    
    /// <summary>
    /// The player has died.
    /// </summary>
    Dead
}

/// <summary>
/// This enumerates the different game entities that the game has to handle.
/// </summary>
public enum GameEntity
{
    /// <summary>
    /// The entity is unknown or unspecified.
    /// </summary>
    None,
    /// <summary>
    /// A <see cref="Player"/> entity.
    /// </summary>
    Player,
    /// <summary>
    /// A combat encounter <see cref="Quiddity"/>.
    /// </summary>
    CombatEncounter
}

/// <summary>
/// This enumerates the different modes that a player can be in, in the game.
/// </summary>
public enum PlayerMode
{
    /// <summary>
    /// The mode is unknown or unspecified.
    /// </summary>
    None,
    /// <summary>
    /// The player is travelling.
    /// </summary>
    Travel,
    /// <summary>
    /// The player is in combat.
    /// </summary>
    Combat
}