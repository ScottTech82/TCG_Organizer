using System.ComponentModel.DataAnnotations;

namespace TCG_Organizer.Models;

public class Card
{
    public int Id { get; set; }

    [StringLength(125)]
    public string Name { get; set; }

    [StringLength(50)]
    public string Color { get; set; } //need to allow for multiple colors or even all colors like with Tiamat.

    [StringLength(125)]
    public string Type { get; set; } //creature, instant, artifact, etc.

    public int? Attack { get; set; }

    public int? Block { get; set; }

    [StringLength(125)]
    public string? SpecialAbility { get; set; } //also will have multiple inputs like flying, deathtouch, double strike, etc.

    [StringLength(125)]
    public string SetName { get; set; } 

    [StringLength(50)]
    public string? Rarity { get; set; }

    [StringLength(255)]
    public string? Notes { get; set; }






}
