using Microsoft.AspNetCore.Mvc;
using System.Net;

//using System.Net.Http.Formatting;
using System.Net.Http;
using MobiAPI.Context;
using MobiAPI.Models;
using Msacco_Applications;
using System.Web.Services;
using System.Web.Services.Protocols;

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
            MsaccoMobiAPI msaccoMobiAPI = new MsaccoMobiAPI();
           
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
        public IActionResult Get(int id) 
        {

            // var result = _context.CustomerTransactions.Find(id);
            MsaccoMobiAPI client = new MsaccoMobiAPI();
         

            var result = client.Find(id);

            // Error/Failure - 400
            if (result == null)
            {
                return new JsonResult(NotFound());
            }

            // Ok/Success - 200
            return new JsonResult(Ok(result));
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
