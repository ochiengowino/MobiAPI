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
//using ServiceReference3;
using ServiceReference4;
using System.Text.Json.Nodes;
using System.Text;
using System.Xml.Serialization;

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
       // private readonly IHttpClientFactory _clientFactory; // HttpClient factory for making HTTP requests

        public ApiTransactionsController(NavContext navcontext )
        //public ApiTransactionsController(ApiContext context, NavContext navcontext, IHttpClientFactory clientFactory)
        {

            _navcontext = navcontext;
            // _context = context;
            //_clientFactory = clientFactory;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://OchiengOwino:3332/CapitalSaccoInstance/");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string username = "ochiengowinoben";
            string password = "D3271n3d4gr87n322";
            string base64Credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            
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
          /*  webService.ClientCredentials.UserName.UserName = "";
            webService.ClientCredentials.UserName.Password = "";*/

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
        [HttpGet("/GetNavFromDB")]
        public JsonResult GetNavFromDB()
        {
             
            var result = _navcontext.NavTransactions.ToList();

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

                        _navcontext.SaveChanges();
                        var successState = new
                        {
                            MessageCode = "200",
                            Message = "Successfully received data"
                        };
                        return Ok(successState);
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

        [HttpPost("sendToNavision")]
        public async Task<IActionResult> SendToNavision()
        {
            try
            {
                // Retrieve data from the database
                var entries = _navcontext.NavTransactions.ToList(); // Fetch all entries; adjust as needed

                if (entries != null)
                {
                    // Prepare data in the required format for Navision web service
                    //var navisionData = PrepareDataForNavision(entries);
                   // var navisionData = JsonConvert.SerializeObject(entries);
                    // Convert the data to XML format
                    var navisionData = SerializeToXml(entries);
                    // Make a POST request to the Navision web service
                    var navisionApiUrl = "http://OchiengOwino:3333/CapitalSaccoInstance/ODataV4/Company('CAPITAL%20SACCO')/LoanApplicationList"; // Replace with actual Navision API endpoint
                   // _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                    var content = new StringContent(navisionData);
                    
                    HttpResponseMessage response = await _httpClient.PostAsync(navisionApiUrl, content);
                    //var response = await client.PostAsync(navisionApiUrl, content);
                    return Ok(response);
                   /* if (response.IsSuccessStatusCode)
                    {
                        return Ok("Data sent to Navision successfully.");
                    }

                    return StatusCode((int)response.StatusCode, "Failed to send data to Navision.");*/
                }

                return BadRequest("No data found in the database.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }

        }
        private string SerializeToXml<T>(T data)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using (StringWriter stringWriter = new StringWriter())
            {
                xmlSerializer.Serialize(stringWriter, data);
                return stringWriter.ToString();
            }
        }

        [HttpPost("postToNavision")]
        public async Task<IActionResult> PostDataToNavision()
        {
            try
            {
                // Retrieve data from your database
                var dataFromDB = await _navcontext.NavTransactions.ToListAsync(); 

                // Prepare the data to be sent to Navision
                // Modify this section as per your data and requirements
                var navisionData = new List<object>();
                
                foreach (var item in dataFromDB)
                {
                    var navisionItems = new
                    {
                        Loan_No = item.Loan_No,
                        Application_Date = item.Application_Date,
                        Loan_Product_Type = item.Loan_Product_Type,
                        Loan_Product_Type_Name = item.Loan_Product_Type_Name,
                        Member_No = item.Member_No,
                        Member_Name = item.Member_Name,
                        Requested_Amount = item.Requested_Amount,
                        Approved_Amount = item.Approved_Amount,
                        Interest = item.Interest,
                        Status = item.Status,
                        RecID = item.RecID,
                        Captured_By = item.Captured_By,
                        Global_Dimension_1_Code = item.Global_Dimension_1_Code,
                        Global_Dimension_2_Code = item.Global_Dimension_2_Code,
                        Staff_No = item.Staff_No
                      
                    };
                    navisionData.Add(navisionItems);
                }
                
                
                var jsonNavisionData = JsonConvert.SerializeObject(navisionData);
               //var navisionData2 = SerializeToXml(jsonNavisionData);
                var content = new StringContent(jsonNavisionData, Encoding.UTF8, "application/json");

                
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://OchiengOwino:3332/CapitalSaccoInstance/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string username = "ochiengowinoben";
                string password = "D3271n3d4gr87n322";
                string base64Credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64Credentials);


                var response = await client.PostAsync("http://OchiengOwino:3333/CapitalSaccoInstance/ODataV4/Company('CAPITAL%20SACCO')/LoanApplicationList", content); 
                return Ok(response);
               /* if (response.IsSuccessStatusCode)
                {
                    return Ok("Data successfully posted to Navision");
                }
                else
                {
                    return BadRequest("Failed to post data to Navision");
                }*/
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        // Method to prepare data for Navision in the required format
        private string PrepareDataForNavision(List<NavTransactions> entries)
        {
            // Convert 'entries' to the format expected by the Navision web service
            // Format the data according to Navision's API requirements and return as JSON
            // Example: Convert 'entries' to a JSON string
            var navisionData = JsonConvert.SerializeObject(entries);

            return navisionData;
        }

    }
}