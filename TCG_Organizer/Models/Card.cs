using System.ComponentModel.DataAnnotations;

namespace TCG_Organizer.Models;

public class Card
{
    public int Id { get; set; }

    [StringLength(30)]
    public string Name { get; set; }

    [StringLength(10)]
    public string Color { get; set; }

    [StringLength(30)]
    public string Type { get; set; }

    public int Attack { get; set; }

    public int HitPoints { get; set; }

    [StringLength(30)]
    public string SpecialAbility { get; set; }

    [StringLength(30)]
    public string SetName { get; set; }

    [StringLength(30)]
    public string Rarity { get; set; }

    [StringLength(100)]
    public string Notes { get; set; }






}
