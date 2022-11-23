namespace TCG_Organizer.Models;

public class DeckDetail
{

    public int Id { get; set; }

    public int DeckId { get; set; }
    public virtual Deck? Deck { get; set; }

    public int CardId { get; set; }
    public virtual Card? Card { get; set; }

    public int Quantity { get; set; } = 0;

}
