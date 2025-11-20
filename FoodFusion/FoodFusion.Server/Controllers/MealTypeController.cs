using FoodFusion.Server.DTOs;
using FoodFusion.Server.DTOs.MealTypeDTOs;
using FoodFusion.Server.Repositories.implementations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodFusion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealTypeController : ControllerBase
    {
        private readonly MealTypeRepository _mealTypeRepository;

        public MealTypeController(MealTypeRepository mealTypeRepository)
        {
            _mealTypeRepository = mealTypeRepository ?? throw new ArgumentNullException(nameof(mealTypeRepository));
        }

        [HttpGet("GetAllMealType")]
        public async Task<ActionResult<ApiResponse<List<MealTypeResponseDTO>>>> GetAllMealType()
        {
            var response = await _mealTypeRepository.GetAllMealTypeAsync();
            if(response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpDelete("GetMealTypeById/{id}")]
        public async Task<ActionResult<ApiResponse<MealTypeResponseDTO>>> GetMealTypeById(long id)
        {
            var response = await _mealTypeRepository.GetMealTypeByIdAsync(id);
            if (response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPost("CreateMealType")]
        public async Task<ActionResult<ApiResponse<MealTypeResponseDTO>>> CreateMealType([FromBody] CreateMealTypeDTO createMealTypeDTO)
        {
            var response = await _mealTypeRepository.CreateMealTypeAsync(createMealTypeDTO);
            if(response.StatusCode != 200)
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpPut("UpdateMealType")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> UpdateMealType([FromBody] UpdateMealTypeDTO updateMealTypeDTO)
        {
            var response = await _mealTypeRepository.UpadteMealTypeAsync(updateMealTypeDTO);
            if (response.StatusCode != 200) 
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }

        [HttpDelete("DeleteMealType/{id}")]
        public async Task<ActionResult<ApiResponse<ConfirmationResponseDTO>>> DeleteMealType(long id)
        {
            var response = await _mealTypeRepository.DeleteMealTypeAsync(id);
            if (response.StatusCode != 200) 
            {
                return StatusCode(response.StatusCode, response);
            }

            return Ok(response);
        }
    }
}
