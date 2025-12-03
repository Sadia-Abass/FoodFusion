using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.RestaurantDTO;
using FoodFusion.Server.Repositories.implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodFusion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly RestaurantRepository _restaurantRepository;

        public RestaurantController(RestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository ?? throw new ArgumentNullException(nameof(restaurantRepository));
        }

        [HttpGet("GetAllRestaurant")]
        public async Task<ActionResult<ApiResponse<List<RestaurantResponseDTO>>>> GetAllRestaurant()
        {
            var response = await _restaurantRepository.GetAllRestarantAsync();

            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpGet("GetRestaurantById/{id}")]
        public async Task<ActionResult<ApiResponse<RestaurantResponseDTO>>> GetRestaurantById(long id)
        {
            var response = await _restaurantRepository.GetRestaurantByIdAsync(id);

            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPost("CreateRestaurant")]
        public async Task<ActionResult<ApiResponse<RestaurantResponseDTO>>> CreateRestaurant([FromBody] CreateRestaurantDTO createRestaurantDTO)
        {
            var response = await _restaurantRepository.CreateRestaurantAsync(createRestaurantDTO);

            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPut("UpdateResaurant")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> UpdateResaurant([FromBody] UpdateRestaurantDTO updateRestaurantDTO)
        {
            var response = await _restaurantRepository.UpdateRestaurantAsync(updateRestaurantDTO);

            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpDelete("DeleteRestaurant")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> DeleteRestaurant(long id)
        {
            var response = await _restaurantRepository.DeleteRestaurantAsync(id);

            if (response.StatusCode != 200) 
            { 
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }
    }
}
