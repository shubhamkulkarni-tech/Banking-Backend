namespace Banking_Backend.Models
{
    public class Beneficiary
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public string? BeneficiaryAccountNumber { get; set; }
        public string? BeneficiaryName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
