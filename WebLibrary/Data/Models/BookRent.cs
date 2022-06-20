namespace WebLibrary.Data.Models
{
    public class BookRent
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DateOfIssue { get; set; } // Дата выдачи
        public DateTime DeliveryDate { get; set; } // Дата сдачи 

        public Book Book { get; set; } = null!;  // Книга
    }
}
