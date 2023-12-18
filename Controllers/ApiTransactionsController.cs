using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Crm.Sdk;
using Microsoft.Crm.Sdk.Messages;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
//using System.Net.Http.Formatting;
using MobiAPI.Context;
using MobiAPI.Models;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
//using ServiceReference1;
using ServiceReference2;
using ServiceReference3;

namespace MobiAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [Produces("application/json")]
    [ApiController]
    public class ApiTransactionsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ApiTransactionsController(ApiContext context)
        {
            //MsaccoMobiAPI msaccoMobiAPI = new MsaccoMobiAPI();
            
            _context = context;
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
           /* NetworkCredential cred = new NetworkCredential(Globals.WebServiceUsername, Globals.WebServicePassword, Globals.WebServiceDomain);
            webService.Timeout = Globals.Timeout;
            webService.Url = Globals.Url;
            webService.UseDefaultCredentials = false; // <-----
            webService.Credentials = cred;*/

            // Error/Failure - 400
            if (webService == null)
            {
                return new JsonResult(NotFound());
            }
            webService.Application_Date = DateTime.Parse("11/29/2021");

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
        
    }
}
