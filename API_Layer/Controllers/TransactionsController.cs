using BussinessLayer;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace API_Layer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        public class TransferRequest
        {
            [Required] public int SenderID { get; set; }
            [Required] public int ReceiverID { get; set; }
            [Required] public int Amount { get; set; }
            public string Description { get; set; } = "";
        }

        public class DepositRequest
        {
            [Required] public int AccountID { get; set; }
            [Required] public string Password { get; set; } = "";
            [Required] public decimal Balance { get; set; }
            public string Description { get; set; } = "";
        }

        public class WithdrawRequest
        {
            [Required] public int AccountID { get; set; }
            [Required] public string Password { get; set; } = "";
            [Required] public decimal Balance { get; set; }
            public string Description { get; set; } = "";
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] int accountId, [FromQuery] bool sent)
        {
            try
            {
                var dt = Transactions_BL.GetAllTranstactions(accountId, sent);

                var transactions = dt.AsEnumerable().Select(row => new
                {
                    SenderID = row.Field<int>("SenderID"),
                    ReceiverID = row.Field<int>("RecieverID"),
                    Amount = row.Field<decimal>("Amount"),
                    CreatedAt = row.Field<DateTime>("CreatedAt")
                }).ToList();

                return Ok(transactions);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST: api/transactions/transfer
        [HttpPost("transfer")]
        public IActionResult Transfer([FromBody] TransferRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                bool result = Transactions_BL.TransferBetweenAccounts(
                    request.SenderID, request.ReceiverID, request.Amount, request.Description);

                return result ? Ok("Transfer successful") : BadRequest("Transfer failed");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // POST: api/transactions/deposit
        [HttpPost("deposit")]
        public IActionResult Deposit([FromBody] DepositRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                bool result = Transactions_BL.DepositIntoAccount(
                    request.AccountID, request.Password, request.Balance, request.Description);

                return result ? Ok("Deposit successful") : BadRequest("Deposit failed");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("withdraw")]
        public IActionResult Withdraw([FromBody] WithdrawRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                bool result = Transactions_BL.WithdrawFromAccount(
                    request.AccountID, request.Password, request.Balance, request.Description);

                return result ? Ok("Withdrawal successful") : BadRequest("Withdrawal failed");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
