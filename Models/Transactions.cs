//using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace MobiAPI.Models
{
    public class Transactions
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string AcctNo { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public decimal BookedBalance { get; set; }
        [Required]
        public decimal ClearedBalance { get; set;}
        [Required]
        public string Currency {  get; set; }
        [Required]
        public string CustMemoLine1 { get; set; }
        [Required]
        public string EventType { get; set; }
        [Required]
        public string ExchangeRate {  get; set; }
        [Required]
        public string Narration { get; set; }
        public string? Narration2 {  get; set; }
        public string? Narration3 { get; set; }
        [Required]
        public string PaymentRef {  get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public string TransactionId { get; set; }
    }

    public class MsgResults
    {
        public bool Success { get; set; }
        public bool Failure { get; set; }
        public string Message { get; set; }

    }
}
