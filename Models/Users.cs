namespace ChainAppBack.Models
{
    public class Users
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string? CellPhone { get; set; }

        public string? Email { get; set; }

        public string? Name { get; set; }
    }
}