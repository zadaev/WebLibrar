namespace WebLibrary.Data.Models
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? VendorCode { get; set; } // Артикул
        public string? Name { get; set; } // Названия 
        public string? Author { get; set; } // Автор
        public string? Img { get; set; } // Адрес фото обложки 
        public DateTime YearOfPublishing { get; set; } // Год издания 
        public string? Grange { get; set; } // Жанр
        public string? Location { get; set; } // Информация о месте размешения кинги
        public string? PublishingHouse { get; set; } // Издательство
        public string? Annotation { get; set; } // Аннотация
        public int QuantityOnBalance { get; set; } // Количество на остатке 
        public int AmountOfEverything { get; set; } // Всего 
    }
}
