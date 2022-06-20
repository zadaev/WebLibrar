namespace WebLibrary.Data.Models
{
    public class Librarian
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Login { get; set; } // Логин
        public string? Password { get; set; } // Пароль

    }
}
