using Microsoft.AspNetCore.Mvc;
using BussinessLayer;

namespace API_Layer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GlobalController : ControllerBase
    {
        //api/Global/TotalBalanceAtSystem?active=true

        [HttpGet("TotalBalanceAtSystem", Name = "GetTotalBalanceAtSystem")]
        public  IActionResult GetTotalBalance([FromQuery] bool active)
        {
            try
            {
                decimal totalBalance = Global_BL.TotalBalanceAtSystem(active);
                return Ok(totalBalance);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error: {ex.Message}");
            }
        }
    }
}
