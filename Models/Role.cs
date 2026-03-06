namespace Banking_Backend.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string? RoleName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now; 

        public ICollection<User>? Users { get; set; }
    }
}
