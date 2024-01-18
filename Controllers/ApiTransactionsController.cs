using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Crm.Sdk;
using Microsoft.Crm.Sdk.Messages;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json; 
using Newtonsoft.Json;
//using System.Net.Http.Formatting;
using MobiAPI.Context;
using MobiAPI.Models;
using System.ServiceModel;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Threading.Tasks;

//using ServiceReference5;
using System.Text.Json.Nodes;
using System.Text;
using System.Xml.Serialization;
using System.ServiceModel.Description;
using Microsoft.AspNetCore.Connections;
using System.Security.Policy;
using Azure.Core;
using ServiceReference8;
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
        private readonly ServiceReference5.LoanApplicationList _navClient;
        private readonly ServiceReference8.LoanApplicationList _client;
        private readonly ServiceReference8.LoanApplicationList_Port _ws;
       // private readonly IHttpClientFactory _clientFactory; // HttpClient factory for making HTTP requests

        public ApiTransactionsController(NavContext navcontext)
        //public ApiTransactionsController(ApiContext context, NavContext navcontext, IHttpClientFactory clientFactory)
        {
            _navcontext = navcontext;
            _client = new ServiceReference8.LoanApplicationList();
            // _context = context;
            //_clientFactory = clientFactory;

            _navClient = new ServiceReference5.LoanApplicationList();
            //_ws = new ServiceReference8.LoanApplicationList_Port();
            // _httpClient = httpClient;
            
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://OchiengOwino:3333/CapitalSaccoInstance/");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.Timeout = TimeSpan.FromMinutes(5);

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
           
            var webService = new ServiceReference5.LoanApplicationList_Fields();
             var list = new ServiceReference5.LoanApplicationList();
            ServiceReference5.Status status = new ServiceReference5.Status();
            ServiceReference5.LoanApplicationList loanApplicationList = new ServiceReference5.LoanApplicationList();  
            ServiceReference5.ReadMultiple readMultiple = new ServiceReference5.ReadMultiple();
            Uri uri = new Uri("http://ochiengowino:3332/CapitalSaccoInstance/WS/CAPITAL%20SACCO/Page/LoanApplicationList");

            //webService.UseDefaultCredentials = true;
           
            var navClient  = new LoanApplicationList();
            NetworkCredential nc = new NetworkCredential("ochiengowinoben", "D3271n3d4gr87n322");
            ClientCredentials cred = new ClientCredentials();
            ServiceReference5.LoanApplicationList ws = new ServiceReference5.LoanApplicationList();
            var name = ws.Member_Name;
            ServiceReference5.Read rd = new ServiceReference5.Read(name);
           string _wsURL = "http://ochiengowino:3332/CapitalSaccoInstance/WS/CAPITAL%20SACCO/Page/LoanApplicationList";
            //Create an instance of the D365BC SOAP WS
            BasicHttpBinding _binding = new BasicHttpBinding();
            //Set https usage
            _binding.Security.Mode = BasicHttpSecurityMode.Transport;
            _binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            using (LoanApplicationList_PortClient _wws = new LoanApplicationList_PortClient(_binding, new EndpointAddress(_wsURL)))
            {
                _wws.ClientCredentials.UserName.UserName = "ochiengowinoben";
                _wws.ClientCredentials.UserName.Password = "D3271n3d4gr87n322";
            }
           // LoanApplicationList_PortClient _wws = new LoanApplicationList_PortClient();
            

            List<LoanApplicationList_Filter> _filters = new List<LoanApplicationList_Filter>();
            ServiceReference7.LocationList ls = new ServiceReference7.LocationList();

           
            return Ok(ls);
            
            /*               
            webService.Credentials = "";
            webService.UseDefaultCredentials = true;*/
            /*  webService.ClientCredentials.UserName.UserName = "";
              webService.ClientCredentials.UserName.Password = "";*/

            // Error/Failure - 400
           /* if (webService == null)
            {
                return new JsonResult(NotFound());
            }*/
   
            //webService.Application_Date = DateTime.Parse("11/29/2021");
           

            // Ok/Success - 200
            //return new JsonResult(Ok(webService));
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
                    var navisionData1 = JsonConvert.SerializeObject(entries);
                    // Convert the data to XML format
                    var navisionData = SerializeToXml(entries);
                    // Make a POST request to the Navision web service
                    var navisionApiUrl = "http://OchiengOwino:3333/CapitalSaccoInstance/ODataV4/Company('CAPITAL%20SACCO')/LoanApplicationList"; // Replace with actual Navision API endpoint
                   // _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                    var content = new StringContent(navisionData1, Encoding.UTF8, "application/json");

                   

                    HttpResponseMessage response = await _httpClient.PostAsync(navisionApiUrl, content);
                    //var response = await client.PostAsync(navisionApiUrl, content);
                    string data = await content.ReadAsStringAsync();
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
                        loan_No = item.Loan_No,
                        application_Date = item.Application_Date,
                        loan_Product_Type = item.Loan_Product_Type,
                        loan_Product_Type_Name = item.Loan_Product_Type_Name,
                        member_No = item.Member_No,
                        member_Name = item.Member_Name,
                        requested_Amount = item.Requested_Amount,
                        approved_Amount = item.Approved_Amount,
                        interest = item.Interest,
                        status = item.Status,
                        recID = item.RecID,
                        captured_By = item.Captured_By,
                        global_Dimension_1_Code = item.Global_Dimension_1_Code,
                        global_Dimension_2_Code = item.Global_Dimension_2_Code,
                        staff_No = item.Staff_No
                      
                    };
                    navisionData.Add(navisionItems);
                }
                
                
                var jsonNavisionData = JsonConvert.SerializeObject(navisionData);
               var navisionData2 = SerializeToXml(jsonNavisionData);
                var content = new StringContent(navisionData2, Encoding.UTF32, "text/xml");


                //var apiUrl = "https://your-navision-api-url";
                var accessToken = "z2/ieggOtbywPL/0u/5Mu/SYqHRpPT8Lb7jGMYlAaTU=";
                //var client = _clientFactory.CreateClient();

                 /*_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                 _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));*/


                 //var client = new HttpClient();
                var client = new HttpRequestMessage(HttpMethod.Post, "http://OchiengOwino:3333/CapitalSaccoInstance/ODataV4/Company('CAPITAL%20SACCO')/LoanApplicationList");
                
                // client.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "z2/ieggOtbywPL/0u/5Mu/SYqHRpPT8Lb7jGMYlAaTU=");
                client.Content = new StringContent(navisionData2, Encoding.UTF32, "text/xml");
               /* client.BaseAddress = new Uri("http://OchiengOwino:3333/CapitalSaccoInstance/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));*/

                string username = "ochiengowinoben";
                string password = "D3271n3d4gr87n322";
                string base64Credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));

                client.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64Credentials);


                //HttpResponseMessage response = await _httpClient.SendAsync(client);
                string data = await content.ReadAsStringAsync();
                // response.EnsureSuccessStatusCode();
                return Ok(data);
                                                       
              
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

        [HttpGet]
        public async Task<IActionResult> GetDataFromNavisionWebService()
        {
            HttpClient httpClient = new HttpClient();
            //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("APIKEY", header);
            var data = await httpClient.GetAsync("http://OchiengOwino:3333/CapitalSaccoInstance/ODataV4/Company('CAPITAL%20SACCO')/LoanApplicationList").Result.Content.ReadAsStringAsync();
            return Ok(data);
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