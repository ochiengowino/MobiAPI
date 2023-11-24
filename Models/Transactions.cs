//using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace MobiAPI.Models
{
    public class Transactions
    {
        [Required]
        public int Id { get; set; }
        public string AcctNo { get; set; }
        public decimal Amount { get; set; }
        public decimal BookedBalance { get; set; }
        public decimal ClearedBalance { get; set;}
        public string Currency {  get; set; }
        public string CustMemoLine1 { get; set; }
        public string EventType { get; set; }
        public string ExchangeRate {  get; set; }
        public string Narration { get; set; }
        public string? Narration2 {  get; set; }
        public string? Narration3 { get; set; }
        public string PaymentRef {  get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionId { get; set; }
    }

    public class MsgResults
    {
        public bool Success { get; set; }
        public bool Failure { get; set; }
        public string Message { get; set; }

    }
}
