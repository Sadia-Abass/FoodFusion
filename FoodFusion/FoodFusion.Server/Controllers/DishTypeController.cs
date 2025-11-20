using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.DishTypeDTOs;
using FoodFusion.Server.Repositories.implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodFusion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishTypeController : ControllerBase
    {
        private readonly DishTypeRepository _dishTypeRepository;

        public DishTypeController(DishTypeRepository dishTypeRepository)
        {
            _dishTypeRepository = dishTypeRepository ?? throw new ArgumentNullException(nameof(dishTypeRepository));
        }

        [HttpGet("GetAllDishType")]
        public async Task<ActionResult<ApiResponse<DishTypeResponseDTO>>> GetAllDishType()
        {
            var response = await _dishTypeRepository.GetAllDishTypeAsync();
            if(response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpGet("GetDishTypeById/{id}")]
        public async Task<ActionResult<ApiResponse<DishTypeResponseDTO>>> GetDishTypeById(long id)
        {
            var response = await _dishTypeRepository.GetDishTypeByIDAsync(id);
            if (response.StatusCode != 200) 
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPost("CreateDishType")]
        public async Task<ActionResult<ApiResponse<DishTypeResponseDTO>>> CreateDishType([FromBody] CreateDishTypeDTO createDishTypeDTO)
        {
            var response = await _dishTypeRepository.CreateDishTypeAsync(createDishTypeDTO);
            if (response.StatusCode != 200) 
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPut("UpdateDishType")]
        public async Task<ActionResult<ConfirmationResponseDTO>> UpdateDishType([FromBody] UpdateDishTypeDTO updateDishTypeDTO)
        {
            var response = await _dishTypeRepository.UpdateDishTypeAsync(updateDishTypeDTO);
            if(response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpDelete("DeleteDishType/{id}")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> DeleteDishType(long id)
        {
            var response = await _dishTypeRepository.DeleteDishTypeAsync(id);
            if (response.StatusCode != 200) 
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }
    }
}
