using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.CuisineDTOs;
using FoodFusion.Server.Repositories.implementations;
using FoodFusion.Server.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodFusion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuisineController : ControllerBase
    {
        private readonly ICuisineRepository _cuisineRepository;

        public CuisineController(ICuisineRepository cuisineRepository)
        {
            _cuisineRepository = cuisineRepository ?? throw new ArgumentNullException(nameof(cuisineRepository));
        }

        [HttpGet("GetAllCuisines")]
        public async Task<ActionResult<ApiResponse<List<CuisineResponseDTO>>>> GetAllCuisines()
        {
            var response = await _cuisineRepository.GetAllCuisineAsync();
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpGet("GetCuisineById/{id}")]
        public async Task<ActionResult<ApiResponse<CuisineResponseDTO>>> GetCuisineById(long id)
        {
            var response = await _cuisineRepository.GetCuisineByIdAsync(id);
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPost("CreateCuisine")]
        public async Task<ActionResult<ApiResponse<CuisineResponseDTO>>> CreateCuisine([FromBody] CreateCuisineDTO createCuisineDTO)
        {
            var response = await _cuisineRepository.CreateCuisineAsync(createCuisineDTO);
            if(response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPut("UpdateCuisine")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> UpdateCuisine([FromBody] UpdateCuisineDTO updateCuisineDTO)
        {
            var response = await _cuisineRepository.UpdateCuisineAsync(updateCuisineDTO);
            if(response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpDelete("DeleteCuisine/{id}")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> DeleteCuisine(long id)
        {
            var response = await _cuisineRepository.DeleteCuisineByIdAsync(id);
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }
    }
}
