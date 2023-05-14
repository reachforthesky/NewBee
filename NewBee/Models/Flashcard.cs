using System.ComponentModel.DataAnnotations.Schema;

namespace NewBee.Models
{
    public class Flashcard
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        [ForeignKey("Deck")]
        public int? DeckId { get; set; }
        public Deck Deck { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Flashcard()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
                
        }
    }
}
