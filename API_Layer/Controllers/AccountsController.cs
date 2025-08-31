using BussinessLayer;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace API_Layer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
       
       
        public class CreateAccountRequest
        {
            [Required] public string FullName { get; set; } = "";
            [Required] public string Pin { get; set; } = "";
            [Required, EmailAddress] public string Email { get; set; } = "";
            [Required] public string Password { get; set; } = "";
        }

      

        public class LoginRequest
        {
            [Required] public string Email { get; set; } = "";
            [Required] public string Password { get; set; } = "";
        }

        public class ChangePasswordRequest
        {
            [Required] public string OldPassword { get; set; } = "";
            [Required] public string NewPassword { get; set; } = "";
        }
        public class AccountDTO
        {
            public int AccountId { get; set; }

            
            public string? FullName { get; set; } = "";
            public string? Pin { get; set; } = "";
            public string? Email { get; set; } = "";
            public decimal Balance { get; set; }
            public DateTime CreatedAt { get; set; }
            public bool IsDeleted { get; set; }
        }


    

   

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool result = Accounts_BL.DeleteAccount(id);
                return result ? Ok("Account deleted") : NotFound("Account not found");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                int? accountId = Accounts_BL.Login(request.Email, request.Password);
                return accountId != null ? Ok(new { AccountId = accountId }) : Unauthorized("Invalid credentials");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetAccount(int id)
        {
            try
            {
                var account = Accounts_BL.GetAccountInfo(id);
                return account != null ? Ok(account) : NotFound("Account not found");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}/changepassword")]
        public IActionResult ChangePassword(int id, [FromBody] ChangePasswordRequest request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                bool result = Accounts_BL.ChangePassword(id, request.OldPassword, request.NewPassword);
                return result ? Ok("Password changed") : BadRequest("Old password is incorrect");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("GetAllAccounts")]
        public IActionResult GetAllAccounts([FromQuery] byte opt = 0)
        {
            try
            {
                var dt = Accounts_BL.GetAllAccounts(opt);

                var accounts = dt.AsEnumerable().Select(row => new AccountDTO
                {
                    AccountId = row.Field<int>("AccountId"),
                    FullName = row.Field<string>("FullName"),
                    Email = row.Field<string>("Email"),
                    Balance = row.Field<decimal>("Balance"),
                    CreatedAt = row.Field<DateTime>("CreatedAt"),
                    IsDeleted = row.Field<bool>("IsDeleted")
                }).ToList();
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
