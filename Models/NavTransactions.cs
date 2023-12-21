using System.ComponentModel.DataAnnotations;

namespace MobiAPI.Models
{
    public class NavTransactions
    {

        //public string ODataEtag { get; set; }
        [Key]
            
        public int Id { get; set; }
        public string Loan_No { get; set; }
        public DateTime Application_Date { get; set; }
        public string Loan_Product_Type { get; set; }
        public string Loan_Product_Type_Name { get; set; }
        public string Member_No { get; set; }
        public string Member_Name { get; set; }
        public decimal Requested_Amount { get; set; }
        public decimal Approved_Amount { get; set; }
        public int Interest { get; set; }
        public string Status { get; set; }
        public string RecID { get; set; }
        public string Captured_By { get; set; }
        public string Global_Dimension_1_Code { get; set; }
        public string Global_Dimension_2_Code { get; set; }
        public string Staff_No { get; set; }
        
    }
}
