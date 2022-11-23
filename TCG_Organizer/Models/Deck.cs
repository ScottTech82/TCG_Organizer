using System.ComponentModel.DataAnnotations;

namespace TCG_Organizer.Models;

public class Deck
{

    public int Id { get; set; }

    [StringLength(30)]
    public string DeckName { get; set; } = "NEW";

    public int TotalCards { get; set; }

    public int DeckColors { get; set; } //show the available cards in the color scheme selected

    [StringLength(125)]
    public string? Description { get; set; }


    public int UserId { get; set; }
    public virtual User? User { get; set; }

    public ICollection<Card>? Cards { get; set; }
    

}
