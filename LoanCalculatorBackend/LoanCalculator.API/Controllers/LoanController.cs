using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LoanCalculator.API.Controllers
{
    [Route("api/[controller]")]
    public class LoanController : BaseApiController
    {
        [HttpGet]
        public async Task<object> CalculateLvr(double propertyValue, double amount)
        {
            return await GetDataWithMessage(async () =>
            {
                var result = propertyValue != 0 && amount != 0 ? (amount / propertyValue) * 100 : 0;
                return Response(result, string.Empty);
            });
        }
    }
}