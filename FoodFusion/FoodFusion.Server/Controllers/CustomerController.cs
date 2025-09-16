using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.CustomerDTOs;
using FoodFusion.Server.Entities;
using FoodFusion.Server.Repositories.implementations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Xml;

namespace FoodFusion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly CustomerRepository _customerRepository;

        public CustomerController(UserManager<ApplicationUser> userManager, CustomerRepository customerRepository)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _customerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository));
        }

        [HttpGet("GetCustomerById")]
        [Authorize]
        public async Task<ActionResult<ApiResponse<CustomerRegistrationDTO>>> GetCustomerById()
        {
            var userId = HttpContext.User.FindFirstValue("userID");
            var customer = await _userManager.FindByIdAsync(userId);
            if (customer == null) 
            { 
                return NotFound();
            }

            var response = await _customerRepository.GetCustomerById(customer.Customer.CustomerID);
            if(response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPost("AddCustomerDetails")]
        [Authorize]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> AddCustomerDetails([FromBody] CustomerRegistrationDTO customerRegistrationDTO)
        {
            var userId = HttpContext.User.FindFirstValue("userID");
            var customer = await _userManager.FindByIdAsync(userId);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }
            else
            {
                var response = await _customerRepository.RegisterCustomerAsync(customerRegistrationDTO);
                if (response.StatusCode != 200) 
                {
                    return StatusCode(response.StatusCode, response);
                }

                return Ok(response);
            }              
        }

        [HttpPut("UpdateCustomerDetails")]
        [Authorize]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> UpdateCustomerDetails([FromBody] CustomerUpdateDTO customerUpdateDTO)
        {
            var userId = HttpContext.User.FindFirstValue("userID");
            var customer = await _userManager.FindByIdAsync(userId);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }
            else
            {
                var response = await _customerRepository.UpdateCustomerAsync(customerUpdateDTO);
                if (response.StatusCode != 200)
                {
                    return StatusCode(response.StatusCode, response);
                }

                return Ok(response);
            }
        }

        [HttpDelete("DeleteCustomerDetails/{id}")]
        [Authorize]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> DeleteCustomerDetails(long id)
        {
            var userId = HttpContext.User.FindFirstValue("userID");
            var customer = await _userManager.FindByIdAsync(userId);
            if (customer == null)
            {
                return NotFound("Customer not found");
            }
            else
            {
                var response = await _customerRepository.DeleteCustomerAsync(id);
                if (response.StatusCode != 200)
                {
                    return StatusCode(response.StatusCode, response);
                }

                return Ok(response);
            }
        }
    }
}
