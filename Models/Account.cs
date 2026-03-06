namespace Banking_Backend.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public User? User { get; set; }

        public long AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string? status { get; set; }
        public int IsOverdraftAllowed { get; set; }
        public decimal OverdraftLimit { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<Transaction>? SentTransactions { get; set; }
        public ICollection<Transaction>? ReceivedTransactions { get; set; }

    }
}
