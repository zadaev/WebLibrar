namespace WebLibrary.Data.Models
{
    public class Reader
    {
        public Guid Id { get; set; } = Guid.NewGuid(); 
        public string? FullName { get; set; } // Полная имя
        public DateTime Bithday { get; set; } // Дата рождения 
        public string? PhoneNumber { get; set; } // Номер телефона
        public string? RegisteredAddress { get; set; } // Адрес по прописке
        public string? AddressOfResidence { get; set; } // Адрес проживания 
        
        public List<BookRent> BooksRent { get; set; } = null!;
    }
}
