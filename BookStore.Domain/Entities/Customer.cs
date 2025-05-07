namespace BookStore.Domain.Entities
{
    public class Customer:Entity
    {
        public  required string Name { get; set; }
        public required string Address { get; set; }
       
    }
}
