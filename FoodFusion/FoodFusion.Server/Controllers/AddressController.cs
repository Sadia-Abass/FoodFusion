using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.AddressesDTOs;
using FoodFusion.Server.Repositories.implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodFusion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly AddressRepository _addressRepository;

        // Injecting the services 
        public AddressController(AddressRepository addressRepository)
        {
            _addressRepository = addressRepository ?? throw new ArgumentNullException(nameof(addressRepository));
        }

        // Creates a new address for a customer.
        [HttpPost("CreateAddress")]
        public async Task<ActionResult<ApiResponse<AddressResponseDTO>>> CreateAddress([FromBody] AddressCreateDTO addressCreateDTO)
        {
            var response = await _addressRepository.CreateAddressAsync(addressCreateDTO);
            if(response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpGet("GetAddressById/{id}")]
        public async Task<ActionResult<ApiResponse<AddressResponseDTO>>> GetAddressById([FromHeader] long id)
        {
            var response = await _addressRepository.GetAddressByIdAsync(id);
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        // Updates an existing address.
        [HttpPut("UpdateAddress")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> UpdateAddress([FromBody] AddressUpdateDTO addressUpdateDTO)
        {
            var response = await _addressRepository.UpdateAddressAsync(addressUpdateDTO);
            if (response.StatusCode != 200) 
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        // Deletes an address by ID
        [HttpDelete("DeleteAddress")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> DeleteAddress([FromBody] AddressDeleteDTO addressDeleteDTO)
        {
            var response = await _addressRepository.DeleteAddressAsync(addressDeleteDTO);
            if( response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        // Retrieves all addresses for a specific customer.
        [HttpGet("GetAddressByCustomer/{customerId}")]
        public async Task<ActionResult<ApiResponse<AddressResponseDTO>>> GetAddressByCustomer([FromHeader] long customerId)
        {
            var response = await _addressRepository.GetAddressesByCustomerAsync(customerId);
            if(response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }
    }
}
