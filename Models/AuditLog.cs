namespace Banking_Backend.Models
{
    public class AuditLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; } 
        public string? Action { get; set;}
        public string? Ipaddress { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
