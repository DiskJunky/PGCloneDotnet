namespace AutoQuest.Engine.Models;

/// <summary>
/// This holds details about the essence or inherent nature of a person,
/// creature, monster, or thing.
/// </summary>
public class Quiddity
{
    #region Constructors

    /// <summary>
    /// The default constructor, used to instantiate the object.
    /// </summary>
    /// <param name="entity">The type of game entity this is.</param>
    public Quiddity(GameEntity entity)
    {
        Entity = entity;
        Name = string.Empty;
    }

    /// <summary>
    /// The main
    /// </summary>
    /// <param name="entity">The type of game entity this is.</param>
    /// <param name="name">The name of the quiddity.</param>
    /// <param name="health">The base health of the quiddity.</param>
    public Quiddity(GameEntity entity,
                    string name, 
                    int health = 10) 
        : this(entity)
    {
        Name = name;
        Health = health;
    }

    /// <summary>
    /// The main
    /// </summary>
    /// <param name="entity">The type of game entity this is.</param>
    /// <param name="health">The base health of the quiddity.</param>
    public Quiddity(GameEntity entity,
                    int health = 10) 
        : this(entity, "Etnad", health) { }
    #endregion

    #region Fields
    private int _health;
    #endregion

    #region Properties
    /// <summary>
    /// Gets or sets the name of the quiddity.
    /// </summary>
    public string Name { get; protected set; }

    /// <summary>
    /// Gets or sets the experience of the quiddity.
    /// </summary>
    public int Experience { get; internal set; } = 0;
    
    /// <summary>
    /// Gets or sets the state of the quiddity.
    /// </summary>
    public QuiddityState State { get; protected set; } = QuiddityState.Alive;

    /// <summary>
    /// Gets or sets the health of the quiddity.
    /// </summary>
    public int Health
    {
        get => _health;
        set
        {
            _health = value;
            if (_health <= 0)
            {
                State = QuiddityState.Dead;
                _health = 0;
            }
        }
    }
    
    /// <summary>
    /// Gets or sets the type of game entity this is.
    /// </summary>
    public GameEntity Entity { get; protected set; }
    #endregion
}