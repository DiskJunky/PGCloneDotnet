using PQCloneDotnet.Engine.Models;

namespace  PQCloneDotNet.Engine;

/// <summary>
/// This holds the current application's configuration state.
/// </summary>
public class Config
{
    /// <summary>
    /// Default constructor.
    /// </summary>
    // public Config()
    // {
    // }

    public List<Modifier> OffensiveModifiers { get; protected set; } = new();

    public List<Modifier> DefensiveModifiers { get; protected set; } = new();

    public List<string> Spells { get; protected set; } = new();

    /// <summary>
    /// This populates the <see cref="Config"/> instance with the defaults.
    /// </summary>
    public void InitializeDefaults()
    {
        Spells =
        [            
            "Slime Finger",
            "Rabbit Punch",
            "Hastiness",
            "Good Move",
            "Sadness",
            "Seasick",
            "Shoelaces",
            "Inoculate",
            "Cone of Annoyance",
            "Magnetic Orb",
            "Invisible Hands",
            "Revolting Cloud",
            "Aqueous Humor",
            "Spectral Miasma",
            "Clever Fellow",
            "Lockjaw",
            "History Lesson",
            "Hydrophobia",
            "Big Sister",
            "Cone of Paste",
            "Mulligan",
            "Nestor's Bright Idea",
            "Holy Batpole",
            "Tumor (Benign)",
            "Braingate",
            "Nonplus",
            "Animate Nightstand",
            "Eye of the Troglodyte",
            "Curse Name",
            "Dropsy",
            "Vitreous Humor",
            "Roger's Grand Illusion",
            "Covet",
            "Astral Miasma",
            "Spectral Oyster",
            "Acrid Hands",
            "Angioplasty",
            "Grognor's Big Day Off",
            "Tumor (Malignant)",
            "Animate Tunic",
            "Ursine Armor",
            "Holy Roller",
            "Tonsillectomy",
            "Curse Family",
            "Infinite Confusion"            
        ];

        OffensiveModifiers = [
            new Modifier("Polished", 1),
            new Modifier("Serrated", 1),
            new Modifier("Heavy", 1),
            new Modifier("Pronged", 2),
            new Modifier("Steely", 2),
            new Modifier("Vicious", 3),
            new Modifier("Venomed", 4),
            new Modifier("Stabbity", 4),
            new Modifier("Dancing", 5),
            new Modifier("Invisible", 6),
            new Modifier("Vorpal", 7)
        ];

        DefensiveModifiers =
        [
            new Modifier("Studded", 1),
            new Modifier("Banded", 2),
            new Modifier("Gilded", 2),
            new Modifier("Festooned", 3),
            new Modifier("Holy", 4),
            new Modifier("Cambric", 1),
            new Modifier("Fine", 4),
            new Modifier("Impressive", 5),
            new Modifier("Custom", 3),
        ];
    }
}