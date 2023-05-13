namespace NewBee.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Flashcard> Cards { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Deck()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }
    }
}
