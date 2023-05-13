namespace NewBee.Models
{
    public class Deck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Flashcard> Cards { get; set; }

        public Deck()
        {

        }
    }
}
