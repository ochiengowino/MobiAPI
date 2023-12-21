using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Crm.Sdk;
using Microsoft.Crm.Sdk.Messages;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
//using System.Net.Http.Formatting;
using MobiAPI.Context;
using MobiAPI.Models;

using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Threading.Tasks;
//using ServiceReference1;
using ServiceReference2;
using ServiceReference3;
using System.Text.Json.Nodes;

namespace MobiAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    [ApiController]
    public class ApiTransactionsController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly NavContext _navcontext;
        private readonly HttpClient _httpClient;

        public ApiTransactionsController(NavContext navcontext)
          //public ApiTransactionsController(ApiContext context, NavContext navcontext)
        {

            _navcontext = navcontext;
           // _context = context;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://OchiengOwino:3332/CapitalSaccoInstance/");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Set Basic Authentication Header (replace 'username' and 'password' with your NAV credentials)
            string username = "ochiengowinoben";
            string password = "D3271n3d4gr87n322";
            string base64Credentials = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{username}:{password}"));
            // _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64Credentials);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64Credentials);
        }

     

        public class LoanApplication
        {
            //public string ODataContext { get; set; }
            public List<ValueItem> Value { get; set; }
        }

        public class ValueItem
        {
            //public string ODataEtag { get; set; }
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
        // Create
        [HttpPost]
        public IActionResult Create(Transactions customerTransactions)
        {
            var dataExists = _context.CustomerTransactions.Where(x => x.AcctNo.Contains(customerTransactions.AcctNo)).FirstOrDefault();
            if (dataExists == null)
            {
                _context.CustomerTransactions.Add(customerTransactions);

                _context.SaveChanges();

                var successState = new
                {
                    MessageCode = "200",
                    Message = "Successfully received data"
                };

                return new JsonResult(Ok(successState));
            }
            else
            {
                var failureState = new
                {
                    MessageCode = "404",
                    Message = "No data received"
                };

                return new JsonResult(NotFound(failureState));
            }
        }

        // GET Endpoint
        [HttpGet]
        public IActionResult Get() 
        {
            
            // var result = _context.CustomerTransactions.Find(id);

            //MsaccoMobiAPI result = new MsaccoMobiAPI();
            LoanApplicationList webService = new LoanApplicationList();
        

            // Error/Failure - 400
            if (webService == null)
            {
                return new JsonResult(NotFound());
            }
        
            //webService.Application_Date = DateTime.Parse("11/29/2021");
           

            // Ok/Success - 200
            return new JsonResult(Ok(webService));
        }

        // Fetch All
        [HttpGet("/GetAll")]
        public JsonResult GetAll()
        {
             
            var result = _context.CustomerTransactions.ToList();

            return new JsonResult(Ok(result));
        }

        [HttpGet("navisiondata")]
        public async Task<IActionResult> GetNavisionData()
        {
            try
            {
                //HttpResponseMessage response = await _httpClient.GetAsync("http://OchiengOwino:3332/CapitalSaccoInstance/WS/CAPITAL%20SACCO/Page/LoanApplicationList");
                HttpResponseMessage response = await _httpClient.GetAsync("http://OchiengOwino:3333/CapitalSaccoInstance/ODataV4/Company('CAPITAL%20SACCO')/LoanApplicationList");
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();

                    /*string jsonString = Newtonsoft.Json.JsonSerializer.Serialize(result);
                   return (IActionResult)JsonConvert.DeserializeObject<object>(jsonString);*/
                    //return new JsonResult(Ok(jsonString)); // Returning response data
                   // var jsonString = JsonConvert.SerializeObject(result);

                    //var jsonString = JsonConvert.DeserializeObject<LoanApplication>(result);
                    LoanApplication loanApplication = JsonConvert.DeserializeObject<LoanApplication>(result);
                    return Ok(loanApplication);
                }
                else
                {
                    var failureState = new
                    {
                        MessageCode = "404",
                        Message = "No data received"
                    };

                    return new JsonResult(NotFound(failureState));
                    //return StatusCode((int)response.StatusCode, $"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Exception: {ex.Message}");
            }
        }

        [HttpGet]
       // public async Task<IActionResult> GetandStoreNavData(NavTransactions navTransactions)
        public async Task<IActionResult> GetandStoreNavData()
        {

            try
            {

                HttpResponseMessage response = await _httpClient.GetAsync("http://OchiengOwino:3333/CapitalSaccoInstance/ODataV4/Company('CAPITAL%20SACCO')/LoanApplicationList");
              /*  if (response.IsSuccessStatusCode)
                {*/
                    string result = await response.Content.ReadAsStringAsync();

                    LoanApplication loanApplication = JsonConvert.DeserializeObject<LoanApplication>(result);
                    //return Ok(loanApplication);
                    if (loanApplication != null && loanApplication.Value != null && loanApplication.Value.Any())
                    {
                        // Extract specific entries and save to the database
                        foreach (var entry in loanApplication.Value)
                        {
                            // Assuming mapping between JSON fields and Entry model properties
                            var newEntry = new NavTransactions
                            {
                                //Id = entry.Id,
                                Loan_No = entry.Loan_No,
                                Application_Date = entry.Application_Date,
                                Loan_Product_Type = entry.Loan_Product_Type,
                                Loan_Product_Type_Name = entry.Loan_Product_Type_Name,
                                Member_No = entry.Member_No,
                                Member_Name = entry.Member_Name,
                                Requested_Amount = entry.Requested_Amount,
                                Approved_Amount = entry.Approved_Amount,
                                Interest = entry.Interest,
                                Status = entry.Status,
                                RecID = entry.RecID,
                                Captured_By = entry.Captured_By,
                                Global_Dimension_1_Code = entry.Global_Dimension_1_Code,
                                Global_Dimension_2_Code = entry.Global_Dimension_2_Code,
                                Staff_No = entry.Staff_No
                            };

                            _navcontext.NavTransactions.Add(newEntry);
                        }

                        _context.SaveChanges();
                        return Ok("Entries saved successfully.");
                    //}
                }
                else
                {
                    var failureState = new
                    {
                        MessageCode = "404",
                        Message = "No data received"
                    };

                    return new JsonResult(NotFound(failureState));
                  
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Exception: {ex.Message}");
            }

        }

    }
}
