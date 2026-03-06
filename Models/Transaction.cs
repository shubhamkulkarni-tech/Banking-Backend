namespace Banking_Backend.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int FromAccountId { get; set; }
        public Account? FromAccount  { get; set; }
        public int ToAccountId { get; set; }
        public Account? ToAccount { get; set; }
        public decimal Amount { get; set; }
        public string? status { get; set; } 
        public string? TransactionReference { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now; 

    }
}
