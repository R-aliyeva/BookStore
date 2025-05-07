namespace BookStore.Domain.Entities
{
    public class Store:Entity
    {
        public int BookId {  get; set; }
        public Book? Book { get; set; }
        public int Amount {  get; set; }
    }
}
